using Sirius.Desktop;
using Sirius.Desktop.DevExpress;

namespace Invoice.App.Views
{
    public partial class PrintPreviewView : ViewBase
    {
        public PrintPreviewView()
        {
            InitializeComponent();
        }

        public override void SetModel(IViewModel model)
        {            
            DocumentViewer.DocumentSource = model;
        }
    }
}