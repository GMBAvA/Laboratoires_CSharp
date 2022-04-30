using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exam_poo;

namespace exam_poo
{
    internal class Reponse
    {
        private Question question;
        private int choix;

        public Reponse(Question question, int choix)
        {
            this.question = question;
            this.choix = choix;
        }

        public int GetResultat()
        {
            int res = 0;

            return res;
        }

        public int GetQuestionPonderation()
        {
            int res = 0;
            return res;
        }

        public int GetQuestionId()
        {
            int res = 0;
            return res;
        }
    }
}
