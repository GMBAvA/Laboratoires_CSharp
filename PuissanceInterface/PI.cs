using System.Collections.Generic;
using System.Reflection;
using System;

namespace PuissanceInterface
{
    public partial class PI
    {
        private const char INDICATEUR = '/';
        private Vdfs vdfs;
        private List<Aide> rubriquesAide;
        public delegate void DelAffichage(params string[] message);
        private DelAffichage methodeAffichage;

        public PI(DelAffichage methodeAffichage) 
        {
            vdfs = new Vdfs(new Dossier("racine"));
            rubriquesAide = new List<Aide>();
            ChargerRubriques();
            this.methodeAffichage = methodeAffichage;
        }

        private void ChargerRubriques() 
        {
            MethodInfo[] methodes = GetType().GetTypeInfo().GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (MethodInfo methode in methodes)
                if (methode.Name.Contains("aide_"))
                    rubriquesAide.Add((Aide)methode.Invoke(this, new object[] { }));
        }

        public void Executer(string[] parametres) 
        {
            try
            {
                GetType().GetTypeInfo().GetDeclaredMethod(parametres[0]).Invoke(this, new[] { parametres });
            }
            catch(Exception e)
            {
                Afficher(e.Message);
                Afficher(e.StackTrace);
            }
        }

        public void Executer(string commande) 
        {
            if (commande != null && commande.Length > 0)
                Executer(commande.ToLower().Split());
            else
                aide(new string[] { "" });
        }


        /*  pour information : ca remplace un switch hardcodé mais c'est il y a des dangers importants
         *  
            switch (parametres[0].ToUpper())
            {
                case "aide":    aide(parametres);             // Aide
                                break;
                case "doss":    doss(parametres);             // Dossier
                                break;
                case "navi":    chem(parametres);             // Navigation
                                break;
                case "fich":    fich(parametres);             // Fichiers
                                break;
                case "etat":    etat(parametres);             // État
                                break;

                // SUPER bonus
                case "rech":  re(parametres);             // Recherche
                            break;


                default:    //throw new PIException
                            break;
            }
        */

        private void aide(string[] parametres)
        {
            if (parametres.Length == 2)
                AfficherAide(parametres[1]);
            else if (parametres.Length == 1 && parametres[0].ToLower().CompareTo("aide") == 0)
                AfficherCommandesDisponibles();
            else if (parametres.Length == 2)
                Afficher("Commande invalide (commande aide pour la liste des commandes disponibles)");
        }

        private void AfficherCommandesDisponibles()
        {
            Afficher("Les commandes disponibles");
            Afficher("  aide [commande]  pour de l'aide sur une commande en particulier");
            foreach (Aide rubrique in rubriquesAide)
                Afficher("  -> " + rubrique.Id + "\t" + rubrique.Description);
        }

        private void AfficherAide(string commande)
          {
            foreach (Aide rubrique in rubriquesAide)
                if (rubrique.Id.CompareTo(commande.ToLower()) == 0)
                {
                    Afficher(rubrique.ToString());
                    return;
                }
            Afficher("Commande invalide (commande aide pour la liste des commandes disponibles)");
        }

        private Aide aide_aide()
        {
            Aide aide = new Aide("aide", "Aide sur PI");
            aide.Ajouter("aide [commande]", "Pour de l'aide sur une commmande en particulier");
            aide.Ajouter("aide", "Pour la liste de commandes disponibles");

            return aide;
        }


        private char GetIndicateur(string parametre)
        {
            if (EstIndicateur(parametre))
                return (char)(parametre[1]);
            throw new PIException("Indicateur inexistant dans le parametre " + parametre);
        }

        private void Afficher(string message)
        {
            methodeAffichage(message);
        }

        private bool EstIndicateur(string parametre)
        {
            return parametre.Contains(INDICATEUR);
        }
    }
}
