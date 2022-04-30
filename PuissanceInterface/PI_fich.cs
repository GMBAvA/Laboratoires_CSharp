using System;

namespace PuissanceInterface
{
    public partial class PI
    {
        private Aide aide_fich()
        {
            Aide aide = new Aide("fich", "Manipulation de fichiers ?");

            aide.Ajouter("fich /c [nom] [texte]", "Créer un fichier nom aveec le contenu texte");
            aide.Ajouter("fich [nom]", "Afficher les informations d'un fichier et son contenu");
            aide.Ajouter("fich /s [nom]", "Supprimer le fichier nom");

            return aide;
        }

        private string GetContenu(string[] parametres)
        {
            string contenu = "";
            bool premierParametre = true;
            for (int x = 3; x < parametres.Length; x++)
            {
                if (premierParametre)
                    premierParametre = false;
                else
                    contenu += " ";
                contenu += parametres[x];
            }
            return contenu;
        }

        private void fich(string[] parametres)
        {
            switch (GetIndicateur(parametres[1]))
            {
                case 'c':
                    if (parametres.Length < 4)
                    {
                        throw new PIException("Nombre de paramètres invalide" + parametres.Length);
                    }
                    else
                        vdfs.Courant.AjouterFichier(parametres[2], GetContenu(parametres));
                    break;
                case 's':
                    if (parametres.Length != 3)
                    {
                        throw new PIException("Nombre de paramètres invalide" + parametres.Length);
                    }
                    else
                        vdfs.Courant.SupprimerFichier(parametres[2]);
                    break;
                default:
                    throw new PIException("Indicateur invalide " + parametres[1]);
            }
            if (parametres[1] != "s" || parametres[1] != "c")
                Afficher(vdfs.Courant.GetInfoFichier(parametres[1]));
        }
    }
}
