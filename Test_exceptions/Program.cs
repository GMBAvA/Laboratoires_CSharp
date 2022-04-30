// https://www.tutorialspoint.com/csharp/csharp_exception_handling.htm

using System;
using System.IO;

namespace ExceptionNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            GestionnaireErreur.RedirigerFluxErreur();
            string choix;

            do
            {
                Console.Write("Choix du test (1-5) > ");
                choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        TestException1();
                        break;
                    case "2":
                        TestException2();
                        break;
                    case "3":
                        try
                        {
                            TestException3();
                        }
                        catch (MonException me)
                        {
                            Console.WriteLine("..MON EXCEPTION");
                            Console.WriteLine(me.Message);                  // Le message texte de l'erreur
                            Console.WriteLine(me);                          // ToString
                            GestionnaireErreur.Journaliser(me);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("..UNE EXCEPTION");
                            Console.WriteLine(e.Message);                  // Le message texte de l'erreur
                            Console.WriteLine(e);                          // ToString
                            GestionnaireErreur.Journaliser(e);
                        }
                        break;
                    case "4":
                        try
                        {
                            TestException4();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("erreur : " + e.Message);
                        }
                        break;
                    case "5":
                        int zero = 0;
                        int y = 4 / zero;
                        break;
                }
            }
            while (choix != "0");

            // On remarque ici que le flux n'est pas libéré avec le cas 5
            GestionnaireErreur.LibererFluxErreur();
        }


        /* Comment attraper une exception optionelle mais "previsible"
         * Dans ce cas. une division par 0
         */
        public static void TestException1()
        {
            Console.WriteLine("EXCEPTION_1");

            int x = 0, y = 0, z = 0;

            Console.WriteLine("..ex1_1");
            Chien pogo = null;
            try
            {
                pogo = new Chien();
                Console.WriteLine("..ex1_2");
                Console.Write("> x : ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("> y : (entrer 0 pour tester l'exception)");
                y = Convert.ToInt32(Console.ReadLine());
                z = x / y;
                Console.WriteLine("..ex1_3");
            }
            catch (Exception e)
            {
                Console.WriteLine("..ex1_4");
                Console.WriteLine(e.Message);                 // Le message texte de l'erreur

                // Il est possible d'écrire dans le flux d'erreur
                Console.Error.WriteLine(e.Message);
                Console.Error.WriteLine(e.StackTrace);
                Console.Error.WriteLine(pogo);                // Utilisation du ToString
            }
            Console.WriteLine("..ex1_5");
        }


        /* Comment attraper une exception optionelle mais "previsible"
         * Dans ce cas, une entree utilisateur avec un mauvais type
         */
        public static void TestException2()
        {
            Console.WriteLine("EXCEPTION_2");

            int x;

            Console.WriteLine("..ex2_1");
            x = getValeur1();
            Console.WriteLine("La valeur_1 de X est : " + x);

            Console.WriteLine("..ex2_2");
            try
            {
                x = getValeur2();
            }
            catch (Exception e)
            {
                Console.WriteLine("..ex2_3");
                Console.WriteLine(e.Message);                 // Le message texte de l'erreur
                GestionnaireErreur.Journaliser(e);
            }
            Console.WriteLine("La valeur_2 de X est : " + x);
            Console.WriteLine("..ex2_4");
        }

        // Gestion de l'exception a l'interieur de la fonction
        public static int getValeur1()
        {
            Console.WriteLine("GETVALEUR1");

            int x = 1;
            try
            {
                Console.WriteLine("..getV1_1");
                Console.Write("> x : (entrer un string) ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("..getV1_2");
            }
            catch (Exception e)
            {
                Console.WriteLine("..getV1_3");
                Console.WriteLine(e.Message);                 // Le message texte de l'erreur
                GestionnaireErreur.Journaliser(e);
            }
            Console.WriteLine("..getV1_4");

            return x;
        }

        // Retour de l'exception a la fonction appelante
        public static int getValeur2()
        {
            Console.WriteLine("GETVALEUR2");

            int x;

            Console.WriteLine("..getV2_1");
            Console.Write("> x : (entrer un string) ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("..getV2_2");

            return x;
        }

        public static void TestException3()
        {
            Console.Write("> x : (0 - Chien est null, 1 - il n'est pas null) ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x != 0)
                throw new MonException(new Chien(), "EXCEPTION AUTO AVEC UN CHIEN");
            throw new Exception("EXCEPTION AUTO SANS CHIEN");
        }


        /* Une exception lancee manuellement
            * */
        public static void TestException4()
        {
            Console.WriteLine("EXCEPTION_4");
            int valeur = 0;

            Console.WriteLine("..ex4_1");
            try
            {
                Console.Write("> x : ");
                valeur = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("..ex4_2");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ce n'est pas un entier!");
                Console.WriteLine("..ex4_3");
                GestionnaireErreur.Journaliser(e);
                throw;                  // On relance la propagation
            }

            Console.WriteLine("..ex4_4");
            if (valeur == 0)
                throw new Exception("HEY YO!  Faut pas entrer un 0!");
            Console.WriteLine("..ex4_5");
        }
    }
}
