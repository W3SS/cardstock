using System.Collections.Generic;
using System;
using Players;
using System.Text;
namespace CardEngine
{
	public class Player{
		public IntStorage storage;
		public CardStorage cardBins; 
		public Team team; 
        public string name; 
		public GeneralPlayer decision; // Don't include this
		public Player(){
			storage = new IntStorage();
			cardBins = new CardStorage();
			cardBins.owner = this;
		}
		public Player Clone(){
            Player other = new Player();
			other.storage = storage.Clone ();
			other.cardBins = cardBins.Clone ();
            other.name = name;
			other.cardBins.owner = other;
            other.decision = decision;
            return other;
		}
		public void IncrValue(int bin, int value){ // is the bin always the same across all players?
			storage.storage[bin] += value;
		}
		public Card RemoveCard(int idx){
			return cardBins.storage[idx].Remove();
		}
		public int MakeAction(List<GameAction> possibles,Random rand){
			return rand.Next(0,possibles.Count);
		}
		public override string ToString(){
			StringBuilder ret = new StringBuilder("Player:\n");
			ret.Append (cardBins.ToString ());
			return ret.ToString();
		}
        public override bool Equals(System.Object obj)
        {
            if (obj == null)
            { return false; }

            Player otherplayer = obj as Player;
            if ((System.Object)otherplayer == null)
            { return false; }

            if (!storage.Equals(otherplayer.storage) || !cardBins.Equals(otherplayer.cardBins)) 
            { return false; }

            if (name != otherplayer.name || team != otherplayer.team)
            { return false; }

            return true;
        }

        public override int GetHashCode() // XORs relevant hashcodes
        {
            return name.GetHashCode() ^ team.GetHashCode() ^ storage.GetHashCode() ^ cardBins.GetHashCode();
        }

    }
}
