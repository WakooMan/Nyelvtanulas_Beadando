using System;
using System.Runtime.Serialization;

namespace Nyelvtanulas.Languages
{
    [Serializable]
    internal class SynonymAlreadyAddedException : Exception
    {
        public SynonymAlreadyAddedException()
        {
        }

        public SynonymAlreadyAddedException(string? message) : base(message)
        {
        }

        public SynonymAlreadyAddedException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected SynonymAlreadyAddedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}