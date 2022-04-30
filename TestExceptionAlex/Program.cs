using System;

namespace TestExceptionAlex
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test1();
            Console.WriteLine("Entrez un nombre :");
            int nb = Convert.ToInt32(Console.ReadLine());
            Validation(nb);
            void Test1()
            {
                int nb = -1;
                while (nb > 1 || nb < 10)
                {
                    try
                    {
                        Console.WriteLine("Entrez un nombre entre 1 et 10");
                        nb = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Vous n'avez pas entré de nombre :");
                        Console.WriteLine(e);
                    }
                }
            }




            bool Validation(int valeur)
            {

                if (valeur < 1000)
                {
                    return true;
                }
                else if (valeur < 100)
                {
                    return false;
                }
                else

                        throw new Exception("La valeur entré est mauvaise");    
            }
        }
    }
}
