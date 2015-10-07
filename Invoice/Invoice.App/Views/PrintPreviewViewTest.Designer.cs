namespace Invoice.App.Views
{
    partial class PrintPreviewViewTest
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
            this.DocumentViewer = new DevExpress.XtraPrinting.Preview.DocumentViewer();            
            this.SuspendLayout();
            // 
            // DocumentViewer
            // 
            this.DocumentViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentViewer.IsMetric = true;
            this.DocumentViewer.Location = new System.Drawing.Point(0, 0);
            this.DocumentViewer.Name = "DocumentViewer";
            this.DocumentViewer.Size = new System.Drawing.Size(825, 384);
            this.DocumentViewer.TabIndex = 0;
            // 
            // PrintPreviewView
            // 
            this.Appearance.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DocumentViewer);
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "PrintPreviewView";
            this.Size = new System.Drawing.Size(825, 384);            
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraPrinting.Preview.DocumentViewer DocumentViewer;

    }
}
