using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests_classes_partielles
{
    public partial class Virus
    {
        public string AfficherInfo()
        {
            return ("Le virus : " + nom + " provoque " + symptome + " et a une durée d'incubation de : " + tempsIncubationMin);
        }

        public string ValiderSymptome()
        {
            string reponse;
            if (symptome == "Toux" || symptome == "Vomissement" || symptome == "Tête qui tourne")
            {
                reponse = "Vous êtes possiblement malade de la " + nom + ". Veuillez consulter un médecin.";
            }
            else
            {
                reponse = "Vous n'êtes certainement pas malade de la " + nom + ". Restez zen !";
            }
            return reponse;
        }

        public string ValiderFinQuarantaine(int nbJours) //ne marche mais je dois avancer
        {
            string reponse;
            nbJours = nbJours * 1440;
            if (nbJours > 2)
            {
                reponse = "Vous n'êtes plus contagieux. Sortez vivre.";
            }
            else
            {
                reponse = "Vous êtes toujours contagieux et vous devez vous enfermer dans votre maison à tout jamais.";
            }
            return reponse;
        }
    }
}
