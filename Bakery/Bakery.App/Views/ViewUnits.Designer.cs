namespace Bakery.App.Views
{
    partial class ViewUnits
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
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsUnitCategories = new System.Windows.Forms.BindingSource(this.components);
            this.colMeasureUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsRaw = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsMeasureUnits = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUnitCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasureUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Bakery.Model.Unit);
            // 
            // gridControl2
            // 
            this.gridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl2.DataSource = this.bindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2});
            this.gridControl2.Size = new System.Drawing.Size(789, 472);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colUnitCategory,
            this.colMeasureUnit,
            this.colIsProduct,
            this.colIsRaw});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // colUnitCategory
            // 
            this.colUnitCategory.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colUnitCategory.FieldName = "UnitCategory";
            this.colUnitCategory.Name = "colUnitCategory";
            this.colUnitCategory.Visible = true;
            this.colUnitCategory.VisibleIndex = 1;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Наименование", 83, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit1.DataSource = this.bsUnitCategories;
            this.repositoryItemLookUpEdit1.DisplayMember = "Name";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // bsUnitCategories
            // 
            this.bsUnitCategories.DataSource = typeof(Bakery.Model.UnitCategory);
            // 
            // colMeasureUnit
            // 
            this.colMeasureUnit.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colMeasureUnit.FieldName = "MeasureUnit";
            this.colMeasureUnit.Name = "colMeasureUnit";
            this.colMeasureUnit.Visible = true;
            this.colMeasureUnit.VisibleIndex = 2;
            // 
            // colIsProduct
            // 
            this.colIsProduct.FieldName = "IsProduct";
            this.colIsProduct.Name = "colIsProduct";
            this.colIsProduct.Visible = true;
            this.colIsProduct.VisibleIndex = 3;
            // 
            // colIsRaw
            // 
            this.colIsRaw.FieldName = "IsRaw";
            this.colIsRaw.Name = "colIsRaw";
            this.colIsRaw.Visible = true;
            this.colIsRaw.VisibleIndex = 4;
            // 
            // bsMeasureUnits
            // 
            this.bsMeasureUnits.DataSource = typeof(Bakery.Model.MeasureUnit);
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Наименование", 83, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit2.DataSource = this.bsMeasureUnits;
            this.repositoryItemLookUpEdit2.DisplayMember = "Name";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            // 
            // ViewUnits
            // 
            this.Appearance.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.Controls.Add(this.gridControl2);
            this.Name = "ViewUnits";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUnitCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasureUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colMeasureUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colIsProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colIsRaw;
        private System.Windows.Forms.BindingSource bsMeasureUnits;
        private System.Windows.Forms.BindingSource bsUnitCategories;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
    }
}
