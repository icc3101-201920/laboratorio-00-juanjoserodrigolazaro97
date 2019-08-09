using System;
namespace lab1
{
    public class Player
    {
        int lifePoints;
        int attackPoints;
        Deck deck;
        Hand hand;
        Board board;
        SpecialCard captain;

        private int LifePoints { get { return lifePoints; } set { lifePoints = value; } }
        private int AttackPoints { get { return attackPoints; } set { attackPoints = value; } }
        private Deck Deck { get { return deck; } set { deck = value; } }
        private Hand Hand { get { return hand; } set { hand = value; } }
        private Board Board { get { return board; } set { board = value; } }
        private SpecialCard SpecialCard { get { return captain; } set { captain = value; } }

        public void DrawCard() {
        }
        public void PlayCard(int cardId)
        {
        }
        public void ChangeCard(int card)
        {
        }
        public void FirstHand()
        {
        }
        public void ChooseCaptainCard(SpecialCard captainCard)
        {
        }
    }
}
