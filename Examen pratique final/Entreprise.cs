using facture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entreprise
{
    public class Entreprise
    {
        private List<Facture> factures;
        private static Random random = new Random();
        private String[] nomEntreprise = { "DICJ", "ABC", "CGU", "MSP", "XYZ" };
        private String[] nomProduit = { "PROD01", "PROD17", "PROD_1", "000000", "EXTERN" };
        private String[] descriptionProduit = { "Caisse de fruits", "Processeurs ULTRON", "Muffins (unité)", "MOTEUR", "INCONNU" };
        private String[] nomFournisseur = { "EXPORT X", "F1", "Amozun", "Quebex", "INTERNE" };

        public Entreprise()
        {
            GenererFactures(20);
        }

        public List<Facture> GetFactures()
        {
            return factures;
        }

        public int CalculerTotalFactures()
        {
            int res = 0;
            foreach (Facture facture in factures)
            {
                res += facture.CalculerMontant();
            }
            return res;
        }

        private void GenererFactures(int nombreFacture)
        {
            factures = new List<Facture>();
            for (int x = 0; x < nombreFacture; x++)
                factures.Add(GenererFactureAleatoire());
        }

        private Facture GenererFactureAleatoire()
        {
            Facture facture = null;
            switch (random.Next(1, 3))
            {
                case 1: 
                    facture = new Facture(nomEntreprise[random.Next(0, nomEntreprise.Length)], GetDateAleatoire());
                    break;
                case 2:
                    facture = new FactureFournisseur(nomEntreprise[random.Next(0, nomEntreprise.Length)], GetDateAleatoire(), nomFournisseur[random.Next(0, nomFournisseur.Length)]);
                    break;
                case 3:
                    facture = new FactureFournisseurAvecEntente(nomEntreprise[random.Next(0, nomEntreprise.Length)], GetDateAleatoire(), nomFournisseur[random.Next(0, nomFournisseur.Length)]);
                    break;
            }

            for (int x = 0; x < random.Next(0, 10); x++)
            {
                int idProduit = random.Next(0, nomProduit.Length);
                facture.AjouterProduit(new Produit(nomProduit[idProduit], descriptionProduit[idProduit], random.Next(0, 10)));
            }
            return facture;
        }

        private DateTime GetDateAleatoire()
        {
            return new DateTime(2020, random.Next(1, 12), random.Next(1, 28));
        }

        public override string ToString()
        {
            string info = "ENTREPRISE \n";
            info += " - Nombre de factures " + factures.Count + "\n";
            info += " - Total " + CalculerTotalFactures() + "\n";
            return info;
        }
    }
}
