namespace Invoice.App.Views
{
    partial class InvoiceEditor
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
            this.components = new System.ComponentModel.Container();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbReason = new DevExpress.XtraEditors.TextEdit();
            this.bsInvoice = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.deDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tbId = new DevExpress.XtraEditors.TextEdit();
            this.cbProducer = new DevExpress.XtraEditors.LookUpEdit();
            this.producersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cbSupplier = new DevExpress.XtraEditors.LookUpEdit();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cbProduct = new DevExpress.XtraEditors.LookUpEdit();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbPacking = new DevExpress.XtraEditors.LookUpEdit();
            this.packingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.tbCount = new DevExpress.XtraEditors.SpinEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colPacking = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbReason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProducer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPacking.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource
            // 
            this.bindingSource.AllowNew = false;
            this.bindingSource.DataSource = typeof(Invoice.App.ViewModels.InvoiceViewModel);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tableLayoutPanel1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Padding = new System.Windows.Forms.Padding(3);
            this.groupControl1.Size = new System.Drawing.Size(729, 112);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Накладная";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tbReason, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelControl6, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelControl2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.deDate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbId, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbProducer, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbCustomer, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbSupplier, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelControl3, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(719, 83);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbReason
            // 
            this.tbReason.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsInvoice, "Reason", true));
            this.tbReason.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbReason.Location = new System.Drawing.Point(436, 55);
            this.tbReason.Name = "tbReason";
            this.tbReason.Size = new System.Drawing.Size(280, 20);
            this.tbReason.TabIndex = 5;
            // 
            // bsInvoice
            // 
            this.bsInvoice.DataSource = typeof(Invoice.Model.Invoice);
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl6.Location = new System.Drawing.Point(369, 58);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Основание:";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl2.Location = new System.Drawing.Point(3, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Дата:";
            // 
            // deDate
            // 
            this.deDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsInvoice, "Date", true));
            this.deDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.deDate.EditValue = null;
            this.deDate.Location = new System.Drawing.Point(63, 3);
            this.deDate.Name = "deDate";
            this.deDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDate.Size = new System.Drawing.Size(280, 20);
            this.deDate.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl1.Location = new System.Drawing.Point(369, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Номер:";
            // 
            // tbId
            // 
            this.tbId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsInvoice, "Id", true));
            this.tbId.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbId.Location = new System.Drawing.Point(436, 3);
            this.tbId.Name = "tbId";
            this.tbId.Properties.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(280, 20);
            this.tbId.TabIndex = 0;
            this.tbId.TabStop = false;
            // 
            // cbProducer
            // 
            this.cbProducer.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsInvoice, "Producer", true));
            this.cbProducer.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbProducer.EditValue = 0;
            this.cbProducer.Location = new System.Drawing.Point(436, 29);
            this.cbProducer.Name = "cbProducer";
            this.cbProducer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbProducer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Наименование", 96, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cbProducer.Properties.DataSource = this.producersBindingSource;
            this.cbProducer.Size = new System.Drawing.Size(280, 20);
            this.cbProducer.TabIndex = 4;
            // 
            // producersBindingSource
            // 
            this.producersBindingSource.DataMember = "Producers";
            this.producersBindingSource.DataSource = this.bindingSource;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl4.Location = new System.Drawing.Point(3, 32);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Клиент:";
            // 
            // cbCustomer
            // 
            this.cbCustomer.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsInvoice, "Customer", true));
            this.cbCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbCustomer.Location = new System.Drawing.Point(63, 29);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbCustomer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Наименование", 96, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cbCustomer.Properties.DataSource = this.customersBindingSource;
            this.cbCustomer.Properties.DisplayMember = "Name";
            this.cbCustomer.Size = new System.Drawing.Size(280, 20);
            this.cbCustomer.TabIndex = 2;
            this.cbCustomer.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.cbCustomer_EditValueChanging);
            this.cbCustomer.Validating += new System.ComponentModel.CancelEventHandler(this.cbCustomer_Validating);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.bindingSource;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl5.Location = new System.Drawing.Point(3, 58);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Продавец:";
            // 
            // cbSupplier
            // 
            this.cbSupplier.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsInvoice, "Supplier", true));
            this.cbSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbSupplier.Location = new System.Drawing.Point(63, 55);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbSupplier.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Наименование", 96, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cbSupplier.Properties.DataSource = this.suppliersBindingSource;
            this.cbSupplier.Properties.ReadOnly = true;
            this.cbSupplier.Size = new System.Drawing.Size(280, 20);
            this.cbSupplier.TabIndex = 3;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.bindingSource;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelControl3.Location = new System.Drawing.Point(369, 32);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Поставщик:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.tableLayoutPanel2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 112);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Padding = new System.Windows.Forms.Padding(3);
            this.groupControl2.Size = new System.Drawing.Size(729, 127);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Позиция";
            this.groupControl2.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.labelControl7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButton1, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelControl8, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbProduct, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbPacking, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelControl9, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbCount, 4, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(719, 98);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(3, 3);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(34, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Товар:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(626, 66);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(90, 23);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Добавить";
            this.simpleButton1.Click += new System.EventHandler(this.AddItemClick);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(249, 3);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(61, 13);
            this.labelControl8.TabIndex = 3;
            this.labelControl8.Text = "В упаковке:";
            // 
            // cbProduct
            // 
            this.cbProduct.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemsBindingSource, "Product", true));
            this.cbProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbProduct.Location = new System.Drawing.Point(3, 22);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbProduct.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Наименование", 83, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Цена", 49, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
            this.cbProduct.Properties.DataSource = this.productsBindingSource;
            this.cbProduct.Properties.DisplayMember = "Name";
            this.cbProduct.Properties.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.cbProduct_Properties_Closed);
            this.cbProduct.Size = new System.Drawing.Size(220, 20);
            this.cbProduct.TabIndex = 1;
            this.cbProduct.ToolTip = "Выберите товар из списка";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.bsInvoice;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.bindingSource;
            // 
            // cbPacking
            // 
            this.cbPacking.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemsBindingSource, "Packing", true));
            this.cbPacking.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbPacking.Location = new System.Drawing.Point(249, 22);
            this.cbPacking.Name = "cbPacking";
            this.cbPacking.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cbPacking.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPacking.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Описание", 72, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cbPacking.Properties.DataSource = this.packingsBindingSource;
            this.cbPacking.Properties.DisplayMember = "Description";
            this.cbPacking.Properties.ImmediatePopup = true;
            this.cbPacking.Size = new System.Drawing.Size(220, 20);
            this.cbPacking.TabIndex = 2;
            this.cbPacking.ToolTip = "Выберите упаковку из списка. Если требуется убрать упаковку - нажмите Ctrl + Del";
            this.cbPacking.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.cbPacking_Closed);
            // 
            // packingsBindingSource
            // 
            this.packingsBindingSource.DataMember = "Packings";
            this.packingsBindingSource.DataSource = this.bindingSource;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(495, 3);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(64, 13);
            this.labelControl9.TabIndex = 5;
            this.labelControl9.Text = "Количество:";
            // 
            // tbCount
            // 
            this.tbCount.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemsBindingSource, "Count", true));
            this.tbCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbCount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tbCount.Location = new System.Drawing.Point(495, 22);
            this.tbCount.Name = "tbCount";
            this.tbCount.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.tbCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tbCount.Properties.IsFloatValue = false;
            this.tbCount.Properties.Mask.EditMask = "N00";
            this.tbCount.Properties.ShowNullValuePromptWhenFocused = true;
            this.tbCount.Size = new System.Drawing.Size(221, 20);
            this.tbCount.TabIndex = 3;
            this.tbCount.ToolTip = "Укажите количество. Усли упаковка выбрана - указывается количество упаковок. Если" +
    " нет - количество единиц товара.";
            this.tbCount.Click += new System.EventHandler(this.tbCount_Enter);
            this.tbCount.Enter += new System.EventHandler(this.tbCount_Enter);
            this.tbCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCount_KeyDown);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.itemsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 239);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2});
            this.gridControl1.Size = new System.Drawing.Size(729, 250);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.TabStop = false;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProduct,
            this.colPacking,
            this.colCount,
            this.colAmount});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Введите новую позицию";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colProduct
            // 
            this.colProduct.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colProduct.FieldName = "Product";
            this.colProduct.Name = "colProduct";
            this.colProduct.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Product", "Позиций: {0} ")});
            this.colProduct.Visible = true;
            this.colProduct.VisibleIndex = 0;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Наименование", 83, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Цена", 49, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
            this.repositoryItemLookUpEdit1.DataSource = this.productsBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "Name";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // colPacking
            // 
            this.colPacking.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colPacking.FieldName = "Packing";
            this.colPacking.Name = "colPacking";
            this.colPacking.Visible = true;
            this.colPacking.VisibleIndex = 1;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Описание", 72, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit2.DataSource = this.packingsBindingSource;
            this.repositoryItemLookUpEdit2.DisplayMember = "Description";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            // 
            // colCount
            // 
            this.colCount.FieldName = "Count";
            this.colCount.Name = "colCount";
            this.colCount.Visible = true;
            this.colCount.VisibleIndex = 2;
            // 
            // colAmount
            // 
            this.colAmount.DisplayFormat.FormatString = "c2";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.OptionsColumn.ReadOnly = true;
            this.colAmount.OptionsColumn.TabStop = false;
            this.colAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "На сумму: {0:c2}")});
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 3;
            // 
            // InvoiceEditor
            // 
            this.Appearance.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "InvoiceEditor";
            this.Size = new System.Drawing.Size(729, 489);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbReason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProducer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPacking.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.TextEdit tbId;
        private DevExpress.XtraEditors.DateEdit deDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit cbProducer;
        private DevExpress.XtraEditors.LookUpEdit cbCustomer;
        private DevExpress.XtraEditors.LookUpEdit cbSupplier;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit tbReason;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colPacking;
        private DevExpress.XtraGrid.Columns.GridColumn colCount;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit cbProduct;
        private DevExpress.XtraEditors.LookUpEdit cbPacking;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SpinEdit tbCount;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.BindingSource producersBindingSource;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.BindingSource packingsBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private System.Windows.Forms.BindingSource bsInvoice;
    }
}
