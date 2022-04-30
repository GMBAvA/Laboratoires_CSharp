using System;
using McFarlaneNamespace;
using MarvelNameSpace;

namespace AmitieNameSpace
{
    class Program
    {
        private static Random random = new Random();
        static void Main(string[] args)
        {
            Spawn spawn = new Spawn(random.Next(0, 11));
            Capitaine captain1 = new Capitaine();
            Capitaine captain2 = new Capitaine();
            spawn.Nom = "Spawn";
            captain1.Nom = "Captain1";
            captain2.Nom = "Captain2";
            Console.WriteLine("Spawn : 'Bonjour Capitaine, como estas ?'");
            Console.WriteLine("Capitaine : 'Super, qu'est ce que tu fait ?'");
            if (spawn.Humeur < 5)
            {
                Console.WriteLine("Spawn est parti et ne reviendra pas...");
            }
            else
            {
                spawn.Ami = captain1.Nom;
                captain1.Ami = spawn.Nom;
                Console.WriteLine("Spawn et Captain1 deviennent ami");
                spawn.Ami = captain2.Nom;
                captain1.Ami = captain2.Nom;
                captain2.Ami = captain1.Nom;
                Console.WriteLine("Ami de spawn : " + spawn.Ami);
                Console.WriteLine("Ami de captain1 : " + captain1.Ami);
                Console.WriteLine("Ami de captain2 : " + captain2.Ami);

                Console.WriteLine("Nom de spawn : " + spawn.Nom);
                Console.WriteLine("Nom de captain1 : " + captain1.Nom);
                Console.WriteLine("Nom de captain2 : " + captain2.Nom);
            }


        }
    }
}
