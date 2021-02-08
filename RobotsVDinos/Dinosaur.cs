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

        public void Attack(double energy, double attackPower) 
        {
            
            
        }

        public void GetAttacked(double hitPoints) 
        {
            
        }
    }
}
