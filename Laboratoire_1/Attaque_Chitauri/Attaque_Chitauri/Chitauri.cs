using System;

namespace Attaque_Chitauri
{
    class Chitauri
    {
        public static int quantite = 0;
        public static int numeroCourant = 0;
        public static bool log = false;


        public Chitauri() {
            numeroCourant++;
            if (log)
                Console.WriteLine("C : " + numeroCourant);
            for (int x = 0; x < 10; x++)
                new Object();
            quantite++;
        }

        ~Chitauri() 
        {
            numeroCourant--;
            if (log)
                Console.WriteLine("D : " + numeroCourant);
        }
    }
}

