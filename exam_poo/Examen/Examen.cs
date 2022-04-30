using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_poo
{
    internal class Examen
    {
        private List<Question> questions;
        private EnteteExamen enteteExamen;

        public EnteteExamen Entete
        {
            get => enteteExamen;
        }

        public Examen (string titre)
        {
            enteteExamen.Titre = titre;
        }

        public int GetNbQuestions()
        {
            int res = 0;
            return res;
        }

        public Question GetQuestion(int noQuestion)
        {
            return questions[noQuestion];
        }

        private void AjouterQuestion(Question question)
        {
            questions.Add(question);
        }
        
    }
}
