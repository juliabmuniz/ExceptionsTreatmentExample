using System;

namespace ExceptionsTreatmentExemple.Entities.Exception {
    internal class DomainException : ApplicationException {

        public DomainException(string message) : base(message) {
        }
    }
}
