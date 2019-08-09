using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
     public class CombatCard
    {
        static void Main(string[] args)
        {
            private string name;
        private int attackPoints;
        private bool Hero;
        private string type;
        private string effect;

        public CombatCard(string name, int attackPoints, bool hero, string type, string effect);
        public string Name { get => name; set => name = value; }
        public int AttackPoints { get => attackPoints; set => attackPoints = value; }
        public string Type { get => type; set => type = value; }
        public string Effect { get => effect; set => effect = value; }

    }

    public class SpecialCard
    {
        private string name;
        private string type;
        private string buffType;
        private string effect;

        public SpecialCard(string name, string type, string buffType, string effect);
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string BuffType { get => buffType; set => buffType = value; }
        public string Effect { get => effect; set => effect = value; }
    }

    public class Player
    {
        private int lifePoints;
        private int attackPoints;
        private Deck deck;
        private Hand hand;
        private Board board;
        private SpecialCard captain;

        public int LifePoints { get => lifePoints; set => lifePoints = value; }
        public int AttackPoints { get => attackPoints; set => attackPoints = value; }
    }
}
