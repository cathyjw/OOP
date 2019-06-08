using Characters;
using Characters.Spellcasters;
using Characters.Warriors;
using CSharpOOP.Enumerations;
using System;
using System.Collections.Generic;

public class EntryPoint
{
    static void Main()
    {
        Warrior firstWarrior = new Warrior(150, 50, "Name", Faction.BadGuy);
        //firstWarrior.Addition(4, 6);
        //firstWarrior.Move(100);

        Mage firstMega = new Mage();

        Character secondWarrior = new Warrior();
        Warrior tempWarrior = (Warrior)secondWarrior;
        secondWarrior.Move(5);

        List<Character> theCharacters = new List<Character>();
        theCharacters.Add(firstWarrior);
        theCharacters.Add(firstMega);

        Console.WriteLine(firstWarrior.HealthPoints);
        Console.WriteLine(firstMega.Mana);

        firstMega.CastSpell(firstWarrior);

        Console.WriteLine(firstWarrior.HealthPoints);
        Console.WriteLine(firstMega.Mana);

        //firstMega.Move(10000);
        firstMega.Addition(1, 2);
        Console.WriteLine(firstWarrior.Age);

        try
        {
            //firstWarrior.Age = 15;
            firstMega.Age = 25;
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }

        //Warrior secondWarrior = new Warrior(150, 50);

        //Warrior thirdWarrior = new Warrior(140, 78, "I am the third warrior!");
        //Warrior thirdWarrior = new Warrior(140, 78);

        //Warrior fouthWarrior = new Warrior(150, 40, "Name", Faction.GoodGuy);
        //Mage firstMage = new Mage();
        //Console.WriteLine(fouthWarrior.Name);
        //Console.WriteLine(fouthWarrior.HealthPoints);

        //Tools.ColorfulWriteLine(firstWarrior.ID.ToString(), ConsoleColor.DarkBlue);
        //Tools.ColorfulWriteLine(secondWarrior.ID.ToString(), ConsoleColor.Red);
        //Tools.ColorfulWriteLine(thirdWarrior.ID.ToString(), ConsoleColor.Green);

        Console.Read();

        //Console.WriteLine(firstWarrior.Name);
        //Console.WriteLine(thirdWarrior.Name);
    }
}