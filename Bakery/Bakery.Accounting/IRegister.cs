namespace Accounting
{
    /// <summary>
    /// Учетный регистр ТМЦ
    /// </summary>
    public interface IRegister : IAccount
    {
        /// <summary>
        /// Категория регистра
        /// </summary>
        IRegisterCategory Category { get; }

        /// <summary>
        /// ТМЦ, к которой относится регистр
        /// </summary>
        IUnit Unit { get; }

        /// <summary>
        /// Единица измерения регистра
        /// </summary>
        IMeasureUnit MeasureUnit { get; }
    }
}