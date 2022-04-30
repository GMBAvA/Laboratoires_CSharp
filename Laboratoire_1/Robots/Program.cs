using robot;
using System;
using combat;

namespace combat
{
    class Program
    {
        /*
        Emplacement du protected : 
        Methode avec param par defaut : FabriqueRobot.Create();
        Emplacement de l’appel : 
        Appel de parametres nommes :  this.ligne32;
        */
        static void Main(string[] args)
        {
            Arene arene = new Arene();
            FabriqueRobots fabrique = new FabriqueRobots();

            string tour = "premier";
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Entrez le nom de votre " + tour + " robot :");
                string nomUser = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Quel type de robot souhaitez-vous créer ?");
                Console.WriteLine("1 - Vif");
                Console.WriteLine("2 - Equilibré");
                Console.WriteLine("3 - Lourd");
                int nbUserChoix = Convert.ToInt32(Console.ReadLine());
                FabriqueRobots.Create(typeR: nbUserChoix, nom: nomUser);
                Console.WriteLine();
                tour = "deuxième";
            }
            Console.WriteLine("Robots créés avec succès, place au combat.");
            Arene.Combat();

        }
    }
}
