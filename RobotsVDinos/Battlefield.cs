using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVDinos
{
    class Battlefield
    {   //member variables
       

        public Battlefield()
        {
            
        }

        public void RunBattlefield()
        {
            Herd battleHerd = new Herd();
            Dinosaur velociraptor = battleHerd.CreateDinosaur("Velociraptor", 100, 100, 30);
            Dinosaur allosaurus = battleHerd.CreateDinosaur("Allosaurus", 110, 100, 35);
            Dinosaur carnotaurus = battleHerd.CreateDinosaur("Carnotaurus", 120, 100, 35);
            battleHerd.PopulateHerd(velociraptor);
            battleHerd.PopulateHerd(allosaurus);
            battleHerd.PopulateHerd(carnotaurus);


            Weapon sword = new Weapon("sword", 25);
            Weapon slingshot = new Weapon("slingshot", 20);
            Weapon revolver = new Weapon("revolver", 30);

            Fleet battleFleet = new Fleet();
            Robot gunter = battleFleet.CreateRobot("G.U.N.T.E.R", 120, 100, sword);
            Robot ironGiant = battleFleet.CreateRobot("Iron Giant", 140, 100, slingshot);
            Robot maschinenmensch = battleFleet.CreateRobot("Maschinenmensch", 140, 100, revolver);
            battleFleet.PopulateFleet(gunter);
            battleFleet.PopulateFleet(ironGiant);
            battleFleet.PopulateFleet(maschinenmensch);

            

            while (battleHerd.herd.Contains(velociraptor) && battleFleet.fleet.Contains(gunter)) 
            {
                Dinosaur currentDino = battleHerd.herd[0];
                Robot currentRobot = battleFleet.fleet[0];
                currentDino.DinosaurUserPrompt(currentRobot, currentDino, battleFleet, battleHerd);
                currentRobot.RobotUserPrompt(currentDino, battleHerd, currentRobot, battleFleet);
            }

            //the problem is that the loop is contuing one round beyond the objects being knocked out
            

            while (battleHerd.herd.Contains(allosaurus) && battleFleet.fleet.Contains(ironGiant))
            {
                Dinosaur currentDino = battleHerd.herd[0];
                Robot currentRobot = battleFleet.fleet[0];
                currentDino.DinosaurUserPrompt(currentRobot, currentDino, battleFleet, battleHerd);
                currentRobot.RobotUserPrompt(currentDino, battleHerd, currentRobot, battleFleet);
            }


            while (battleHerd.herd.Contains(carnotaurus) && battleFleet.fleet.Contains(maschinenmensch))
            {
                Dinosaur currentDino = battleHerd.herd[0];
                Robot currentRobot = battleFleet.fleet[0];
                currentDino.DinosaurUserPrompt(currentRobot, currentDino, battleFleet, battleHerd);
                currentRobot.RobotUserPrompt(currentDino, battleHerd, currentRobot, battleFleet);

            }
            
            if (battleHerd.herd.Contains(carnotaurus)) 
            {
                Console.WriteLine("Dinosaurs win!");
            }

            else 
            {
                Console.WriteLine("Robots win!");
            }
            


        }

        
    } 
}
