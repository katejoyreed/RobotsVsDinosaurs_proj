using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVDinos
{
    class Battlefield
    {   //member variables
        public List<Herd> herd;
        public List<Fleet> fleet;

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

            while (gunter.hitPoints > 0 && velociraptor.hitPoints > 0)
            {
                gunter.RobotUserPrompt(velociraptor);
                
                velociraptor.DinosaurUserPrompt(gunter, velociraptor);
                
            }

            battleFleet.RemoveFromFleet(gunter);
            battleHerd.RemoveFromHerd(velociraptor);

            if (gunter.hitPoints > 0) 
            { 
                while (gunter.hitPoints > 0 && allosaurus.hitPoints > 0) 
                {
                    gunter.RobotUserPrompt(allosaurus);
                    allosaurus.DinosaurUserPrompt(gunter, allosaurus);
                }

                battleFleet.RemoveFromFleet(gunter);
                battleHerd.RemoveFromHerd(allosaurus);
            }

            else 
            {
                while (velociraptor.hitPoints < 0 && ironGiant.hitPoints < 0) 
                {
                    ironGiant.RobotUserPrompt(velociraptor);
                    velociraptor.DinosaurUserPrompt(ironGiant, velociraptor);
                }
                battleFleet.RemoveFromFleet(ironGiant);
                battleHerd.RemoveFromHerd(velociraptor);
            }



            Console.ReadLine();

        }

        
    } 
}
