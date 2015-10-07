namespace Invoice.App.Views
{
    partial class AnalyseView
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
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fieldDate1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProducer1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSupplier1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCustomer1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldReason1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldItems1 = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.bindingSource1;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldDate1,
            this.fieldProducer1,
            this.fieldSupplier1,
            this.fieldCustomer1,
            this.fieldReason1,
            this.fieldItems1});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(437, 311);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Invoice.Model.Invoice);
            // 
            // fieldDate1
            // 
            this.fieldDate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldDate1.AreaIndex = 0;
            this.fieldDate1.Caption = "Date";
            this.fieldDate1.FieldName = "Date";
            this.fieldDate1.Name = "fieldDate1";
            // 
            // fieldProducer1
            // 
            this.fieldProducer1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldProducer1.AreaIndex = 0;
            this.fieldProducer1.Caption = "Producer";
            this.fieldProducer1.FieldName = "Producer";
            this.fieldProducer1.Name = "fieldProducer1";
            // 
            // fieldSupplier1
            // 
            this.fieldSupplier1.AreaIndex = 0;
            this.fieldSupplier1.Caption = "Supplier";
            this.fieldSupplier1.FieldName = "Supplier";
            this.fieldSupplier1.Name = "fieldSupplier1";
            // 
            // fieldCustomer1
            // 
            this.fieldCustomer1.AreaIndex = 1;
            this.fieldCustomer1.Caption = "Customer";
            this.fieldCustomer1.FieldName = "Customer";
            this.fieldCustomer1.Name = "fieldCustomer1";
            // 
            // fieldReason1
            // 
            this.fieldReason1.AreaIndex = 2;
            this.fieldReason1.Caption = "Reason";
            this.fieldReason1.FieldName = "Reason";
            this.fieldReason1.Name = "fieldReason1";
            // 
            // fieldItems1
            // 
            this.fieldItems1.AreaIndex = 3;
            this.fieldItems1.Caption = "Items";
            this.fieldItems1.FieldName = "Items";
            this.fieldItems1.Name = "fieldItems1";
            // 
            // AnalyseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "AnalyseView";
            this.Size = new System.Drawing.Size(437, 311);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDate1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProducer1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSupplier1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCustomer1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldReason1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldItems1;
    }
}
