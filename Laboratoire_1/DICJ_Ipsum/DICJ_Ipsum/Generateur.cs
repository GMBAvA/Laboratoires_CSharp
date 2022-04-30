using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DICJ_Ipsum
{
    static class Generateur
    {


        public static string Generate(string type = null, int quantite = -1, string aTransformer = null)
        {
            string aRetourner = "";
            int index = 0;

            if(type == null && quantite == -1 && aTransformer == null)
            {
                quantite = RandomNumber.Between(1, 101);
                for(int i = 0; i < quantite; i++)
                {
                    index = RandomNumber.Between(0, 249);
                    aRetourner += DictionnaireInfo.DicoInfo.ElementAt(index).Value + " ";
                }
            }
            else if(type == null && quantite != -1 && aTransformer == null)
            {
                for (int i = 0; i < quantite; i++)
                {
                    index = RandomNumber.Between(0, 249);
                    aRetourner += DictionnaireInfo.DicoInfo.ElementAt(index).Value + " ";
                }
            }
            else
            {
                if(type == "ascii")
                {
                    byte[] ASCIIValues = Encoding.ASCII.GetBytes(aTransformer); 
                    foreach(byte b in ASCIIValues)
                    {
                        aRetourner += b + " ";
                    }
                }
                else
                {
                    byte[] ASCIIValues = Encoding.ASCII.GetBytes(aTransformer);
                    foreach(byte b in ASCIIValues)
                    {
                        string binary = Convert.ToString(b, 2);
                        while(binary.Length < 8)
                        {
                            binary = "0" + binary;
                        }
                        aRetourner += binary + " ";
                    }
                }
            }

            return aRetourner;
        }
    }
}
