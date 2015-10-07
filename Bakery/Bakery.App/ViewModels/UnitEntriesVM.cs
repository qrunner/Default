using Bakery.Model;

namespace Bakery.App.ViewModels
{
    internal class UnitEntriesVM : ViewModelBase
    {
        private readonly IUnitEntryHost _unitEntryHost;

        public UnitEntriesVM(Context context, IUnitEntryHost unitEntryHost) :
            base(context)
        {
            _unitEntryHost = unitEntryHost;
        }

        public IUnitEntryHost UnitEntryHost
        {
            get { return _unitEntryHost; }
        }
    }
}