using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuissanceInterface
{
    internal class Fichier
    {
        private string nom;
        private string contenu;
        private bool cache;

        public Fichier(string nom, string contenu, bool cache = false)
        {
            this.nom = nom;
            this.contenu = contenu;
            this.cache = cache;
        }

        public string Nom            
        {
            get => nom;
        }

        public int Taille
        {
            get => contenu.Length;
        }

        public string Contenu
        {
            get => contenu;
        }

        public bool Cache
        {
            get => cache;
            set => cache = value;
        }

        public string GetInfo()
        {
            if (cache)
                return Nom + " * " + " {" + Contenu + "}";
            return Nom + " {" + Contenu + "}";
        }
    }
}