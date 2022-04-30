using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_poo
{
    internal class Profil
    {
        private string nom;
        private List<Resultat> resultats;

        public Profil(string nom)
        {
            if (nom == null)
            {
                throw new JPAException("Nom invalide ou non selectionné");
            }
            else 
               
            this.nom = nom;
            // ???????????
            resultats = new List<Resultat>;
        }

        public string GetNom()
        {
            string txt = "";
            return txt;
        }

        public List<Resultat> GetResultats()
        {
            return resultats;
        }

        public void AjouterResultat(Resultat resultat)
        {
            resultats.Add(resultat);
        }
    }
}
