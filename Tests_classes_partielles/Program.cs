using System;

namespace Tests_classes_partielles
{
    class Program
    {
        static void Main(string[] args)
        {
            Virus virus1 = new Virus();
            virus1.Nom = "Peste Noire";
            virus1.Symptome = "Tête qui tourne";
            virus1.TempsIncubationMinutes = 4320;

            Virus virus2 = new Virus();
            virus2.Nom = "Dengue";
            virus2.Symptome = "Hémorragies";
            virus2.TempsIncubationMinutes = 11520;

            Console.WriteLine(virus1.AfficherInfo());
            Console.WriteLine(virus1.ValiderFinQuarantaine(1));
            Console.WriteLine(virus1.ValiderSymptome());

            Console.WriteLine(virus2.AfficherInfo());
            Console.WriteLine(virus2.ValiderFinQuarantaine(9));
            Console.WriteLine(virus2.ValiderSymptome());
        }
    }
}
