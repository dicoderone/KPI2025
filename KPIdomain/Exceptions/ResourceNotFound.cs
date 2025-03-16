using System.Runtime.Serialization;

namespace KPIdomain.Exceptions
{
    [Serializable]
    public class ResourceNotFound : Exception
    {
        public ResourceNotFound() { }

        public ResourceNotFound(Type type) : base($"{type} is missing") { }

        public ResourceNotFound(SerializationInfo info, StreamingContext context) : base(info, context) { }

        public ResourceNotFound(string message) : base(message) { }

        public ResourceNotFound(string message, Exception innerException) : base(message, innerException) { }

    }
}
