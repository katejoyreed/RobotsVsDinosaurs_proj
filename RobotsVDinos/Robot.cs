using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVDinos
{
    class Robot
    {
        //member variables
        string robotName;
        double hitPoints;
        double powerLevel;
        Weapon weapon;
        double attackPower;

        //ctor
        public Robot(string robotName, double hitPoints, double powerLevel, Weapon weapon, double attackPower)
        {
            this.robotName = robotName;
            this.hitPoints = hitPoints;
            this.powerLevel = powerLevel;
            this.weapon = weapon;
            this.attackPower = attackPower;

        }


        //member methods
    }
}
