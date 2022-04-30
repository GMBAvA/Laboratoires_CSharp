using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_poo
{
    internal class EnteteExamen
    {
        private string titre;
        private List<Question> questions;

        public string Titre
        {
            get => titre;
            set => titre = value;
        }

        public EnteteExamen (string titre, List<Question> questions)
        {
            
        }

        public string ToString()
        {
            return titre + questions;
        }
    }
}
