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

            
            


            while (battleHerd.herd.Count > 0 && battleFleet.fleet.Count > 0)
            {
                battleHerd.herd[0].DinosaurUserPrompt(battleFleet.fleet[0], battleHerd.herd[0], battleFleet, battleHerd);
                
                battleFleet.fleet[0].RobotUserPrompt(battleHerd.herd[0], battleHerd, battleFleet.fleet[0], battleFleet);
            }

            
            

           


        }

        }


}
