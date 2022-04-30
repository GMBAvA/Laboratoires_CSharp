using System;
using System.Drawing;
using Colorful;
using Humanizer;
using Console = Colorful.Console;

namespace Nougat__nuget_
{
    class Program
    {
        static void TestHumain()
        {
            System.Console.WriteLine("Un texte tronqué à 9 caractères (.Truncate(10)) :");
            System.Console.WriteLine("Un long texte à tronquer".Truncate(10) + "\n");

            System.Console.WriteLine("Du string transformé en miniscule sauf en début de phrase :");
            System.Console.WriteLine("HUMANIZER".Transform(To.LowerCase, To.TitleCase) + "\n");

            System.Console.WriteLine("Une date + 48 heures humanisée :");
            System.Console.WriteLine(DateTimeOffset.UtcNow.AddHours(48).Humanize() + "\n");

            System.Console.WriteLine("Des millisecondes humanisé à 2 valeurs, séparés pas un / : ");
            System.Console.WriteLine(TimeSpan.FromMilliseconds(1299630020).Humanize(2, collectionSeparator: " / ") + "\n");

            System.Console.WriteLine("Nombre humanisé (80) en français :");
            System.Console.WriteLine(80.ToWords() + "\n");
        }
        static void TestConsole()
        {
            Console.WriteLine("La vie en rose", Color.Pink);

            string dream = "a dream of {0} and {1} and {2} and {3} and {4} and {5} and {6} and {7} and {8} and {9}...";
            string[] fruits = new string[]
            {
                "bananas",
                "strawberries",
                "mangoes",
                "pineapples",
                "cherries",
                "oranges",
                "apples",
                "peaches",
                "plums",
                "melons"
            };

            Console.WriteLineFormatted(dream, Color.LightGoldenrodYellow, Color.Gray, fruits);

            ColorAlternatorFactory alternatorFactory = new ColorAlternatorFactory();
            ColorAlternator alternator = alternatorFactory.GetAlternator(1, Color.Blue, Color.White, Color.Red);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLineAlternating("FRA", alternator);
            }
            ColorAlternatorFactory alternateurCA = new ColorAlternatorFactory();
            ColorAlternator alternateur = alternateurCA.GetAlternator(1, Color.White, Color.Red);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLineAlternating("CA", alternateur);
            }

            Console.WriteAscii("EXTREME");
            Console.WriteAscii("J'adore les nuggets");
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Les test Humanizer : ");
            TestHumain();
            System.Console.WriteLine("Les test Colorful.Console : ");
            TestConsole();
        }
    }
}
