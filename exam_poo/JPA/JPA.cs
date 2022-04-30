using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_poo
{
    public partial class JPA
    {
        private Profil profil;

        public JPA()
        {

        }

        public void Authentification()
        {
            profil = new Profil(LectureIdentite());
        }

        public void FaireExamen()
        {
            if (profil == null)
            {
                throw new JPAException("Profil non selectionné");
            }
            LectureIdExamen();

            // ici

            
            Examen examen = ChargeurExamen.GetExamen(LectureIdExamen(id));
            List<Reponse> reponses = new List<Reponse>;
            AfficherEnteteExamen(examen.Entete);
            
        }

        public void AfficherResultats()
        {
            if (profil == null)
            {
                throw new JPAException("Profil non selectionné");
            }

            AfficherProfil();
        }
    }
}
