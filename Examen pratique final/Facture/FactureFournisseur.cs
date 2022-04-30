using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facture
{
    public class FactureFournisseur : Facture
    {
        private string entreprise;
        private DateTime dateFacturation;
        private string fournisseur;
        private bool entente;
        public FactureFournisseur(string entreprise, DateTime dateFacturation, string fournisseur, bool entente = false) : base (entreprise, dateFacturation)
        {
            this.entreprise = entreprise;
            this.dateFacturation = dateFacturation;
            this.fournisseur = fournisseur;
            this.entente = entente;
        }

        public string Fournisseur
        {
            get => fournisseur;
        }

        public bool Entente
        {
            get => entente;
        }
    }
}
