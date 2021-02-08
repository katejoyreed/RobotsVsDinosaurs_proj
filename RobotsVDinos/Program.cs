using System;

namespace RobotsVDinos
{
    class Program
    {
        static void Main(string[] args)
        {
            Battlefield battlefield = new Battlefield();

            Weapon sword = new Weapon("sword", 15);
            Weapon slingshot = new Weapon("slingshot", 10);
            Weapon revolver = new Weapon("revolver", 25);

            Robot robot1 = battlefield.CreateRobot("G.U.N.T.E.R", 120, 100, sword);
            Robot robot2 = battlefield.CreateRobot("Iron Giant", 120, 100, slingshot);
            Robot robot3 = battlefield.CreateRobot("Maschinenmensch", 90, 100, revolver);

            battlefield.PopulateFleet(robot1);
            battlefield.PopulateFleet(robot2);
            battlefield.PopulateFleet(robot3);
            
            
            


        }
    }
}
