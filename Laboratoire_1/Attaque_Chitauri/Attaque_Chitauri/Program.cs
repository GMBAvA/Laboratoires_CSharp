// https://docs.microsoft.com/fr-fr/dotnet/api/system.gc?view=netframework-4.8

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attaque_Chitauri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Note : un seul test à la fois
            Test_1();
            //Test_2();
            Console.WriteLine("TOTAL CHITAURIS : " + Chitauri.quantite);
            Console.ReadKey();

        }

        private static void Test_1()
        {
            Chitauri.log = true;

            while (Chitauri.numeroCourant < 10000)
                new Chitauri();

        }


        private static void Test_2()
        {
            Chitauri.log = false;
            int maxGen = GC.MaxGeneration;
            Console.WriteLine("1 > AVANT L'EXÉCUTION");
            Console.WriteLine("  La generation MAX du GC est {0}", maxGen);
            Console.WriteLine("  Memoire totale : {0}", GC.GetTotalMemory(false));
            for (int g = 0; g <= maxGen; g++)
                Console.WriteLine("  Generation {0} : {1}", g, GC.CollectionCount(g));
            GC.Collect(0);

            while (Chitauri.numeroCourant < 100000)
                new Chitauri();

            Console.WriteLine("2 > APRES LA BOUCLE");
            Console.WriteLine("  Memoire totale : {0}", GC.GetTotalMemory(false));
            for (int g = 0; g <= maxGen; g++)
                Console.WriteLine("  Generation {0} : {1}", g, GC.CollectionCount(g));
            GC.Collect(0);

            Console.WriteLine("3 > APRES GC de la generation 0");
            Console.WriteLine("  Memoire totale : {0}", GC.GetTotalMemory(false));
            for (int g = 0; g <= maxGen; g++)
                Console.WriteLine("  Generation {0} : {1}", g, GC.CollectionCount(g));
            GC.Collect(maxGen);

            Console.WriteLine("3 > APRES GC de la generation MAX");
            Console.WriteLine("  Memoire totale : {0}", GC.GetTotalMemory(false));
            for (int g = 0; g <= maxGen; g++)
                Console.WriteLine("  Generation {0} : {1}", g, GC.CollectionCount(g));

        }
    }
}