using System;
using System.Drawing;
//using InviteCommande.test;
using PuissanceInterface;

// https://github.com/tomakita/Colorful.Console
using Console = Colorful.Console;

namespace InviteCommande
{
    public partial class Program
    {
        private Color couleurCommande = Color.White;
        private Color couleurIndicateur = Color.White;
        private Color couleurTexte = Color.White;
        private Color couleurEcho= Color.White;
        private bool echoActif;
        private bool testActif;

        public static void Main(string[] args)
        {
            new Program(args).Demarrer();
        }

        public Program(string[] args) 
        {
            // POUR LE BONUS **** PARAMETRE MAIN ****
            /*
            if (args.Length > 0 && args[0] == "1")
                    echoActif = true;                       // POUR le mode ECHO ****
            if (args.Length > 1 && args[1] == "1")
                    testActif = true;                       // POUR le mode TEST ****
            if (args.Length == 3 && args[2] == "pro")       // POUR mode PRO ****
            {
                couleurCommande = Color.GreenYellow;
                couleurIndicateur = Color.CornflowerBlue;
                couleurTexte = Color.Chocolate;
                couleurEcho = Color.LightGreen;
            }
            */
        }

        private void Demarrer()
        {         
            string commande = "";
            PI pi = new PI(Afficher);
            //ChargerDisqueVirtuel(pi);
            Demarrage();

            if (testActif)      // Si le mode TEST est actif
            {
                //new AssuranceQualite(pi).ExecuterTestsAutomatiques();
                return;
            }

            while ((commande = InviteCommande()) != "q")
            {
                Echo(commande.Split());
                try
                {
                    pi.Executer(commande);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }
        }

        private void Demarrage()
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("**       INVITE DE COMMANDE (2021.1)         **");
            Console.WriteLine("**                                           **");
            Console.WriteLine("**      API : PI (Puissance Interface)       **");
            Console.WriteLine("**       Système de fichiers : Vdfs          **");
            Console.WriteLine("**                                           **");
            Console.WriteLine("** (taper la commande \"aide\" pour débuter)   **");
            Console.WriteLine("***********************************************");
        }

        private string InviteCommande()
        {
            Console.Write("pi -> ");
            return Console.ReadLine();
        }

        private void Afficher(params string[] information)
        {
            if (information.Length == 0)
                return;
            if (information.Length == 1)
                Console.Write(information[0], couleurTexte);
            else
            {
                Console.Write(" ");
                Console.Write(information[0], couleurCommande);
                if (information.Length == 3)
                {
                    Console.Write(" ");
                    Console.Write(information[1], couleurIndicateur);
                    for (int x = 2; x < information.Length; x++)
                    {
                        Console.Write(" ");
                        Console.Write(information[x], couleurTexte);
                    }
                }
                else
                {
                    Console.Write(" ");
                    Console.Write(information[1], couleurTexte);
                }
            }
            Console.WriteLine();
        }

        private void Echo(string[] information)
        {
            if (echoActif)      // Si le mode ECHO est actif
            {
                Console.Write($"pi_echo > ", couleurEcho);
                Afficher(information);
            }
        }

        private void ChargerDisqueVirtuel(PI pi)
        {
            // Dossier racine
            pi.Executer("doss /a D1");
            pi.Executer("doss /a D2");
            pi.Executer("fich /c f_racine1.txt Tester un programme démontre la présence de bugs, pas leur absence");
            pi.Executer("fich /c f_racine2.txt Il ne devrait pas y avoir des choses aussi ennuyeuses que les mathématiques");
            pi.Executer("fich /c f_racine3.txt L'informatique n’est pas plus sur les ordinateurs que l’astronomie est sur les télescopes");

            // Dossier D1
            pi.Executer("navi D1");
            pi.Executer("doss /a D3");
            pi.Executer("fich /c f_d1_1.txt La capacité de discerner la haute qualité implique inévitablement la capacité d'identifier les défauts");
            pi.Executer("fich /c f_d1_2.txt Si l'informatique est trop difficile, retournez faire des mathématiques");

            // Dossier D2
            pi.Executer("navi /p");
            pi.Executer("navi D2");
            pi.Executer("doss /a D4");
            pi.Executer("fich /c f_d2_1.txt La simplicité est une grande vertue mais elle demande beaucoup de travail et d'éducation pour l'apprécier. Malheureusement, la complexité est un meilleur vendeur");

            // Dossier D4
            pi.Executer("navi D4");
            pi.Executer("doss /a D5");
            pi.Executer("fich /c f_d4_1.txt La question de savoir si un ordinateur peut penser est aussi inutile que de se demander si un sous-marin peut nager");

            // Retour à la racine
            pi.Executer("navi /p");
            pi.Executer("navi /p");
        }
    }
}
