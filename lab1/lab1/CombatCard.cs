using System;
namespace lab1
{
    public class CombatCard
    {
        string name;
        int attackPoints;
        bool hero;
        string type;
        string effect;

        private string Name{get{return name;}set{name = value;}}
        private int AttackPoints { get { return attackPoints; } set { attackPoints = value; } }
        private bool Hero { get { return hero; } set { hero = value; } }
        private string Type { get { return type; } set { type = value; } }
        private string Effect { get { return effect; } set { effect = value; } }


    }
}
