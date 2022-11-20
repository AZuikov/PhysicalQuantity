using PhysicalQuantity.Interfaces;

namespace PhysicalQuantity.Implementation
{
    public class PhysicalValue : IPhysicalValue
    {
        public PhysicalValue(IPhysicalQuantity physicalQuantity, decimal value, IPhysicalMultiplier multiplier)
        {
            Value = value;
            Multiplier = multiplier;
            PhysicalQuantity = physicalQuantity;
        }

        public PhysicalValue(IPhysicalQuantity physicalQuantity)
        {
            PhysicalQuantity = physicalQuantity;
            Value = default;
            Multiplier = default;
        }

        public IPhysicalQuantity PhysicalQuantity { get; }
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