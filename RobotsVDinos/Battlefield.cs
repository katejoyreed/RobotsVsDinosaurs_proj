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
            Dinosaur velociraptor = battleHerd.CreateDinosaur("Velociraptor", 100, 100, 20);
            Dinosaur allosaurus = battleHerd.CreateDinosaur("Allosaurus", 110, 100, 25);
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

            Dinosaur currentDino = battleHerd.herd[0];
            Robot currentRobot = battleFleet.fleet[0];

            while (currentDino.hitPoints > 0 && currentRobot.hitPoints > 0) 
            {
                currentDino.DinosaurUserPrompt(currentRobot, currentDino, battleFleet);
                currentRobot.RobotUserPrompt(currentDino, battleHerd);
            }

            if (currentDino.hitPoints > 0)
            {
                Console.WriteLine($"{currentDino} wins this round!");
            }
            else 
            {
                Console.WriteLine($"{currentRobot} wins this round!");
            }

            while (currentDino.hitPoints > 0 && currentRobot.hitPoints > 0)
            {
                currentDino.DinosaurUserPrompt(currentRobot, currentDino, battleFleet);
                currentRobot.RobotUserPrompt(currentDino, battleHerd);
            }
            

            Console.ReadLine();

        }

        
    } 
}
