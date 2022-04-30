using System;
using System.Runtime.Serialization;

namespace exam_poo
{
    public class JPAException : Exception
    {
        public JPAException(string message) { }

        public JPAException(string message, Exception innerException) { }

        public JPAException(SerializationInfo info, StreamingContext context) { }

        public override string ToString()
        {
            string txt = DateTime.Now.ToLocalTime() + " : JPAException {" + Message + "}\n" + StackTrace;
            if (InnerException != null)
                txt += "\n" + InnerException.Message;
            
            return txt;
        }
    }
}
