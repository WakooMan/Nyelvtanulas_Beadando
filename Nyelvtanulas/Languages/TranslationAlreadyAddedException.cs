using System;
using System.Runtime.Serialization;

namespace Nyelvtanulas.Languages
{
    [Serializable]
    public class TranslationAlreadyAddedException : Exception
    {
        public TranslationAlreadyAddedException()
        {
        }

        public TranslationAlreadyAddedException(string? message) : base(message)
        {
        }

        public TranslationAlreadyAddedException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected TranslationAlreadyAddedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}