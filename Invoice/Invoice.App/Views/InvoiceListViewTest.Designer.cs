namespace Invoice.App.Views
{
    partial class InvoiceListViewTest
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReason = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource
            // 
            this.bindingSource.DataMember = "Invoices";
            this.bindingSource.DataSource = typeof(Invoice.App.ViewModels.InvoiceListViewModel);
            this.bindingSource.CurrentChanged += new System.EventHandler(this.bindingSource_CurrentChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.bindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(488, 329);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDate,
            this.colProducer,
            this.colSupplier,
            this.colCustomer,
            this.colReason,
            this.colAmount,
            this.colId});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView1_FocusedRowObjectChanged);
                        // 
            // colDate
            // 
            this.colDate.DisplayFormat.FormatString = "d";
            this.colDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 1;
            this.colDate.Width = 72;
            // 
            // colProducer
            // 
            this.colProducer.FieldName = "Producer";
            this.colProducer.Name = "colProducer";
            this.colProducer.Visible = true;
            this.colProducer.VisibleIndex = 2;
            this.colProducer.Width = 72;
            // 
            // colSupplier
            // 
            this.colSupplier.FieldName = "Supplier";
            this.colSupplier.Name = "colSupplier";
            this.colSupplier.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colSupplier.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colSupplier.Visible = true;
            this.colSupplier.VisibleIndex = 3;
            this.colSupplier.Width = 72;
            // 
            // colCustomer
            // 
            this.colCustomer.FieldName = "Customer";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colCustomer.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colCustomer.Visible = true;
            this.colCustomer.VisibleIndex = 4;
            this.colCustomer.Width = 72;
            // 
            // colReason
            // 
            this.colReason.FieldName = "Reason";
            this.colReason.Name = "colReason";
            this.colReason.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colReason.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colReason.Visible = true;
            this.colReason.VisibleIndex = 5;
            this.colReason.Width = 72;
            // 
            // colAmount
            // 
            this.colAmount.DisplayFormat.FormatString = "c2";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.OptionsColumn.ReadOnly = true;
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 6;
            this.colAmount.Width = 80;
            // 
            // colId
            // 
            this.colId.Caption = "№";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 33;
            // 
            // InvoiceListViewTest
            // 
            this.Appearance.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "InvoiceListViewTest";
            this.Size = new System.Drawing.Size(488, 329);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colProducer;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colReason;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
    }
}
