﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVDinos
{
    class Herd
    {//member variables
        public List<Dinosaur> herd;
        

        //ctor
        public Herd()
        {
            herd = new List<Dinosaur>();
            
        }


        //member methods

        public Dinosaur CreateDinosaur(string type, double hitPoints, double energy, double attackPower)
        {
            Dinosaur dinosaur = new Dinosaur(type, hitPoints, energy, attackPower);
            return dinosaur;
        }

        public void PopulateHerd(Dinosaur dinosaur)
        {
            herd.Add(dinosaur);
        }

        public void RemoveFromHerd(Dinosaur dinosaur) 
        {
            if (dinosaur.hitPoints <= 0)
            {
                herd.Remove(dinosaur);
                Console.WriteLine($"{dinosaur.type} has been removed from battle!");
                if (herd.Count == 0) 
                {
                    Console.WriteLine("Robots win!");
                }
                
                

                
            }
        }

        public void RunHerd() 
        {
            Dinosaur dino1 = CreateDinosaur("Velociraptor", 100, 100, 25);
            Dinosaur dino2 = CreateDinosaur("Allosaurus", 120, 100, 35);
            Dinosaur dino3 = CreateDinosaur("Carnotaurus", 140, 100, 40);

            PopulateHerd(dino1);
            PopulateHerd(dino2);
            PopulateHerd(dino3);
        }
    }
}
