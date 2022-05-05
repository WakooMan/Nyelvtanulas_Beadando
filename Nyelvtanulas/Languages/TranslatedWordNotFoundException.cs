using System;
using System.Runtime.Serialization;

namespace Nyelvtanulas.Languages
{
    [Serializable]
    internal class TranslatedWordNotFoundException : Exception
    {
        public TranslatedWordNotFoundException()
        {
        }

        public TranslatedWordNotFoundException(string? message) : base(message)
        {
        }

        public TranslatedWordNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected TranslatedWordNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}