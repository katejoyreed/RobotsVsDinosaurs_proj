using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVDinos
{
    class Dinosaur
    {//member variables
        string type;
        double hitPoints;
        double energy;
        double attackPower;

        //ctor
        public Dinosaur(string type, double hitPoints, double energy, double attackPower)
        {
            this.type = type;
            this.hitPoints = hitPoints;
            this.energy = energy;
            this.attackPower = attackPower;
        }

        //member methods
    }
}
