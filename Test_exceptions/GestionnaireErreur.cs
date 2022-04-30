using System;
using System.IO;

namespace ExceptionNamespace
{
    static class GestionnaireErreur
    {
        internal static void RedirigerFluxErreur()
        {
            FileInfo exceptionsFile = new FileInfo(@"errors.txt");
            TextWriter exceptionWriter = new StreamWriter(exceptionsFile.FullName);
            Console.SetError(exceptionWriter);
        }

        internal static void LibererFluxErreur()
        {
            using (TextWriter errorWriter = Console.Error)
            {
                // Pour fermer le fichier
                errorWriter.Close();
                // pour retourner a la console
                Console.SetError(new StreamWriter(Console.OpenStandardError()));
            }
        }

        internal static void Journaliser(Exception exception, Object objet = null) 
        {
            Console.Error.WriteLine(DateTime.Now + " : " + exception.Message);
            Console.Error.WriteLine(exception.StackTrace);
            if (objet != null)
                Console.Error.WriteLine(objet);                // Utilisation du ToString
        }

        internal static void Journaliser(MonException exception)
        {
            Journaliser((Exception)exception);
            if (exception.Chien == null)
                Console.Error.WriteLine("CODE OS : LE CHIEN EST NULL");
        }
    }
}
