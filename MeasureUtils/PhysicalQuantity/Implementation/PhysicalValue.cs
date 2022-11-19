using PhysicalQuantity.Interfaces;

namespace PhysicalQuantity.Implementation
{
    public class PhysicalValue : IPhysicalValue
    {
        public PhysicalValue(decimal value, IPhysicalMultiplier multiplier)
        {
            Value = value;
            Multiplier = multiplier;
        }

        public PhysicalValue()
        {
            Value = default;
            
        }

        public decimal Value { get; }
        public IPhysicalMultiplier Multiplier { get; }
        public void Set(IPhysicalValue value)
        {
            throw new System.NotImplementedException();
        }

        public void Set(decimal value, IPhysicalMultiplier multiplier)
        {
            throw new System.NotImplementedException();
        }

        public void Set(decimal value)
        {
            throw new System.NotImplementedException();
        }
    }
}