using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_poo
{
    internal sealed class QuestionVraiFaux : Question
    {
        protected QuestionVraiFaux(int id, int ponderation, string enonce, int reponse) : base(id, ponderation, enonce, reponse)
        {

        }
    }
}
