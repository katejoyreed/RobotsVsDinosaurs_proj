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
                Console.WriteLine($"The attack did {weapon.attackPower} damage!");
                powerLevel = (powerLevel - 10);
            }
        }

        public double TakeDamage(Dinosaur dinosaur) 
        {
            hitPoints = (hitPoints - dinosaur.attackPower);
            Console.WriteLine($"Took {dinosaur.attackPower} damage!");
            return hitPoints;
        }
    }
}
