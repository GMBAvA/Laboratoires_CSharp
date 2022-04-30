using entreprise;
using comptabilite;
using facture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facture
{
    public class Facture
    {
        private DateTime dateFacturation;
        private string entreprise;
        private List<Produit> produits;
        public Facture(string entreprise, DateTime dateFacturation)
        {
            this.entreprise = entreprise;
            this.dateFacturation = dateFacturation;
            produits = new List<Produit>();
        }

        public void AjouterProduit(Produit produit)
        {
            produits.Add(produit);
        }

        public int CalculerMontant()
        {
            int res = 0;
            foreach (Produit produit in produits)
            {
                res += produit.Montant;
            }
            return res;
        }

        public override string ToString()
        {
            string txt = "";
            int add = 0;
            txt += dateFacturation.ToShortDateString() + " - " + entreprise.ToLower();
            foreach (Produit produit in produits)
            {
                txt += produit.ToString() + "\n";
            }
            txt += "> " + produits.Count() + " produits/Total ";

            foreach (Produit produit in produits)
            {
                add += produit.Montant;
            }
            txt += add;

            return txt;
        }

        public DateTime DateFacturation
        {
            get => dateFacturation;
        }

        public string Entreprise
        {
            get => entreprise;
        }

        public List<Produit> Produits
        {
            get => produits;
        }

    }
}
