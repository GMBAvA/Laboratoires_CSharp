using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_poo
{
    class Resultat
    {
        private DateTime moment;
        private EnteteExamen enteteExamen;
        private List<Reponse> reponses;

        public Resultat (EnteteExamen enteteExamen, List<Reponse> reponses)
        {

        }

        public string GetBilan()
        {
            string txt = "";
            return txt;
        }
    }
}
