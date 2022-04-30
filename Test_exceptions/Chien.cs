using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionNamespace
{
    class Chien
    {
        private String nom = "POGO";
        private int age = 2;

        public override string ToString()
        {
            return "CHIEN:{nom:" + nom + ",age:" + age + "}";
        }
    }
}
