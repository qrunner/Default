using Accounting;

namespace Production
{
    /// <summary>
    /// Вспомогательный класс, возвращающий результаты расчетов
    /// </summary>
    public class UnitCount : IUnitCount
    {
        public decimal Count { get; set; }
        
        public int UnitId { get; set; }
    }
}