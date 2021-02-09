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

            Fleet battleFleet = new Fleet();
            Armory armory = new Armory();


            Weapon sword = armory.CreateWeapon("Sword", 25);
            Weapon revolver = armory.CreateWeapon("Revolver", 35);
            Weapon cannon = armory.CreateWeapon("Cannon", 40);
            
            
            armory.PopulateArmory(sword);
            armory.PopulateArmory(revolver);
            armory.PopulateArmory(cannon);

            Weapon weapon1 = armory.ChooseWeapon1();
            Robot gunter = battleFleet.CreateRobot("G.U.N.T.E.R", 120, 100, weapon1);
            battleFleet.PopulateFleet(gunter);

            Weapon weapon2 = armory.ChooseWeapon2();
            Robot ironGiant = battleFleet.CreateRobot("Iron Giant", 100, 100, weapon2);
            battleFleet.PopulateFleet(ironGiant);

            Weapon weapon3 = armory.ChooseWeapon3();
            Robot maschinenmensch = battleFleet.CreateRobot("Maschinenmensch", 110, 100, weapon3);
            battleFleet.PopulateFleet(maschinenmensch);


            
           


           

            
            

            

            while (battleHerd.herd.Contains(velociraptor) && battleFleet.fleet.Contains(gunter)) 
            {
                Dinosaur currentDino = battleHerd.herd[0];
                Robot currentRobot = battleFleet.fleet[0];
                currentDino.DinosaurUserPrompt(currentRobot, currentDino, battleFleet, battleHerd);
                currentRobot.RobotUserPrompt(currentDino, battleHerd, currentRobot, battleFleet);
            }

            
            

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
