using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuissanceInterface
{
    internal class Aide
    {
        private Hashtable commandes;
        private string id;
        private string description;
        private const int ESPACEMENT = 20;

        public Aide(string nomCommande, string descriptionCommande)
        {
            commandes = new Hashtable();
            id = nomCommande;
            description = descriptionCommande;
        }

        public string Id
        {
            get => id;
        }

        public string Description
        {
            get => description;
        }

        public void Ajouter(string commande, string description)
        {
            commandes.Add(commande.ToLower(), description);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(id).AppendLine();
            foreach (string k in commandes.Keys)
                sb.Append($"   {k.Substring(0, Math.Min(k.Length, ESPACEMENT)),-ESPACEMENT} -> {((string)commandes[k])}").AppendLine();
            
            return sb.ToString();
        }
    }
}
