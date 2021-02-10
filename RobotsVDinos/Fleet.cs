using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVDinos
{
    class Fleet
    {//member variables
       public List<Robot> fleet;
        

        //ctor
        public Fleet()
        {
            fleet = new List<Robot>();
            
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

        public void RemoveFromFleet(Robot robot) 
        {
            if (robot.hitPoints <= 0) 
            {
                fleet.Remove(robot);
                Console.WriteLine($"{robot.robotName} has been removed from battle!");
                if (fleet.Count == 0)
                {
                    Console.WriteLine("Dinosaurs win!");
                }
            }
        }

        public void RunFleet()
        {
            Armory armory = new Armory();
            armory.RunArmory();
            Weapon weapon1 = armory.ChooseWeapon();
            Robot robot1 = CreateRobot("G.U.N.T.E.R", 120, 100, weapon1);
            PopulateFleet(robot1);
            Weapon weapon2 = armory.ChooseWeapon();
            Robot robot2 = CreateRobot("Iron Giant", 140, 100, weapon2);
            PopulateFleet(robot2);
            Weapon weapon3 = armory.ChooseWeapon();
            Robot robot3 = CreateRobot("Maschinenmensch", 160, 100, weapon3);
            PopulateFleet(robot3);
        }
    }







}
