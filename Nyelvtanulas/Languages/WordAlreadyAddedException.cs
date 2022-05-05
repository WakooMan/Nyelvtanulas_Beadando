using System;
using System.Runtime.Serialization;

namespace Nyelvtanulas.Languages
{
    [Serializable]
    internal class WordAlreadyAddedException : Exception
    {
        public WordAlreadyAddedException()
        {
        }

        public WordAlreadyAddedException(string? message) : base(message)
        {
        }

        public WordAlreadyAddedException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected WordAlreadyAddedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}