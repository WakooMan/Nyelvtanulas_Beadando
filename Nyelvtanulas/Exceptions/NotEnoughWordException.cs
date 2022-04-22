using System;
using System.Runtime.Serialization;

namespace Nyelvtanulas.Exceptions
{
    [Serializable]
    internal class NotEnoughWordException : Exception
    {
        public NotEnoughWordException()
        {
        }

        public NotEnoughWordException(string? message) : base(message)
        {
        }

        public NotEnoughWordException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NotEnoughWordException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}