using DevExpress.XtraEditors;
using Invoice.App.ViewModels;
using Sirius.Desktop;

namespace Invoice.App.Views
{
    public partial class PrintPreviewViewTest : XtraUserControl, IView
    {
        public PrintPreviewViewTest()
        {
            InitializeComponent();
        }

        public void SetModel(IViewModel model)
        {            
            DocumentViewer.DocumentSource = (model as IPrintPreviewViewModel).DocumentSource;            
        }
    }
}