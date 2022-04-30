using System;
using exam_poo;
using System.IO;

namespace laboratoire_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Redirection de la sortie d'erreur
                // PLACER VOTRE CODE ICI (ÉTAPE #2)

                
                

                JPA jpa = new JPA();
                int choix = -1;
                do
                {
                    choix = GetChoixMenu();

                    // AJOUTER UNE SECTION DE GESTION D'EXCEPTION AUTOUR DU SWITCH (ÉTAPE #2)
                    switch (choix)
                    {
                        case 1:
                            jpa.Authentification();
                            break;
                        case 2:
                            jpa.FaireExamen();
                            break;
                        case 3:
                            jpa.AfficherResultats();
                            break;
                    }
                }
                while (choix != 0);

                // Pour fermer le fichier
                // PLACER VOTRE CODE ICI (ÉTAPE #2)
                
            }
            catch (JPAException e)
            {
                FileInfo exceptionFile = new FileInfo(@"errors.txt");
                TextWriter exceptionWriter = new StreamWriter(exceptionFile.FullName);
                Console.SetError(exceptionWriter);
                Console.Error.WriteLine(e);
                Console.WriteLine(e);
            }
            using (TextWriter errorWriter = Console.Error)
            {
                errorWriter.Close();
                Console.SetError(new StreamWriter(Console.OpenStandardError()));
            }
        } 

        private static int GetChoixMenu()
        {
            int choix = -1;

            Console.WriteLine("MENU principal");
            Console.WriteLine("(1) Authentification");
            Console.WriteLine("(2) Faire un examen");
            Console.WriteLine("(3) Afficher les resultats");
            Console.WriteLine("(0) Quitter");

            do
            {
                try
                {
                    Console.Write(" > ");
                    choix = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Entree incorrecte!" + fe);
                }
            }
            while (choix == -1);
            Console.WriteLine();
            return choix;
        }

    }
}
