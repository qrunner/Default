using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Invoice.App.Print
{
    public partial class xrInvoice : DevExpress.XtraReports.UI.XtraReport
    {
        public xrInvoice()
        {
            InitializeComponent();
        }

        private void DetailReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var x = sender;
        }
    }
}
