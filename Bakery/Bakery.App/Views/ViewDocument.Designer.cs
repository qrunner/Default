namespace Bakery.App.Views
{
    partial class ViewDocument
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.bsDocument = new System.Windows.Forms.BindingSource(this.components);
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.bsTypes = new System.Windows.Forms.BindingSource(this.components);
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.viewUnitEntries1 = new Bakery.App.Views.ViewUnitEntries();
            this.contractorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(789, 472);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tableLayoutPanel2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(783, 77);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Параметры документа";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.textEdit1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateEdit1, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl2, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelControl4, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lookUpEdit1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lookUpEdit2, 4, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(588, 54);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsDocument, "Number", true));
            this.textEdit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textEdit1.Location = new System.Drawing.Point(44, 3);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(222, 20);
            this.textEdit1.TabIndex = 0;
            // 
            // bsDocument
            // 
            this.bsDocument.DataSource = typeof(Bakery.Model.Document);
            // 
            // dateEdit1
            // 
            this.dateEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsDocument, "Date", true));
            this.dateEdit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(362, 3);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(223, 20);
            this.dateEdit1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Номер:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(292, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Дата:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(3, 29);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(22, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Тип:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(292, 29);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(64, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Контрагент:";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsDocument, "Type", true));
            this.lookUpEdit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lookUpEdit1.Location = new System.Drawing.Point(44, 29);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Наименование", 83, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit1.Properties.DataSource = this.bsTypes;
            this.lookUpEdit1.Properties.DisplayMember = "Name";
            this.lookUpEdit1.Size = new System.Drawing.Size(222, 20);
            this.lookUpEdit1.TabIndex = 6;
            // 
            // bsTypes
            // 
            this.bsTypes.DataSource = typeof(Bakery.Model.DocumentType);
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsDocument, "Contractor", true));
            this.lookUpEdit2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lookUpEdit2.Location = new System.Drawing.Point(362, 29);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.DataSource = this.contractorBindingSource;
            this.lookUpEdit2.Properties.DisplayMember = "Name";
            this.lookUpEdit2.Size = new System.Drawing.Size(223, 20);
            this.lookUpEdit2.TabIndex = 7;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.viewUnitEntries1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 86);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(783, 383);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Состав";
            // 
            // viewUnitEntries1
            // 
            this.viewUnitEntries1.Appearance.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewUnitEntries1.Appearance.Options.UseFont = true;
            this.viewUnitEntries1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewUnitEntries1.Editable = true;
            this.viewUnitEntries1.Location = new System.Drawing.Point(2, 21);
            this.viewUnitEntries1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewUnitEntries1.Name = "viewUnitEntries1";
            this.viewUnitEntries1.Size = new System.Drawing.Size(779, 360);
            this.viewUnitEntries1.TabIndex = 0;
            // 
            // contractorBindingSource
            // 
            this.contractorBindingSource.DataSource = typeof(Bakery.Model.Contractor);
            // 
            // ViewDocument
            // 
            this.Appearance.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ViewDocument";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contractorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private ViewUnitEntries viewUnitEntries1;
        private System.Windows.Forms.BindingSource bsDocument;
        private System.Windows.Forms.BindingSource bsTypes;
        private System.Windows.Forms.BindingSource contractorBindingSource;

    }
}
