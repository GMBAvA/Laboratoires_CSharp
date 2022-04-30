using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PuissanceInterface
{
    public class PIException : Exception
    {
        public PIException()
        {
        }

        public PIException(string message) : base(message)
        {
        }

        public PIException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PIException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
