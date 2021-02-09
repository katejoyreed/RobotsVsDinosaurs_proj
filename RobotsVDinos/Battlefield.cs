using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVDinos
{
    class Battlefield
    {   
       

        public Battlefield()
        {
            
        }

        public void RunBattlefield()
        {
            
            Herd battleHerd = new Herd();
            battleHerd.RunHerd();
            Fleet battleFleet = new Fleet();
            battleFleet.RunFleet();

            Dinosaur currentDino = battleHerd.herd[0];
            Robot currentRobot = battleFleet.fleet[0];

            while (currentDino.hitPoints > 0 && currentRobot.hitPoints > 0)
           
            {
                
                
                currentDino.DinosaurUserPrompt(currentRobot, currentDino, battleFleet, battleHerd);
                currentRobot.RobotUserPrompt(currentDino, battleHerd, currentRobot, battleFleet);
            }

            Dinosaur nextDino = battleHerd.herd[0];
            Robot nextRobot = battleFleet.fleet[0];

            while (nextDino.hitPoints > 0 && nextRobot.hitPoints > 0)
            
            {
                
                nextDino.DinosaurUserPrompt(nextRobot, nextDino, battleFleet, battleHerd);
                nextRobot.RobotUserPrompt(nextDino, battleHerd, nextRobot, battleFleet);
            }

            Dinosaur thirdDino = battleHerd.herd[0];
            Robot thirdRobot = battleFleet.fleet[0];

            while (thirdDino.hitPoints > 0 && thirdRobot.hitPoints > 0)
           
            {
                
                thirdDino.DinosaurUserPrompt(thirdRobot, thirdDino, battleFleet, battleHerd);
                thirdRobot.RobotUserPrompt(thirdDino, battleHerd, thirdRobot, battleFleet);

            }
            
            
            


        }

        
    } 
}
