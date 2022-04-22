using System;
using System.Runtime.Serialization;

namespace Nyelvtanulas.Exceptions
{
    [Serializable]
    internal class AddingSameLanguageWordException : Exception
    {
        public AddingSameLanguageWordException()
        {
        }

        public AddingSameLanguageWordException(string? message) : base(message)
        {
        }

        public AddingSameLanguageWordException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected AddingSameLanguageWordException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}