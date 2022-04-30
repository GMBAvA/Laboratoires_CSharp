using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_poo
{
    internal class ChargeurExamen
    {
        public static Examen GetExamen(int examenId)
        {
            switch (examenId)
            {
                case 1:
                    return GetExamen1();
                case 2:
                    return new Examen2();
                default:
                    throw new JPAException("Mauvais ID d'examen");
            }     
        }

        private static Examen GetExamen1()
        {
            List<Question> q = new List<Question>;
            string[] s = new string[1] { "La terre est ronde ?"};
            Question q = new Question(choix: s);
            Examen1 exam = new Examen1(q);
            // Ajouter des questions
            return exam;
            
        }
    }
}
