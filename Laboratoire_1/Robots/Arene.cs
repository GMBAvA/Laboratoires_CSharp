using System;
using robot;
using combat;
using System.Collections.Generic;

namespace combat
{
    class Arene
    {
        public Robot robot1;
        public Robot robot2;

        public Arene()
        {
            
            robot1 = null;
            robot2 = null;
        }

        public void FaireEntrerBots(ref Robot robot1, ref Robot robot2)
        {
            this.robot1 = robot1;
            this.robot2 = robot2;
        }

        public static void Combat()
        {
            Console.WriteLine("Lancement du combat...");
        }
    }
}
