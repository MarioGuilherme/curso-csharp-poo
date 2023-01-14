using System.Runtime.Serialization;

namespace Excecao {
    [Serializable]
    internal class DomainExcpetion : Exception {
        public DomainExcpetion() {
        }

        public DomainExcpetion(string? message) : base(message) {
        }

        public DomainExcpetion(string? message, Exception? innerException) : base(message, innerException) {
        }

        protected DomainExcpetion(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}