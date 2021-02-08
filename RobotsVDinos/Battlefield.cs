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
            Dinosaur allosaur = battleHerd.CreateDinosaur("Allosaur", 110, 100, 25);
            Dinosaur carnotaurus = battleHerd.CreateDinosaur("Carnotaurus", 120, 100, 35);
            battleHerd.PopulateHerd(velociraptor);
            battleHerd.PopulateHerd(allosaur);
            battleHerd.PopulateHerd(carnotaurus);

            Weapon sword = new Weapon("sword", 15);
            Weapon slingshot = new Weapon("slingshot", 10);
            Weapon revolver = new Weapon("revolver", 30);

            Fleet battleFleet = new Fleet();
            Robot gunter = battleFleet.CreateRobot("G.U.N.T.E.R", 120, 100, sword);
            Robot ironGiant = battleFleet.CreateRobot("Iron Giant", 140, 100, slingshot);
            Robot maschinenmensch = battleFleet.CreateRobot("Maschinenmensch", 140, 100, revolver);
            battleFleet.PopulateFleet(gunter);
            battleFleet.PopulateFleet(ironGiant);
            battleFleet.PopulateFleet(maschinenmensch);


        }

        
    } 
}
