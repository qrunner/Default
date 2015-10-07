namespace Bakery.App.Views
{
    partial class ViewLayout
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
            this.container = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.container)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(5, 5);
            this.container.Margin = new System.Windows.Forms.Padding(0);
            this.container.Name = "container";
            this.container.Padding = new System.Windows.Forms.Padding(10);
            this.container.Size = new System.Drawing.Size(696, 357);
            this.container.TabIndex = 3;
            // 
            // ViewLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 367);
            this.Controls.Add(this.container);
            this.Name = "ViewLayout";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fChild";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewLayout_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.container)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl container;
    }
}