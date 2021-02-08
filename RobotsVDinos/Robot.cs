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

        public void Attack(double powerLevel, Weapon weapon) 
        {
        
        }

        public void GetAttacked(double hitPoints) 
        {
            
        }
    }
}
