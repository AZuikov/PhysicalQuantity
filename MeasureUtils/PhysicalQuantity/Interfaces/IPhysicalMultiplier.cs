namespace PhysicalQuantity.Interfaces
{
    /// <summary>
    /// Описывает множитель физической величины.
    /// </summary>
    public interface IPhysicalMultiplier
    {
        /// <summary>
        /// Текстовое представление множителя физической величины.
        /// </summary>
        string TextRepresentation { get; }
        
        /// <summary>
        /// Числовое значение множителя физической величины.
        /// </summary>
        decimal Value { get; }
    }
}