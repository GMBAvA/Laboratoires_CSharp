using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuissanceInterface
{
    class Dossier
    {
        private string nom;
        private Dossier parent;
        private Dossier enfant1;
        private Dossier enfant2;
        private List<Fichier> fichiers;

        public Dossier(string nom, Dossier parent = null)
        {
            this.nom = nom;
            this.parent = parent;
            enfant1 = null;
            enfant2 = null;
            fichiers = new List<Fichier>();
        }

        private Fichier TrouverFichier(string nomFichier) // ???
        {
            foreach (Fichier fichier in fichiers)
            {
                if (fichier.Nom.CompareTo(nomFichier) == 0) // ici
                    return fichier;
            }
            return null;
        }

        /*public void AjouterFichier(string nom, string contenu) //Compris
        {
            string e = "Impossible d'ajouter le fichier " + nom + " car il existe déjà";
            if (TrouverFichier(nom) != null)
            {
                throw new PIException(e);
            }
            else
                fichiers.Add(new Fichier(nom, contenu));
        }*/
        public void AjouterFichier(string nom, string contenu)
        {
            Fichier recherche = TrouverFichier(nom);
            if (recherche != null)
                throw new PIException("Impossible d'ajouter le fichier " + nom + " . Il existe deja!");
            fichiers.Add(new Fichier(nom, contenu));
        }

        /*public void SupprimerFichier(string nom)
        {
            string e = "Impossible de supprimer le fichier " + nom + " car il n'existe pas";

            Fichier aTrouve = TrouverFichier(nom);

            if (aTrouve == null)
            {
                throw new PIException(e);
            }
            else
                fichiers.Remove(aTrouve);
        }*/

        public void SupprimerFichier(string nom)
        {
            Fichier recherche = TrouverFichier(nom);
            if (recherche == null)
                throw new PIException("Impossible de supprimer le fichier " + nom + " . Il n'existe pas!");
            fichiers.Remove(recherche);
        }

        /*public void AjouterDossier(string nouveauDossier)
        {
            if (enfant1 == null)
            {
                enfant1 = new Dossier(nouveauDossier, this);
            }
            else if (enfant2 == null)
            {
                enfant2 = new Dossier(nouveauDossier, this);
            }
            else
                throw new PIException("Impossible d'ajouter le dossier " + nouveauDossier + " car la limite de dossiers est atteinte");
        }*/

        public void AjouterDossier(string nouveauDossier)
        {
            if (enfant1 == null)
                enfant1 = new Dossier(nouveauDossier, this);
            else if (enfant2 == null)
                enfant2 = new Dossier(nouveauDossier, this);
            else
                throw new PIException("Impossible d'ajouter le dossier " + nom + " . Limite de dossier atteinte!");
        }




        /*public string GetInfoFichier(string nom)
        {
            Fichier aTrouve = TrouverFichier(nom);
            if (aTrouve == null)
            {
                throw new PIException("Impossible de récupérer les informations du fichier " + nom + " car il est introuvable");
            }
            else
                return aTrouve.GetInfo();
        }*/

        public string GetInfoFichier(string nom)
        {
            Fichier recherche = TrouverFichier(nom);
            if (recherche == null)
                throw new PIException("Impossible de récupérer les informations du fichier " + nom + " . Fichier introuvable!");
            return recherche.GetInfo();
        }




        /*public void ModifierEtatFichier(bool cache, string nom = null)
        {
            if (nom != null)
            {
                Fichier leFichier = TrouverFichier(nom);
                leFichier.Cache = true;
            }
            else
                foreach (Fichier fichier in fichiers)
                {
                    ModifierEtatFichier(cache = true, fichier.Nom);
                }
        }*/
        public void ModifierEtatFichier(bool cache, string nom = null)
        {
            if (nom != null)
                TrouverFichier(nom).Cache = cache;
            else
                foreach (Fichier fichier in fichiers)
                    ModifierEtatFichier(cache, fichier.Nom);
        }

        public List<Fichier> Fichiers
        {
            get => fichiers;
        }

        public string Nom
        {
            get => nom;
        }

        public Dossier Parent
        {
            get => parent;
        }

        public Dossier Enfant1
        {
            get => enfant1;
        }

        public Dossier Enfant2
        {
            get => enfant2;
        }
    }
}