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
        public override string ToString()
        {
            string info = "ETAT FINANCIER \n";
            info += " - Nombre de factures " + factures.Count + "\n";
            info += " - Total " + CalculerTotalFactures() + "\n";
            return info;
        }
    }
}
