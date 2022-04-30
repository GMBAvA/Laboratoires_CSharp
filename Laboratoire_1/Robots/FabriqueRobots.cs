using System;
using combat;

namespace robot
{
    class FabriqueRobots
    {

        public static Robot Create(string nom = "Robot d'entrainement", int typeR = 2)
        {

            Robot robot = new Robot(nom, typeR);
            switch (typeR)
            {
                case 1:
                    robot.Attaque = new AttaqueLegere();
                    robot.Protection = new ProtectionLegere();
                    robot.Vitesse = new VitesseLegere();
                    Console.WriteLine(robot);
                    break;
                case 2:
                    robot.Attaque = new AttaqueMoyenne();
                    robot.Protection = new ProtectionMoyenne();
                    robot.Vitesse = new VitesseMoyenne();
                    Console.WriteLine(robot.Infos); //en essayant de cibler un robot;
                    break;
                case 3:
                    robot.Attaque = new AttaqueLourde();
                    robot.Protection = new ProtectionLourde();
                    robot.Vitesse = new VitesseLourde();
                    Console.WriteLine(robot);
                    break;
            }
            return robot;
        }
    }
}
