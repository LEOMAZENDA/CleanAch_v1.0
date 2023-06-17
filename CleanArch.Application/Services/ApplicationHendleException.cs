using System;
using System.Runtime.Serialization;

namespace CleanArch.Application.Services
{
    [Serializable]
    internal class ApplicationHendleException : Exception
    {
        public ApplicationHendleException()
        {
        }

        public ApplicationHendleException(string message) : base(message)
        {
        }

        public ApplicationHendleException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ApplicationHendleException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}