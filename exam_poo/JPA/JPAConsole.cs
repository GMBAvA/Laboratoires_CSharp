using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_poo
{
    public partial class JPA
    {
        private string LectureIdentite()
        {
            Console.WriteLine("CHARGEMENT DU PROFIL");
            Console.WriteLine("Inscrivez votre nom d'utilisateur >");
            string nomUser = Convert.ToString(Console.ReadLine());
            return nomUser;
        }

        private int LectureIdExamen()
        {
            Console.WriteLine("CHOIX DE L'EXAMEN");
            Console.WriteLine("Inscrivez votre no d'examen >");
            int noExamen = Convert.ToInt32(Console.ReadLine());
            if (noExamen == 1 || noExamen == 2)
            {
                return noExamen;
            }
               
            else
            {
                // manque inner exception
                throw new JPAException(message: "Cet examen n'existe pas");
            }
        }

        private void AfficherEnteteExamen(EnteteExamen enteteExamen)
        {

        }

        private void AfficherQuestion (Question question)
        {
            
        }

        private int LectureChoix()
        {
            Console.WriteLine("Inscrivez votre choix >");
        }

        private void AfficherProfil()
        {
            Console.WriteLine("AFFICHAGE DU PROFIL");
            Console.WriteLine(profil.GetNom);
        }
    }
}
