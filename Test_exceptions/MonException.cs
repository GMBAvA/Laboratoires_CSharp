using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ExceptionNamespace
{
    class MonException : Exception
    {
        private Chien chien;

        public Chien Chien {
            get{
                return chien;
            } 
        }

        public MonException(Chien chien)
        {
            this.chien = chien;
        }

        public MonException(Chien chien, string message) : base(message)
        {
            this.chien = chien;
        }

        public MonException(Chien chien, string message, Exception innerException) : base(message, innerException)
        {
            this.chien = chien;
        }

        protected MonException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public override string ToString()
        {
            return "MonException:{message:" + Message + ",chien:" + chien + "}";
        }
    }
}
