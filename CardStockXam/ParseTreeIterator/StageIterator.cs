using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;
using Antlr4.Runtime.Tree;
using CardEngine;

using Analytics;

namespace ParseTreeIterator
{
	public class StageIterator{
		public static void ProcessGame(RecycleParser.GameContext game){
			SetupIterator.ProcessSetup(game.setup()).ExecuteAll();
			
			for (int i = 3; i < game.ChildCount - 2; ++i){
				ProcessMultiaction(game.GetChild(i));
			}
		}
		public static void ProcessStage(RecycleParser.StageContext stage){
			CardGame.Instance.PushPlayer();
			if (stage.endcondition().boolean() != null){
				TimeStep.Instance.timeStep.Push(0);
				while (!BooleanIterator.ProcessBoolean(stage.endcondition().boolean())){
					StageCount.Instance.IncCount(stage);
					TimeStep.Instance.timeStep.Push(TimeStep.Instance.timeStep.Pop() + 1);
					Debug.WriteLine("Current Player: " + CardGame.Instance.CurrentPlayer().idx);

                    CardGame.Instance.WriteToFile("t:" + CardGame.Instance.CurrentPlayer().idx);
					foreach (var player in CardGame.Instance.players) {
						Debug.WriteLine("HANDSIZE: " + player.cardBins["HAND"].Count);
					}
					for (int i = 4; i < stage.ChildCount - 1; ++i){
						TimeStep.Instance.treeLoc.Push(i - 4);
						Debug.WriteLine(TimeStep.Instance);
						ProcessMultiaction(stage.GetChild(i));
						TimeStep.Instance.treeLoc.Pop();
					}
					if (stage.GetChild(2).GetText() == "player"){
						CardGame.Instance.CurrentPlayer().Next();
					}
					else if (stage.GetChild(2).GetText() == "team"){
						CardGame.Instance.CurrentTeam().Next();
					}
					
				}
				TimeStep.Instance.timeStep.Pop();
			}
			CardGame.Instance.PopPlayer();
		}
		public static List<GameActionCollection> ProcessMultiaction(IParseTree sub){
            var lst = new List<GameActionCollection>();
			if (sub is RecycleParser.MultiactionContext){
                var multiaction = sub as RecycleParser.MultiactionContext;
                if (multiaction.agg() != null)
                {
                    lst.AddRange((List<GameActionCollection>)VarIterator.ProcessAgg(multiaction.agg()));
                }
                else if (multiaction.let() != null)
                {
                    lst.AddRange(VarIterator.ProcessLet(multiaction.let()));
                }
                else if (multiaction.GetChild(1).GetText() == "choice") {
                    ProcessChoice(multiaction.condact());
                }
                else if (multiaction.GetChild(1).GetText() == "do") {
                    lst.AddRange(ActionIterator.ProcessDo(multiaction.condact()));
                }
            }
            else if (sub is RecycleParser.StageContext)
            {
                ProcessStage(sub as RecycleParser.StageContext);
            }
            else{//multiaction2
                var multiaction = (RecycleParser.Multiaction2Context) sub;
                if (multiaction.agg() != null){
                    lst.AddRange((List<GameActionCollection>)VarIterator.ProcessAgg(multiaction.agg()));
                }
                else if (multiaction.let() != null){
                    lst.AddRange(VarIterator.ProcessLet(multiaction.let()));
                }
                else{ //do
                    lst.AddRange(ActionIterator.ProcessDo(multiaction.condact()));
                }
                
            }
            return lst;
		}
        public static void ProcessChoice(RecycleParser.CondactContext[] choices){
			var allOptions = new List<GameActionCollection>();
			Dictionary<int, int> skips = new Dictionary<int,int>();
            for (int i = 0; i < choices.Length; ++i){
                var gameaction = choices[i];
                int startingIdx = allOptions.Count;
                var gacs = ProcessCondactChoice(gameaction);
                allOptions.AddRange(gacs);
                for (int j = startingIdx; j < allOptions.Count; ++j){
                    skips.Add(j, i);
                }
            }
			BranchingFactor.Instance.AddCount(allOptions.Count,CardGame.Instance.CurrentPlayer().idx);
			Boolean satisfied = false;
			int chosenIdx = ParseEngine.currentIterator.decisionBranch;
			int iteratorCount = ParseEngine.currentIterator.decisionIdx;
			while (!satisfied) {
				
				ParseEngine.currentIterator.decisionBranch = chosenIdx;
				ParseEngine.currentIterator.decisionIdx = iteratorCount;
				++iteratorCount;
				if (chosenIdx == -1) {
					if (allOptions.Count != 0) {
						Debug.WriteLine ("Choice count:" + allOptions.Count);
						chosenIdx = skips[CardGame.Instance.PlayerMakeChoice (allOptions, CardGame.Instance.CurrentPlayer ().idx)];
					} else {
						Debug.WriteLine ("NO Choice Available");

					}
				} else {
					allOptions.Clear ();
					allOptions.AddRange(ProcessMultiaction((choices[chosenIdx] as RecycleParser.CondactContext).multiaction2()));
					if (allOptions.Count != 0) {
						Debug.WriteLine ("Choice count:" + allOptions.Count);
						CardGame.Instance.PlayerMakeChoice (allOptions, CardGame.Instance.CurrentPlayer ().idx);
					} else {
						Debug.WriteLine ("NO Choice Available");

					}
				}
				if (iteratorCount == (choices[chosenIdx] as RecycleParser.CondactContext).multiaction2().ChildCount - 1) {
					satisfied = true;
					ParseEngine.currentIterator.decisionBranch = -1;
					ParseEngine.currentIterator.decisionIdx = -1;
				}

			}
		}

		/*public static List<GameActionCollection> ProcessMultiactionChoice(RecycleParser.Multiaction2Context actions, int idx){
            var allOptions = new List<GameActionCollection>();
            if (actions.agg() != null){
                return (List<GameActionCollection>) VarIterator.ProcessAgg(actions.agg());
            }
            else if (actions.let() != null){
                allOptions.AddRange(VarIterator.ProcessLet(actions.let()));
            }
            else {//do
                foreach (RecycleParser.CondactContext cond in actions.condact()){
                    allOptions.AddRange(ProcessCondactChoice(cond));
                }
            }
			//Console.WriteLine("action children");
			/*var options = ProcessActionChoice(actions.GetChild(i)  as RecycleParser.ActionContext);
			var temp = new List<GameActionCollection>();
			//if (allOptions.Count == 0){
			temp = options;
            foreach (var additionalAction in options)
            {
                foreach (var sourcePerm in allOptions)
                {
                    var copyPerm = new GameActionCollection();
                    copyPerm.AddRange(sourcePerm);
                    copyPerm.AddRange(additionalAction);
                    temp.Add(copyPerm);
                }
            }
			
			allOptions = temp;
			Debug.WriteLine("MultiActionChoiceCount:" + allOptions.Count);
			return allOptions;
		*/

        public static List<GameActionCollection> ProcessCondactChoice(RecycleParser.CondactContext cond)//TODO pass in boolean
        {
            var allOptions = new List<GameActionCollection>();
            bool condition = true;
            if (cond.boolean() != null){
                condition = BooleanIterator.ProcessBoolean(cond.boolean());
            }
            if (condition){
                if (cond.multiaction2() != null)
                {
                    allOptions.AddRange(ProcessMultiaction(cond.multiaction2()));
                }
                else if (cond.action() != null)
                {
                    allOptions.Add(ActionIterator.ProcessAction(cond.action()));
                }
            }
            return allOptions;
        }
		public static List<GameActionCollection> ProcessMultiActionChoice(RecycleParser.Multiaction2Context actions){
			/*var allOptions = new List<GameActionCollection> ();
			int i = 0;
			//Console.WriteLine("action children");
			var options = ProcessActionChoice (actions.GetChild (i)  as RecycleParser.ActionContext);
			var temp = new List<GameActionCollection> ();
			//if (allOptions.Count == 0){
			temp = options;
			/*}
				else{
					foreach (var additionalAction in options){
						foreach (var sourcePerm in allOptions){
							var copyPerm = new GameActionCollection();
							copyPerm.AddRange(sourcePerm);
							copyPerm.AddRange(additionalAction);
							temp.Add(copyPerm);
						}
					}
				}
			allOptions = temp;


			Debug.WriteLine ("MultiActionChoiceCount:" + allOptions.Count);
			return allOptions;
			*/
            return null;
		}
    }
}