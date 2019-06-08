using CSharpOOP.Enumerations;
using CSharpOOP.Interfaces;
using System;
using System.Threading;
using Weapons;

namespace Characters.Warriors
{
    public class Warrior : Character, ICalculator 
    {   
        private static int idCounter;

        public static int IdCounter
        {
            get
            {
                return Warrior.idCounter;
            }
            set
            {
                Warrior.idCounter = value;
            }
        }

        private readonly int id;
        private int height;
        private string name;
        private Faction faction;
        private Sword swordWeapon;

        public int ID 
        { 
            get
            {
               return this.id;
            }
        }      
        
        
        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }
        public Faction Faction
        {
            get
            {
                return this.faction;
            }
            private set
            {
                this.faction = value;
            }
        }
        public Sword SwordWeapon
        {
            get
            {
                return this.swordWeapon;
            }
            set
            {
                this.swordWeapon = value;
            }
        }

        public Warrior()
            : this(170, 70)
        {
        }

        public Warrior(int height, int weight)
            : this(height, weight, "Young Warrior", Faction.Default)
        {
        }

        public Warrior(int height, int weight, string name, Faction faction)
        {   
            idCounter++;

            this.id = idCounter;
            this.Height = height;
            base.Weight = weight;
            this.Name = name;
            this.Faction = faction;
            base.Age = 18;
            this.SwordWeapon = new Sword();

            if (this.Faction == Faction.GoodGuy)
            {
                base.HealthPoints = 120;
            }
            else if (this.Faction == Faction.BadGuy)
            {
                base.HealthPoints = 100;
            }

        }

        public void SpecialWarriorGreeting()
        {
            base.Greetings(base.Name);
        }

        public Warrior(int healthPoints, int weight, int age, int height)
            : base(healthPoints, weight, age)
        {
            this.Height = height;
        }

        public override void Move(int sleeptime)
        {
            base.Move(sleeptime);
            Console.WriteLine("New Moving");
        }

        public void Addition(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber+secondNumber);
        }
    }
}