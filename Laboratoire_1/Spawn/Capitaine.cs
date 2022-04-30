using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelNameSpace
{
    class Capitaine
    {
        private string nom;
        private string ami;
        public string Nom
        {
            get { return nom; }

            set { nom = value; }

        }
        public string Ami
        {
            get => ami;
            set => ami = value;
        }
    }
}
