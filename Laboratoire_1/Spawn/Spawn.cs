using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McFarlaneNamespace
{
    class Spawn
    {
        private string nom;
        private int humeur;
        private string ami;
        private bool amiPourLaVie = false;

        public Spawn(int _humeur)
        {
            Humeur = _humeur;
        }


        public string Nom
        {
            get => nom;
            set => nom = value;
        }
        public int Humeur
        {
            get { return humeur; }
            set => humeur = value;
        }
        public string Ami
        {
            get => ami;
            set
            {
                if (amiPourLaVie == false)
                {
                    if (Humeur < 5)
                    {
                        ami = null;
                    }
                    else if (Humeur >= 5)
                    {
                        ami = value;
                        amiPourLaVie = true;
                    }
                }
                else
                    Console.WriteLine("Impossible d'avoir un nouveau meilleur ami");
            }
        }
        
    }
}
