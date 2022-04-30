using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuissanceInterface
{
    public partial class PI
    {
        private Aide aide_doss()
        {
            Aide aide = new Aide("doss", "navigation entre les dossiers");

            aide.Ajouter("doss /a [nom]", "Ajouter le dossier [nom] au dossier courant (max 2 dossiers)");
            aide.Ajouter("doss /d", "Afficher l'arborescence des dossiers");
            aide.Ajouter("doss", "Afficher le dossier et les fichiers non cachés");
            aide.Ajouter("doss /t", "Afficher le dossier et tous les fichiers");
            aide.Ajouter("doss /c", "Afficher le dossier et les fichiers cachés");

            return aide;
        }

        private void doss(string[] parametres)
        {
            switch (parametres.Length)
            {
                case 1:
                    Afficher(vdfs.GetInfoDrive());
                    Afficher(vdfs.GetInfoDossiers());
                    Afficher(vdfs.GetInfoFichiers(cache: false));
                    break;
                case 3:
                    if (GetIndicateur(parametres[1]) == 'a')
                        vdfs.Courant.AjouterDossier(parametres[2]);
                    else
                        throw new PIException("Indicateur invalide " + parametres[1]);
                    break;
                case 2:
                    switch (GetIndicateur(parametres[1]))
                    {
                        case 't':
                            Afficher(vdfs.GetInfoDossiers());
                            break;
                        case 'c':
                            Afficher(vdfs.GetInfoFichiers(cache: false));
                            break;
                        case 'd':
                            Afficher(vdfs.GetInfoDossiers(true));
                            break;
                        default:
                            throw new PIException("Indicateur invalide " + parametres[1]);
                    }
                    break;
                default:
                    throw new PIException("Nombre de paramètres invalides " + parametres.Length);
            }
        }
    }
}
