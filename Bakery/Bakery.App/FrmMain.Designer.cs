namespace Bakery.App
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.тМЦToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eeeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сКЛАДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsContextCommands = new System.Windows.Forms.ToolStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тМЦToolStripMenuItem,
            this.сКЛАДToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1213, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // тМЦToolStripMenuItem
            // 
            this.тМЦToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eeeToolStripMenuItem});
            this.тМЦToolStripMenuItem.Name = "тМЦToolStripMenuItem";
            this.тМЦToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.тМЦToolStripMenuItem.Text = "ТМЦ";
            // 
            // eeeToolStripMenuItem
            // 
            this.eeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eeeeToolStripMenuItem});
            this.eeeToolStripMenuItem.Name = "eeeToolStripMenuItem";
            this.eeeToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.eeeToolStripMenuItem.Text = "eee";
            this.eeeToolStripMenuItem.Click += new System.EventHandler(this.eeeToolStripMenuItem_Click);
            // 
            // eeeeToolStripMenuItem
            // 
            this.eeeeToolStripMenuItem.Name = "eeeeToolStripMenuItem";
            this.eeeeToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.eeeeToolStripMenuItem.Text = "eeee";
            // 
            // сКЛАДToolStripMenuItem
            // 
            this.сКЛАДToolStripMenuItem.Name = "сКЛАДToolStripMenuItem";
            this.сКЛАДToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.сКЛАДToolStripMenuItem.Text = "СКЛАД";
            // 
            // tsContextCommands
            // 
            this.tsContextCommands.Location = new System.Drawing.Point(0, 24);
            this.tsContextCommands.Name = "tsContextCommands";
            this.tsContextCommands.Size = new System.Drawing.Size(1213, 25);
            this.tsContextCommands.TabIndex = 3;
            this.tsContextCommands.Text = "toolStrip1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 654);
            this.Controls.Add(this.tsContextCommands);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Пекарня";
            this.MdiChildActivate += new System.EventHandler(this.FrmMain_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сКЛАДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тМЦToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eeeeToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tsContextCommands;
    }
}

