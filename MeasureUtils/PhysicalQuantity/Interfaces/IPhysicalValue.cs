using System.Dynamic;
using PhysicalQuantity.Implementation;

namespace PhysicalQuantity.Interfaces
{
    /// <summary>
    /// Значение физической величины.
    /// </summary>
    public interface IPhysicalValue
    {
        /// <summary>
        /// Числовое значение физической величины.
        /// </summary>
        decimal Value { get; }
        /// <summary>
        /// Множитель физической величины.
        /// </summary>
        IPhysicalMultiplier Multiplier { get; }

        /// <summary>
        /// Устанавливает значение физической величины.
        /// </summary>
        /// <param name="value">Значение физической величины.</param>
        void Set(IPhysicalValue value);
        
        /// <summary>
        /// Устанавливает значение физической величины.
        /// </summary>
        /// <param name="value">Числовое значение физической величины.</param>
        /// <param name="multiplier">Множитель физической величины.</param>
        void Set(decimal value, IPhysicalMultiplier multiplier);
        
        /// <summary>
        /// Устанавливает значение физической величины.
        /// </summary>
        /// <param name="value">Числовое значение физической величины.</param>
        void Set(decimal value);
        
    }
}