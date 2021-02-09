using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVDinos
{
    class Dinosaur
    {//member variables
        public string type;
        public double hitPoints;
        public double energy;
        public double attackPower;
        

        //ctor
        public Dinosaur(string type, double hitPoints, double energy, double attackPower)
        {
            this.type = type;
            this.hitPoints = hitPoints;
            this.energy = energy;
            this.attackPower = attackPower;
        }

        //member methods

        public void Attack() 
        {
            if (energy >= 10) 
            {
                Console.WriteLine($"{type}'s attack did {attackPower} damage!");
                energy = (energy - 10);
            }

            else 
            {
                Console.WriteLine("Not enough energy to attack!");
            }
            
        }

        public void TakeDamage(Weapon weapon, Dinosaur dinosaur, Herd herd) 
        {
            hitPoints = (hitPoints - weapon.attackPower);
            Console.WriteLine($"{type} took {weapon.attackPower} damage!");
            Console.WriteLine($"{type} has {hitPoints} HP remaining!");
            if (dinosaur.hitPoints <= 0)
            {
                herd.RemoveFromHerd(dinosaur);
            }
            
        }

        public void Rest() 
        {
            energy = (energy + 10);
        }

        public void DinosaurUserPrompt(Robot robot, Dinosaur dinosaur, Fleet fleet) 
        {

            Console.WriteLine($"Would you like {type} to attack or rest?");
            string answer = Console.ReadLine();

            if (answer.Equals("attack", StringComparison.OrdinalIgnoreCase))
            {
                Attack();
                robot.TakeDamage(dinosaur, robot, fleet);
                Console.WriteLine($"{dinosaur.type} has {energy} energy remaining");
            }

            else if (answer.Equals("rest", StringComparison.OrdinalIgnoreCase))
            {
                if (energy < 100)
                {
                    Rest();
                }

                else
                {
                    Console.WriteLine($"{type} already has full energy.");
                    Console.WriteLine("Please make a valid selction");
                    DinosaurUserPrompt(robot, dinosaur, fleet);
                }

            }

            else
            {
                Console.WriteLine("Please make a valid selection");
                DinosaurUserPrompt(robot, dinosaur, fleet);
            }
        }
    }
}
