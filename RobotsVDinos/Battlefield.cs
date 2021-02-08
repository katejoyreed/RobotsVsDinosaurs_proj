using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVDinos
{
    class Battlefield
    {   //member variables
       public List<Robot> fleet;
       public List<Dinosaur> herd;

        //ctor
        public Battlefield()
        {
            fleet = new List<Robot>();
            herd = new List<Dinosaur>();
        }


        //member methods

        public Robot CreateRobot(string robotName, double hitPoints, double powerLevel, Weapon weapon) 
        {
            Robot robot = new Robot(robotName, hitPoints, powerLevel, weapon);
            return robot;
        }


        public void PopulateFleet(Robot robot)
        {
            fleet.Add(robot);
        }

        public Dinosaur CreateDinosaur(string type, double hitPoints, double energy, double attackPower) 
        {
            Dinosaur dinosaur = new Dinosaur(type, hitPoints, energy, attackPower);
            return dinosaur;
        }

        public void PopulateHerd(Dinosaur dinosaur) 
        {
            herd.Add(dinosaur);
        }
    } 
}
