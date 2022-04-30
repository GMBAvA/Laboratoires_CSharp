using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_poo
{
    internal class Question
    {
        private int id;
        private int ponderation;
        private string enonce;
        private string[] choix;
        private int reponse;

        public Question(int id, int ponderation, string enonce, string[] choix, int reponse)
        {
            this.id = id;
            this.ponderation = ponderation;
            this.enonce = enonce;
            this.choix = choix;
            this.reponse = reponse;

            if (reponse < 0)
            {
                throw new JPAException("Choix de réponse incorrect");
            }
            else if (reponse > id.CompareTo(choix))
            {
                throw new JPAException("Choix impossible");
            }
        }    

        public Question (int id, string enonce, string[] choix, int reponse)
        {
            this.ponderation = 1;
        }

        protected Question (int id, int ponderation, string enonce, int reponse)
        {
            this.id = id;
            this.enonce = enonce;
            this.ponderation = ponderation;
            this.reponse = reponse;
            choix = new string[0];
        }

        public int VerifierChoix(int choix)
        {
            if (choix == Reponse)
            {
                return Ponderation;
            }
            else
                return 0;
        }

        public int Reponse
        {
            get => reponse;
        }

        public int Ponderation
        {
            get => ponderation;
        }

        public string Enonce
        {
            get => enonce;
        }

        public string[] Choix
        {
            get => choix;
        }

        public int Id
        {
            get => id;
        }

    }
}
