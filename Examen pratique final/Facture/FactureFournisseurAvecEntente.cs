using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facture
{
    public class FactureFournisseurAvecEntente : FactureFournisseur
    {
        private string entreprise;
        private DateTime dateFacturation;
        private string fournisseur;
        private bool entente;
        public FactureFournisseurAvecEntente(string entreprise, DateTime dateFacturation, string fournisseur) : base (entreprise, dateFacturation, fournisseur, entente:true)
        {
            this.entreprise = entreprise;
            this.dateFacturation = dateFacturation;
            this.fournisseur = fournisseur;
            entente = true;
        }
    }
}
