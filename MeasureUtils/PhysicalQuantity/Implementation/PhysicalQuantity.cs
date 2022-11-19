using PhysicalQuantity.Interfaces;

namespace PhysicalQuantity.Implementation
{
    
    public class PhysicalQuantity : IPhysicalQuantity
    {
        public IPhysicalValue PhysicalValue { get; }
        public MeasurementUnit MeasurementUnit { get; }
    }
}
