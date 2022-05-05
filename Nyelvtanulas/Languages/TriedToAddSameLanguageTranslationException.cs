using System;
using System.Runtime.Serialization;

namespace Nyelvtanulas.Languages
{
    [Serializable]
    internal class TriedToAddSameLanguageTranslationException : Exception
    {
        public TriedToAddSameLanguageTranslationException()
        {
        }

        public TriedToAddSameLanguageTranslationException(string? message) : base(message)
        {
        }

        public TriedToAddSameLanguageTranslationException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected TriedToAddSameLanguageTranslationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}