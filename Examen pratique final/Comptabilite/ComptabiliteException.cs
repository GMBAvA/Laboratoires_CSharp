using facture;
using entreprise;
using comptabilite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace comptabilite
{
    public class ComptabiliteException : Exception
    {
        private Facture facture;

        public ComptabiliteException() { }

        public ComptabiliteException(string message) { }

        public ComptabiliteException(string message, Facture facture) 
        {
            this.facture = facture;
        }

        public ComptabiliteException(string message, Exception innerException) { }

        public override string ToString()
        {
            string info = "ComptabiliteException : " + Message + "\n";
            if (facture != null)
                info += facture;
            return info;
        }

        protected ComptabiliteException(SerializationInfo info, StreamingContext context)
        {
            //Console.WriteLine(info +""+ context);
        }
    }
}
