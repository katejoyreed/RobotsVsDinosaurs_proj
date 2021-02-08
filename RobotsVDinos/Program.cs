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
            Robot robot3 = battlefield.CreateRobot("Maschinenmensch", 100, 100, revolver);

            battlefield.PopulateFleet(robot1);
            battlefield.PopulateFleet(robot2);
            battlefield.PopulateFleet(robot3);

            Dinosaur dinosaur1 = new Dinosaur("Velociraptor", 90, 100, 20);
            Dinosaur dinosaur2 = new Dinosaur("Carnotaurus", 100, 100, 25);
            Dinosaur dinosaur3 = new Dinosaur("Allosaurus", 95, 100, 35);

            battlefield.PopulateHerd(dinosaur1);
            battlefield.PopulateHerd(dinosaur2);
            battlefield.PopulateHerd(dinosaur3);

            dinosaur1.Attack();
            robot1.TakeDamage(dinosaur1);
            robot1.Attack(robot1.weapon);
            dinosaur1.TakeDamage(robot1.weapon);
            dinosaur1.Attack();
            robot1.TakeDamage(dinosaur1);
            robot1.Attack(robot1.weapon);
            dinosaur1.TakeDamage(robot1.weapon);
            dinosaur1.Attack();
            robot1.TakeDamage(dinosaur1);
            robot1.Attack(robot1.weapon);
            dinosaur1.TakeDamage(robot1.weapon);




        }
    }
}
