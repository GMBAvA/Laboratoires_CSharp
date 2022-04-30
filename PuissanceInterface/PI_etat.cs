using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuissanceInterface
{
    public partial class PI
    {
        private Aide aide_etat()
        {
            Aide aide = new Aide("etat", "Manipuler l'état des fichiers et dossiers");

            aide.Ajouter("etat /c [nom]", "Cacher le fichier nom");
            aide.Ajouter("etat /d", "Decacher tous les fichiers du dossier");
            aide.Ajouter("etat /d [nom]", "Decacher le fichier nom");
            aide.Ajouter("etat /c", "Cacher tous les fichiers du dossier");

            return aide;
        }

        private void etat(string[] parametres)
        {

            if (parametres.Length != 2 || parametres.Length != 3)
            {
                throw new PIException("Nombre de paramètres incorrect (" + parametres.Length + ")");
            }

            else if (EstIndicateur(parametres[1]))
            {
                if (GetIndicateur(parametres[1]) == 'c')
                {
                    if (parametres.Length == 2)
                    {
                        vdfs.Courant.ModifierEtatFichier(true, null);
                    }
                    else if (parametres.Length == 3)
                    {
                        vdfs.Courant.ModifierEtatFichier(true, parametres[2]);
                    }
                }

                else if (GetIndicateur(parametres[1]) == 'd')
                {
                    if (parametres.Length == 2)
                    {
                        vdfs.Courant.ModifierEtatFichier(false, null);
                    }
                    else if (parametres.Length == 3)
                    {
                        vdfs.Courant.ModifierEtatFichier(false, parametres[2]);
                    }
                }
            }
            else
                throw new PIException("Indicateur invalide");
        }
    }
}
