using System;
using System.Collections.Generic;

namespace lab1
{
    public class Board
    {
        List<CombatCard> meleeCards = new List<CombatCard>();
        List<CombatCard> rangeCards = new List<CombatCard>();
        List<CombatCard> longRangeCards = new List<CombatCard>();
        SpecialCard specialMeleeCards = new SpecialCard();
        SpecialCard specialRangeCards = new SpecialCard();
        SpecialCard specialLongRangeCards = new SpecialCard();
        List<SpecialCard> captainCards = new List<SpecialCard>();
        List<SpecialCard> weatherCards = new List<SpecialCard>();



        private List<CombatCard> MeleeCards{get{return meleeCards;}set{meleeCards = value;}}
        private List<CombatCard> RangeCards{get{return rangeCards;}set{rangeCards = value;}}
        private List<CombatCard> LongRangeCards{get{return longRangeCards;}set{longRangeCards = value;}}
        private SpecialCard SpecialMeleeCards{get{return specialMeleeCards;}set{specialMeleeCards = value;}}
        private SpecialCard SpecialRangeCards{get{return specialRangeCards;}set{specialRangeCards = value;}}
        private SpecialCard SpecialLongRangeCards{get{return specialLongRangeCards;}set{specialLongRangeCards = value;}}
        private List<SpecialCard> CaptainCards{get{return captainCards;}set{captainCards = value;}}
        private List<SpecialCard> WeatherCards{get{return weatherCards;}set{weatherCards = value;}}



        public void AddComnatCard(int playerId, CombatCard combatCard) {
        }
        public void AddSpecialCard(int playerId, SpecialCard specialCard) {
        }
        public void DestroyCombatCards() {
        }
        public void DestroySpecialCards() {
        }
        public void GetMeleeAttackPoints() {
        }
        public void GetRangeAttackPoints() {
        }
        public void GetLongRangeAttackPoints() {
        }

    }
}
