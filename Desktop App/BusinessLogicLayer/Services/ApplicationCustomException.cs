using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ApplicationCustomException : Exception
    {
        public ApplicationCustomException()
        {
        }

        public ApplicationCustomException(string? message) : base(message)
        {
        }

        public ApplicationCustomException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ApplicationCustomException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
