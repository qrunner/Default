namespace Invoice.App.Views
{
    partial class InvoiceEditorView
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
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label idLabel;
            this.invoiceViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.idSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            dateLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idSpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceViewModelBindingSource
            // 
            this.invoiceViewModelBindingSource.DataSource = typeof(Invoice.App.ViewModels.InvoiceViewModel);
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(33, 24);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(37, 13);
            dateLabel.TabIndex = 1;
            dateLabel.Text = "Дата:";
            // 
            // dateDateEdit
            // 
            this.dateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.invoiceViewModelBindingSource, "Invoice.Date", true));
            this.dateDateEdit.EditValue = null;
            this.dateDateEdit.Location = new System.Drawing.Point(76, 21);
            this.dateDateEdit.Name = "dateDateEdit";
            this.dateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDateEdit.Size = new System.Drawing.Size(100, 20);
            this.dateDateEdit.TabIndex = 2;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(49, 50);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 13);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // idSpinEdit
            // 
            this.idSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.invoiceViewModelBindingSource, "Invoice.Id", true));
            this.idSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.idSpinEdit.Location = new System.Drawing.Point(76, 47);
            this.idSpinEdit.Name = "idSpinEdit";
            this.idSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.idSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.idSpinEdit.TabIndex = 3;
            // 
            // InvoiceEditorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idSpinEdit);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateEdit);
            this.Name = "InvoiceEditorView";
            this.Size = new System.Drawing.Size(320, 166);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idSpinEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource invoiceViewModelBindingSource;
        private DevExpress.XtraEditors.DateEdit dateDateEdit;
        private DevExpress.XtraEditors.SpinEdit idSpinEdit;
    }
}
