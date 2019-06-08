using System;
using Characters.Warriors;
using CSharpOOP.Interfaces;
using CSharpOOP.Weapons;

namespace Characters.Spellcasters
{
    public class Mage: Character, ICalculator, ISpellcaster
    {
        private int mana;
        private Spell mySpell;
        public override int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value >= 30 && value <= 60)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Age should be 30-60");
                }
            }
        }

        //shenyi: lamda expression make readonly property.
        //compare private, protected and public

        public int Mana => this.mana;

        //public int Mana
        //{
        //    get
        //    {
        //        return this.mana;
        //    }
        //    set
        //    {
        //        this.mana = value;
        //    }
        //}

        public Spell MySpell
        {
            get
            {
                return this.mySpell;
            }
            set
            {
                this.mySpell = value;
            }
        }

        public Mage(int healthpoints, int weight, int age)
            :base(healthpoints, weight, age)
        {
            
        }
        //public Mage(int i)
        //{

        //}

        public Mage()
        {
            mana = 100;
            this.MySpell = new Spell();
        }

        public override void Move(int sleeptime)
        {
            base.Move(sleeptime);
            System.Console.WriteLine("override moving");
        }

        public override int Addition(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            int modifiedSum = sum + 10;
            Console.WriteLine(modifiedSum-10);
            return modifiedSum;
        }

        public void CastSpell(Character character)
        {
            character.HealthPoints = character.HealthPoints - this.mySpell.Damage;
            this.mana = this.mana - this.mySpell.ManaCost;
        }
    }
}
