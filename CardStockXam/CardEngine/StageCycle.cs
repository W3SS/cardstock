using System.Collections.Generic;
using System.Linq;

namespace CardEngine{

    /********
     * A StageCycle lets you iterate repeatedly through the Players or
     * Teams as part of a Stage in the game. The language in these 
     * comments will assume a clockwise order to the players, so 
     * that the person to your left is next to play, and the person
     * to your right is the previous player.
     */
	public class StageCycle<T>{

        // Who is in your cycle
        public readonly IReadOnlyList<T> memberList;

        // The current player
		public int idx = 0;

        // The index of a player queued up to go next instead of idx++
		public int queuedNext = -1;

        // For Logging of the turn cycle in the transcript
        public CardGame cg;

        /********
         * Create a new StageCycle from a list of Teams or Players,
         * keep the cg for logging the transcript.
         */
		public StageCycle(IReadOnlyList<T> pList, CardGame cg){
            memberList = pList;
            this.cg = cg;

            // When the game starts, tell us who is the first player
			WriteMember();
		}

        /********
         * A way to ShallowCopy the given source StageCycle when going into
         * a deeper stage
         */
        public StageCycle(StageCycle<T> source){
			memberList = source.memberList;
			idx = source.idx;
            cg = source.cg;
        }

        /*******
         * Return the current player based on the index into the Cycle
         */
        public T Current()
        {
            return memberList[idx];
        }

        /******
         * Who is currently scheduled to play next?
         */
		public T PeekNext(){
            if (queuedNext != -1) {
                return memberList[queuedNext];
            } else {
                int next = idx++;
                next %= memberList.Count;
                return memberList[next];
            }
        }

        /******
         * Who is to the right of the current player? NOT WHO WENT BEFORE
         */
		public T PeekPrevious(){
            int prev = idx - 1;
			if (prev < 0){
				prev = memberList.Count - 1;
			}
            return memberList[prev];
		}

        /*******
         * Iterate to the next player, and log it to the transcript
         */
		public void Next(){
			if (queuedNext != -1){
				idx = queuedNext;
                queuedNext = -1; //-AH
			}
			else{
				idx++;
                idx %= memberList.Count;
			}

			WriteMember();
		}

        /******
         * Immediately change the current player within the current turn
         */
		public void SetMember(int index){
			idx = index;
            WriteMember();
        }

        /*******
         * Queues up the next player for when the the cycle iterates
         */
		public void SetNext(int index){
			queuedNext = index;
		}

        /******
         * A way to Undo the GameAction that queued up the next player
         */
        public void RevertNext(){
			queuedNext = -1;
		}

        /******
         * For logging the current player when their turn starts
         */
        private void WriteMember() {
			var who = memberList[idx] as Owner;
            if (who != null)
            {
                cg.WriteToFile("t:" + who.name);
            }			
		}

        public override bool Equals(System.Object obj)
        {
            if (obj == null)
            { return false; }

            StageCycle<T> othercycle = obj as StageCycle<T>;
            if ((System.Object)othercycle == null)
            { return false; }

            // Compare the StageCycles
            if (idx != othercycle.idx)
            { return false; }

            if (queuedNext != othercycle.queuedNext)
            { return false; }

            if (!(memberList.SequenceEqual(othercycle.memberList)))
            { return false; }

            return true;
        }

        public override int GetHashCode()
        {
            int hash = 0;
            foreach (var member in memberList)
            {
                hash ^= member.GetHashCode();
            }
            return idx.GetHashCode() ^ hash ^ queuedNext.GetHashCode();
        }

    }
}