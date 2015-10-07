using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoice.App.ViewModels;
using Invoice.Model;

namespace Invoice.App.Views
{
    public partial class ProductEditor : GridEditor
    {
        public ProductEditor()
        {
            InitializeComponent();
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView GridView
        {
            get { return gridView1; }
        }
    }
}