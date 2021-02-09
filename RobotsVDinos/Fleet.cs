﻿using System;
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
            }
        }


    }







}
