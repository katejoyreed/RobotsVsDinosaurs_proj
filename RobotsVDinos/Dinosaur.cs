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
                Console.WriteLine($"The attack did {attackPower} damage!");
                energy = (energy - 10);
            }

            else 
            {
                Console.WriteLine("Not enough energy to attack!");
            }
            
        }

        public double TakeDamage(Weapon weapon) 
        {
            hitPoints = (hitPoints - weapon.attackPower);
            Console.WriteLine($"Took {weapon.attackPower} damage!");
            return hitPoints;
        }
    }
}
