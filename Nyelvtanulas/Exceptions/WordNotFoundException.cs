using System;
using System.Runtime.Serialization;

namespace Nyelvtanulas.Exceptions
{
    [Serializable]
    internal class WordNotFoundException : Exception
    {
        public WordNotFoundException()
        {
        }

        public WordNotFoundException(string? message) : base(message)
        {
        }

        public WordNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected WordNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}