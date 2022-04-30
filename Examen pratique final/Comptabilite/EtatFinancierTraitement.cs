using facture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comptabilite
{
    public partial class EtatFinancier
    {
        private List<Facture> factures;

        public EtatFinancier()
        {
            factures = new List<Facture>();
        }

        public void AjouterFacture(Facture facture)
        {
            factures.Add(facture);
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
    }

}
