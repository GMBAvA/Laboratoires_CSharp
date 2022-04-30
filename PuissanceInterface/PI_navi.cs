using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuissanceInterface
{
    public partial class PI
    {
        private Aide aide_navi()
        {
            Aide aide = new Aide("navi", "navigation entre les dossiers");

            aide.Ajouter("navi /p", "Retour au dossier parent");
            aide.Ajouter("navi [nom]", "Accéder au dossier nom");

            return aide;
        }

        private void navi(string[] parametres)
        {
            
            if (parametres.Length != 2)
            {
                throw new PIException("Nombre de paramètres incorrect (" + parametres.Length + ")");
            }

            if (EstIndicateur(parametres[1]))
            {
                if (GetIndicateur(parametres[1]) == 'p')
                {
                    vdfs.ChangerDossier();
                }
                else
                    throw new PIException("Indicateur incorrect (" + GetIndicateur(parametres[1]) + ")");
            }
            else
                vdfs.ChangerDossier(parametres[1]);
        }
    }
}
