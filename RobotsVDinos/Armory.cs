﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVDinos
{
    class Armory
    {
        public List<Weapon> armory;

        public Armory()
        {
            armory = new List<Weapon>();
        }

        public Weapon CreateWeapon(string type, double attackPower)
        {
            Weapon weapon = new Weapon(type, attackPower);
            return weapon;
        }

        public void PopulateArmory(Weapon weapon)
        {
            armory.Add(weapon);
        }

         

        public Weapon ChooseWeapon1()
        {
            Console.WriteLine("Choose a weapon for your first robot by typing the name of the weapon.");
            Console.WriteLine($"1. {armory[0].type}, attack power: {armory[0].attackPower}");
            Console.WriteLine($"2. {armory[1].type}, attack power: {armory[1].attackPower}");
            Console.WriteLine($"3. {armory[2].type}, attack power: {armory[2].attackPower}");

            string userInput = Console.ReadLine();

            if (userInput.Contains($"{armory[0].type}", StringComparison.OrdinalIgnoreCase))
            {
                Weapon weapon = armory[0];
                return weapon;
            }
            else if (userInput.Contains($"{armory[1].type}", StringComparison.OrdinalIgnoreCase))
            {
                Weapon weapon = armory[1];
                return weapon;
            }
            else if (userInput.Contains($"{armory[2].type}", StringComparison.OrdinalIgnoreCase))
            {
                Weapon weapon = armory[2];
                return weapon;
            }
            else 
            {
                Console.WriteLine("Please make a valid selection");
                Weapon weapon = new Weapon(null, 0);
                
                ChooseWeapon1();
                return weapon;
            }



        }
        public Weapon ChooseWeapon2()
        {
            Console.WriteLine("Choose a weapon for your second robot by typing the name of the weapon.");
            Console.WriteLine($"1. {armory[0].type}, attack power: {armory[0].attackPower}");
            Console.WriteLine($"2. {armory[1].type}, attack power: {armory[1].attackPower}");
            Console.WriteLine($"3. {armory[2].type}, attack power: {armory[2].attackPower}");

            string userInput = Console.ReadLine();

            if (userInput.Contains($"{armory[0].type}", StringComparison.OrdinalIgnoreCase))
            {
                Weapon weapon = armory[0];
                return weapon;
            }
            else if (userInput.Contains($"{armory[1].type}", StringComparison.OrdinalIgnoreCase))
            {
                Weapon weapon = armory[1];
                return weapon;
            }
            else if (userInput.Contains($"{armory[2].type}", StringComparison.OrdinalIgnoreCase))
            {
                Weapon weapon = armory[2];
                return weapon;
            }
            else
            {
                Console.WriteLine("Please make a valid selection");
                Weapon weapon = new Weapon(null, 0);
                ChooseWeapon2();
                return weapon;
            }

        }
        public Weapon ChooseWeapon3() 
        {
            Console.WriteLine("Choose a weapon for your third robot by typing ithe name of the weapon.");
            Console.WriteLine($"1. {armory[0].type}, attack power: {armory[0].attackPower}");
            Console.WriteLine($"2. {armory[1].type}, attack power: {armory[1].attackPower}");
            Console.WriteLine($"3. {armory[2].type}, attack power: {armory[2].attackPower}");

            string userInput = Console.ReadLine();

            if (userInput.Contains($"{armory[0].type}", StringComparison.OrdinalIgnoreCase))
            {
                Weapon weapon = armory[0];
                return weapon;
                
            }
            else if (userInput.Contains($"{armory[1].type}", StringComparison.OrdinalIgnoreCase))
            {
                Weapon weapon = armory[1];
                return weapon;
                
            }
            else if (userInput.Contains($"{armory[2].type}", StringComparison.OrdinalIgnoreCase))
            {
                Weapon weapon = armory[2];
                return weapon;
                
            }
            else
            {
                Console.WriteLine("Please make a valid selection");
                Weapon weapon = new Weapon(null, 0);
                
                ChooseWeapon3();
                return weapon;
            }
        }


    }
}
