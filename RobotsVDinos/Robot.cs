using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVDinos
{
    class Robot
    {
        //member variables
        public string robotName;
        public double hitPoints;
        public double powerLevel;
        public Weapon weapon;
        

        //ctor
        public Robot(string robotName, double hitPoints, double powerLevel, Weapon weapon)
        {
            this.robotName = robotName;
            this.hitPoints = hitPoints;
            this.powerLevel = powerLevel;
            this.weapon = weapon;
            

        }


        //member methods

        public void Attack(Weapon weapon) 
        {
            if (powerLevel >= 10)
            {
                Console.WriteLine($"{robotName}'s attack did {weapon.attackPower} damage!");
                powerLevel = (powerLevel - 10);
            }
        }

        public void TakeDamage(Dinosaur dinosaur, Robot robot, Fleet fleet) 
        {
            hitPoints = (hitPoints - dinosaur.attackPower);
            Console.WriteLine($"{robotName} took {dinosaur.attackPower} damage!");
            Console.WriteLine($"{robotName} has {hitPoints} HP remaining!");
            if (robot.hitPoints <= 0)
            {
                fleet.RemoveFromFleet(robot);
            }
        }

        public void Recharge() 
        {
            powerLevel = (powerLevel + 10);
        
        }

        public void RobotUserPrompt(Dinosaur dinosaur, Herd herd) 
        {
            Console.WriteLine($"Would you like {robotName} to attack or recharge?");
            string answer = Console.ReadLine();
           
            if (answer.Equals("attack", StringComparison.OrdinalIgnoreCase)) 
            {
                Attack(weapon);
                dinosaur.TakeDamage(weapon, dinosaur, herd);
                Console.WriteLine($"{robotName} has {powerLevel} power remaining!");
            }

            else if (answer.Equals("recharge", StringComparison.OrdinalIgnoreCase)) 
            {
                if (powerLevel < 100)
                {
                    Recharge();
                }

                else 
                {
                    Console.WriteLine($"{robotName} already has full power.");
                    Console.WriteLine("Please make a valid selction");
                    RobotUserPrompt(dinosaur, herd);
                }
                    
            }

            else 
            {
                Console.WriteLine("Please make a valid selection");
                RobotUserPrompt(dinosaur, herd);
            }
        }
    }
}
