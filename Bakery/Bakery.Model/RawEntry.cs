using Production;

namespace Bakery.Model.Implementation
{
    /// <summary>
    /// Учетная запись о сырье
    /// </summary>
    public class RawEntry : UnitEntry, IRawCount
    {
        public int RawId
        {
            get { return Id; }
        }
    }
}