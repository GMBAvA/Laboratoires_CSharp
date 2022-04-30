using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuissanceInterface
{
    // Fdfs : Virtual drive File System
    internal class Vdfs
    {
        private Dossier courant;
        private enum VdfsType { DOSSIER_COURANT, DOSSIER_ENFANT, FICHIER, FICHIER_CACHE }

        public Vdfs(Dossier racine)
        {
            courant = racine;
        }

        public void ChangerDossier(string dossierDestination)
        {
            if (courant.Enfant1.Nom.CompareTo(dossierDestination) == 0)
                courant = courant.Enfant1;
            else if (courant.Enfant2.Nom.CompareTo(dossierDestination) == 0)
                courant = courant.Enfant2;
            else
                throw new PIException("Impossible d'aller vers le dossier " + dossierDestination + " . Le dossier est introuvable");
        }

        public void ChangerDossier()
        {
            if (courant.Parent != null)
                courant = courant.Parent;
        }

        public string GetInfoDrive()
        {
            string infoDrive = "";
            Dossier dossierCourant = courant;

            while (dossierCourant != null)
            {
                infoDrive = dossierCourant.Nom + "/" + infoDrive;
                dossierCourant = dossierCourant.Parent;
            }
            return infoDrive;
        }

        public string GetInfoFichiers(bool normal = true, bool cache = true)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Fichier fichier in courant.Fichiers)
            {
                if (!fichier.Cache && normal)
                    sb.Append(GetVdfsType(VdfsType.FICHIER)).Append(fichier.Nom).AppendLine();
                if (fichier.Cache && cache)
                    sb.Append(GetVdfsType(VdfsType.FICHIER_CACHE)).Append(fichier.Nom).AppendLine();
            }
            return sb.ToString();
        }

        public string GetInfoDossiers(bool recursif = false)
        {
            StringBuilder sb = new StringBuilder();
            if (recursif)
                GetInfoDossierRecursif(courant, sb, 0);
            else
                GetInfoDossierEnfants(courant, sb);
            return sb.ToString();
        }

        private void GetInfoDossierEnfants(Dossier dossier, StringBuilder sb)
        {
            if (dossier.Enfant1 != null)
                sb.Append(GetVdfsType(VdfsType.DOSSIER_ENFANT)).Append(dossier.Enfant1.Nom).AppendLine();
            if (dossier.Enfant2 != null)
                sb.Append(GetVdfsType(VdfsType.DOSSIER_ENFANT)).Append(dossier.Enfant2.Nom).AppendLine();
        }

        private void GetInfoDossierRecursif(Dossier dossier, StringBuilder sb, int niveau)
        {
            // Condition de sortie
            if (dossier == null)
                return;

            // Récupérer le dossier
            sb.Append(GetVdfsType(VdfsType.DOSSIER_COURANT));
            GetInfoNiveau(niveau, sb);
            sb.Append(dossier.Nom).AppendLine();

            // récupérer les enfants
            GetInfoDossierRecursif(dossier.Enfant1, sb, niveau + 1);
            GetInfoDossierRecursif(dossier.Enfant2, sb, niveau + 1);
        }

        private void GetInfoNiveau(int niveau, StringBuilder sb)
        {
            for (int x = 0; x < niveau; x++)
                sb.Append("  ");
        }

        public Dossier Courant
        {
            get => courant;
        }

        private string GetVdfsType(VdfsType type)
        {
            switch (type)
            {
                case VdfsType.DOSSIER_COURANT: return "> ";
                case VdfsType.DOSSIER_ENFANT: return "d > ";
                case VdfsType.FICHIER: return "f > ";
                case VdfsType.FICHIER_CACHE: return "f*> ";
            }
            return "?";
        }
    }
}
