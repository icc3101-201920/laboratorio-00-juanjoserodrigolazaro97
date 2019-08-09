using System;
using System.Collections.Generic;

namespace lab1
{
    public class Deck
    {

        List<CombatCard> combatCards = new List<CombatCard>();
        List<CombatCard> specialCards = new List<CombatCard>();
        private List<CombatCard> CombatCards { get { return combatCards; } set { combatCards = value; } }
        private List<CombatCard> SpecialCards { get { return specialCards; } set { specialCards = value; } }

        public void AddCombatCard(CombatCard combatCard)
        {
        }
        public void AddSpecialCard(SpecialCard specialCard)
        {
        }
        public void DestroyCombatCard(int cardId)
        {
        }
        public void DestroySpecialCard(int cardId)
        {
        }
        public void Shuffle()
        {
        }
        
    }
}
