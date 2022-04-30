using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facture
{
    public class Produit
    {
        private string nom;
        private string description;
        private int montant;


        public Produit(string nom, string description, int montant)
        {
            this.nom = nom;
            this.description = description;
            this.montant = montant;
        }


        public string Nom
        {
            get => nom;
        }
        public string Description
        {
            get => description;
        }
        public int Montant
        {
            get => montant;
        }

        public override string ToString()
        {
            return nom + "(" + description + ") - " + montant;
        }
    }
}
