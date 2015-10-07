using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraNavBar;
using Invoice.App.ViewModels.Filters;
using Invoice.Model;
using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using Sirius.Desktop;

namespace Invoice.App
{
    public partial class frmMain : RibbonForm, IViewContainer, ICommandsContainer
    {
        public frmMain()
        {
            InitializeComponent();
            Application.Idle += Application_Idle;
        }

        void Application_Idle(object sender, EventArgs e)
        {
            foreach (NavBarGroup group in navBarControl1.Groups)
                foreach (NavBarItemLink item in group.ItemLinks)
                    item.Item.Enabled = item.Item.Tag is ICommand ? (item.Item.Tag as ICommand).CanExecute(null) : true;

            btBack.Enabled = InvoiceApp.RouteManager.CanBack;
            btForward.Enabled = InvoiceApp.RouteManager.CanForward;

            btInvoices.Down = InvoiceApp.RouteManager.CurrentPath == Route.InvoiceList;
            btProducers.Down = InvoiceApp.RouteManager.CurrentPath == Route.RefProducers;
            btCustomers.Down = InvoiceApp.RouteManager.CurrentPath == Route.RefCustomers;
            btSuppliers.Down = InvoiceApp.RouteManager.CurrentPath == Route.RefSuppliers;
            btPacking.Down = InvoiceApp.RouteManager.CurrentPath == Route.RefPacking;
            btMeasureUnits.Down = InvoiceApp.RouteManager.CurrentPath == Route.RefMeasureUnits;
            btProducts.Down = InvoiceApp.RouteManager.CurrentPath == Route.RefProducts;            
        }

        private void toolStripDropDownButton1_DropDownOpening(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem item in (sender as ToolStripDropDownButton).DropDownItems)
                item.Click -= SelectSupplier_Click;

            (sender as ToolStripDropDownButton).DropDownItems.Clear();

            var context = InvoiceApp.ModelContext;

            foreach (var s in context.Suppliers)
            {
                var item = new ToolStripMenuItem(s.Name) { Tag = s };
                item.Checked = InvoiceApp.CurrentSupplier != null && s.Id == InvoiceApp.CurrentSupplier.Id;
                item.Click += SelectSupplier_Click;
                (sender as ToolStripDropDownButton).DropDownItems.Add(item);
            }
        }

        private void SelectSupplier_Click(object sender, EventArgs e)
        {
            InvoiceApp.CurrentSupplier = cbSupplier.EditValue as Supplier;
        }

        private void отчетыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            InvoiceApp.LoadSettings();
            if (InvoiceApp.CurrentSupplier != null)
                cbSupplier.EditValue = InvoiceApp.CurrentSupplier;

            InvoiceApp.RouteManager.RedirectToRoute(Route.InvoiceList, new { filter = new ThisWeek() });
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            InvoiceApp.SaveSettings();
        }

        private void продавцыToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // new NamedEntityController().List<Supplier>().ShowDocked(new frmChildBase() { MdiParent = this, Text = "Продавцы" });
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void покупателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new NamedEntityController().List<Customer>().ShowDocked(new frmChildBase() { MdiParent = this, Text = "Покупатели" });
        }

        private void тараToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new PackingController().List().ShowDocked(new frmChildBase() { MdiParent = this, Text = "Тара / Упаковка" });
        }

        private void единицыИзмеренияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new MeasureUnitController().List().ShowDocked(new frmChildBase() { MdiParent = this, Text = "Единицы измерения" });
        }

        private void продуктыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new ProductController().List().ShowDocked(new frmChildBase() { MdiParent = this, Text = "Продукты" });
        }

        /*internal T PlaceView<T>(T view) where T : Invoice.App.Core.IView
        {
            try
            {
                //splitContainerControl1.Panel2.BeginInit();
                if (splitContainerControl1.Panel2.HasChildren)
                {
                    splitContainerControl1.Panel2.Controls.Clear();
                    GC.Collect();
                }
                view.ShowDocked(splitContainerControl1.Panel2);
                return view;
            }
            finally
            {
                //    splitContainerControl1.Panel2.EndInit(); 
            }
        }*/

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InvoiceApp.RouteManager.RedirectToRoute(Route.RefProducers);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InvoiceApp.RouteManager.RedirectToRoute(Route.RefCustomers);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InvoiceApp.RouteManager.RedirectToRoute(Route.RefSuppliers);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InvoiceApp.RouteManager.RedirectToRoute(Route.RefPacking);
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InvoiceApp.RouteManager.RedirectToRoute(Route.RefMeasureUnits);
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InvoiceApp.RouteManager.RedirectToRoute(Route.RefProducts);
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InvoiceApp.RouteManager.RedirectToRoute(Route.InvoiceList, new { filter = new ThisWeek() });
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //PlaceView(new InvoiceController().Edit(0));
        }

        private void ribbonControl1_SelectedPageChanged(object sender, EventArgs e)
        {/*
            if (ribbonControl1.SelectedPage == pagePrint)
            {
                documentViewerRibbonController1.DocumentViewer =
                    (PlaceView(InvoiceApp.ControllerManager.Get<PrintController>().PrintPreview(InvoiceApp.SelectedInvoices)) as PrintPreviewView).DocumentViewer;
            }
           */
            if (ribbonControl1.SelectedPage == pageInvoice)
            {
                InvoiceApp.RouteManager.RedirectToRoute(Route.InvoiceList, new { filter = new ThisWeek() });
            }
        }

        private void cbSupplier_ShowingEditor(object sender, DevExpress.XtraBars.ItemCancelEventArgs e)
        {
            repositoryItemComboBox2.Items.Clear();
            InvoiceApp.ModelContext.Suppliers.Load();
            repositoryItemComboBox2.Items.AddRange(InvoiceApp.ModelContext.Suppliers.Local);
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ribbonControl1.SelectedPage = pagePrint;
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void repositoryItemComboBox2_QueryPopUp(object sender, CancelEventArgs e)
        {

        }

        private void repositoryItemComboBox2_Popup(object sender, EventArgs e)
        {

        }

        private void cbSupplier_ShownEditor(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        T IViewContainer.PlaceView<T>(T view)
        {
            if (splitContainerControl1.Panel2.HasChildren)
                splitContainerControl1.Panel2.Controls.Clear();

            var control = view as Control;
            splitContainerControl1.Panel2.Controls.Add(control);
            control.Dock = DockStyle.Fill;

            return view;
        }

        public void PlaceCommands(IViewModel model)
        {
            try
            {
                navBarControl1.BeginUpdate();

                foreach (NavBarItem item in navBarControl1.Items)
                {
                    item.LinkClicked -= item_LinkClicked;
                }

                navBarControl1.Items.Clear();
                navBarControl1.Groups.Clear();

                foreach (var command in model.UiCommands.OrderBy(x => x.Order))
                {
                    var item = new NavBarItem(command.Caption);
                    item.Tag = command;
                    item.LinkClicked += item_LinkClicked;

                    var group = navBarControl1.Groups.SingleOrDefault(x => x.Caption == command.Category);
                    if (group == null)
                    {
                        group = navBarControl1.Groups.Add();
                        group.Caption = command.Category;
                        group.Expanded = true;
                    }

                    group.ItemLinks.Add(item);
                }
            }
            finally
            {
                navBarControl1.EndUpdate();
            }
        }

        void item_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            (e.Link.Item.Tag as IUiCommand).Execute(null);
        }

        private void btBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InvoiceApp.RouteManager.MoveBack();
        }

        private void btForward_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InvoiceApp.RouteManager.MoveForward();
        }        
    }
}