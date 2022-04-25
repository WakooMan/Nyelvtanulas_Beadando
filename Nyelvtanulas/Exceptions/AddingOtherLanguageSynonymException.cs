using System;
using System.Runtime.Serialization;

namespace Nyelvtanulas.Exceptions
{
    [Serializable]
    internal class AddingOtherLanguageSynonymException : Exception
    {
        public AddingOtherLanguageSynonymException()
        {
        }

        public AddingOtherLanguageSynonymException(string? message) : base(message)
        {
        }

        public AddingOtherLanguageSynonymException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected AddingOtherLanguageSynonymException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}