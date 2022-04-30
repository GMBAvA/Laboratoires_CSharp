using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests_classes_partielles
{
    public partial class Virus
    {
        string nom;
        int tempsIncubationMin;
        string symptome;
        public Virus()
        {
            this.nom = null;
            this.tempsIncubationMin = 5760;
            this.symptome = null;
        }
        public string Nom
        {
            get => nom;
            set => nom = value;
        }
        public int TempsIncubationMinutes
        {
            get => tempsIncubationMin;
            set => tempsIncubationMin = value;
        }
        public string Symptome
        {
            get => symptome;
            set => symptome = value;
        }
    }
}
