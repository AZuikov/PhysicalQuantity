using PhysicalQuantity.Implementation;

namespace PhysicalQuantity.Interfaces
{
    /// <summary>
    /// Описывает физическую величину.
    /// </summary>
    public interface IPhysicalQuantity
    {
        MeasurementUnit MeasurementUnit { get; }
    }
}