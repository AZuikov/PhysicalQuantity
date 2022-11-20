using PhysicalQuantity.Interfaces;

namespace PhysicalQuantity.Implementation
{
    public class PhysicalMultiplier : IPhysicalMultiplier
    {
        public PhysicalMultiplier(string textRepresentation, decimal value)
        {
            TextRepresentation = textRepresentation;
            Value = value;
        }

        public string TextRepresentation { get; }
        public decimal Value { get; } = 1;
    }
}