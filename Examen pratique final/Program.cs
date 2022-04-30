using facture;
using entreprise;
using comptabilite;
using System;

namespace Examen_pratique_final
{
    class Program
    {
        static void Main(string[] args)
        {

            // #1
            Entreprise entreprise = new Entreprise();
            Console.WriteLine("Liste des factures");
            foreach(Facture facture in entreprise.GetFactures())
            {
                facture.ToString();
            }
            entreprise.GetFactures().ToString();


            // #2
            Comptabilite comptabilite = new Comptabilite();
            foreach (Facture facture in entreprise.GetFactures())
            {
                try
                {
                    comptabilite.TraiterFacture(facture);
                }
                catch (ComptabiliteException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
                entreprise.GetFactures().ToString();

            

            // #3
            Console.WriteLine(entreprise);
            Console.WriteLine(comptabilite.Etat);
            Console.WriteLine("La balance est de " + comptabilite.ValiderEtatFinancier(entreprise) + "$");
            Console.WriteLine("Etat financier valide : " + comptabilite.ValiderEtatFinancier(entreprise, 50));

        }
    }
}
