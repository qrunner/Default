namespace Accounting
{
    /// <summary>
    /// Запись о наличии ТМЦ
    /// </summary>
    public interface IUnitEntry : IUnitInfo, IPriceInfo, ICostInfo
    {
    }
}