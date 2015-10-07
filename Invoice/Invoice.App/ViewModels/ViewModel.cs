using Invoice.ServiceLayer.MySql;
using System.ComponentModel;
using Sirius.Desktop;

namespace Invoice.App.ViewModels
{
    public class ViewModel : ViewModelBase
    {
        protected string CategoryOperations = "Операции";
        protected string CategoryFilter = "Фильтр";

        public ViewModel()
        {
            UpdateDataContext();            
        }

        protected void UpdateDataContext()
        {
            if (DataContext != null)
                DataContext.Dispose();
            DataContext = InvoiceApp.CreateModelContext();
        }

        public IChangeTracking ChangeTracker { get { return DataContext; } }

        public Context DataContext { get; private set; }

        protected void Save()
        {
            DataContext.SaveChanges();
        }

        public override bool CanLeave()
        {
            return true;
        }

        public override void Initialize(object parameter)
        {
        
        }
    }
}