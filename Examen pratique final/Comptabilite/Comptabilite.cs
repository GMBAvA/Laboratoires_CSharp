using entreprise;
using facture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comptabilite
{
    class Comptabilite
    {
        private EtatFinancier etat;
        public Comptabilite()
        {
            etat = new EtatFinancier();
        }

        public void TraiterFacture(Facture facture)
        {
            if (facture.Produits.Count() == 0)
            {
                throw new ComptabiliteException("Aucun produit", facture);
            }

            if (facture is FactureFournisseur)
            {
                if (((FactureFournisseur)facture).Entente != true)
                {
                    foreach(Produit produit in facture.Produits)
                    {
                        if (produit.Montant == 0)
                        {
                            throw new ComptabiliteException("Produit à 0", facture);
                            
                        }
                    }
                }
            }
            etat.AjouterFacture(facture);
        }

        public int ValiderEtatFinancier(Entreprise entreprise)
        {
            int res = 0;
            foreach (Facture facture in entreprise.GetFactures())
            {
                res += facture.CalculerMontant() - etat.CalculerTotalFactures();
            }  
            return res;
        }

        public bool ValiderEtatFinancier(Entreprise entreprise, int tolerance)
        {
            if (Math.Abs(ValiderEtatFinancier(entreprise)) < tolerance)
            {
                return true;
            }
            else
                return false;
        }

        public EtatFinancier Etat
        {
            get => etat;
        }
    }
}
