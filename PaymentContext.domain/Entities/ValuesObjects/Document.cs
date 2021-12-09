using PaymentContext.domain.Enums;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.domain.ValuesObjects
{
    public class Document : ValueObject
    {
        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;
        }

        public string Number { get; private set; } 
        public EDocumentType Type { get; private set; }
    }
}