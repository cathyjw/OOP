using CSharpOOP.Interfaces;
using System;
using System.Threading;

namespace Characters
{
    public class Character: ICalculator
    {
        private string name;
        private int healthPoints;
        private int weight;
        
        //protected type can be accessed in same class and derived class
        //age can be used in Mage
        protected int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                this.healthPoints = value;
            }
        }

        public int Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }

        public virtual int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value >= 18 && value <= 45)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Age should be 18-45");
                }
            }
        }

        public Character()
        {

        }

        public Character(int healthPoints, int weight, int age)
        {
            this.HealthPoints = healthPoints;
            this.Weight = weight;
            this.Age = age;
        }

        protected void Greetings(String name)
        {
            Console.WriteLine($@"{this.Name} greetings {name}!");
        }

        public virtual void Move(int sleeptime)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("I am moving");
                Thread.Sleep(sleeptime);
            }
        }

        public virtual int Addition(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        void ICalculator.Addition(int firstNumber, int secondNumber)
        {
            throw new NotImplementedException();
        }
    }
}