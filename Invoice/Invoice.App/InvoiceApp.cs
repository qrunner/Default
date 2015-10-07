using DevExpress.XtraEditors;
using Invoice.Model;
using Invoice.ServiceLayer.MySql;
using NLog;
using System;
using System.Linq;
using System.Windows.Forms;
using Sirius.Desktop;

namespace Invoice.App
{
    static class InvoiceApp
    {
        private static readonly Logger Logger;

        static InvoiceApp()
        {            
            ModelContext = new Context("InvoiceContext");
            ServiceFactory = new ServiceFactory("InvoiceContext");            
            RouteManager = new RouteManager();
            Application.ThreadException += Application_ThreadException;
            Logger = LogManager.GetLogger("ThreadExceptionLogger");
        }

        public static RouteManager RouteManager { get; private set; }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Logger.Error(e.Exception.Message, e.Exception);
            XtraMessageBox.Show(MainForm, e.Exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void RegisterMainForm(frmMain form)
        {
            MainForm = form;
        }

        public static frmMain MainForm { get; private set; }
                
        /// <summary>
        /// Текущий контекст модели
        /// </summary>
        public static Context ModelContext { get; private set; }

        public static Context CreateModelContext() { return new Context("InvoiceContext"); }

        /// <summary>
        /// Фабрика сервисов
        /// </summary>
        public static ServiceFactory ServiceFactory { get; private set; }

        public static void LoadSettings()
        {
            var lastSupplierId = Properties.Settings.Default.LastSupplier;
            if (lastSupplierId > 0)
            {
                CurrentSupplier = ModelContext.Suppliers.Single(x => x.Id == lastSupplierId);
            }
        }

        public static void SaveSettings()
        {
            Properties.Settings.Default.LastSupplier = CurrentSupplier != null ? CurrentSupplier.Id : -1;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Выбранные накладные
        /// </summary>
        public static int[] SelectedInvoices { get; set; }

        private static Supplier _currentSupplier;

        /// <summary>
        /// Текущий продавец
        /// </summary>        
        public static Supplier CurrentSupplier
        {
            get { return _currentSupplier; }
            set
            {
                if (_currentSupplier != value)
                {
                    _currentSupplier = value;
                    RaiseCurrentSupplierChanged();
                }
            }
        }

        public static event EventHandler CurrentSupplierChanged;

        private static void RaiseCurrentSupplierChanged()
        {
            var evh = CurrentSupplierChanged;
            if (evh != null)
                CurrentSupplierChanged(null, EventArgs.Empty);
        }
    }
}