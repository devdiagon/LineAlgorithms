namespace Tarea1P2
{
    partial class FrmHome
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
            this.mnsNav = new System.Windows.Forms.MenuStrip();
            this.dDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bresenhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuloBresenhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floodFillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlWrapper = new System.Windows.Forms.Panel();
            this.mnsNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsNav
            // 
            this.mnsNav.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsNav.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dDAToolStripMenuItem,
            this.bresenhamToolStripMenuItem,
            this.circuloBresenhamToolStripMenuItem,
            this.floodFillToolStripMenuItem});
            this.mnsNav.Location = new System.Drawing.Point(0, 0);
            this.mnsNav.Name = "mnsNav";
            this.mnsNav.Size = new System.Drawing.Size(1102, 76);
            this.mnsNav.TabIndex = 0;
            this.mnsNav.Text = "menuStrip1";
            // 
            // dDAToolStripMenuItem
            // 
            this.dDAToolStripMenuItem.Name = "dDAToolStripMenuItem";
            this.dDAToolStripMenuItem.Size = new System.Drawing.Size(86, 72);
            this.dDAToolStripMenuItem.Text = "DDA";
            this.dDAToolStripMenuItem.Click += new System.EventHandler(this.dDAToolStripMenuItem_Click);
            // 
            // bresenhamToolStripMenuItem
            // 
            this.bresenhamToolStripMenuItem.Name = "bresenhamToolStripMenuItem";
            this.bresenhamToolStripMenuItem.Size = new System.Drawing.Size(150, 72);
            this.bresenhamToolStripMenuItem.Text = "Bresenham";
            this.bresenhamToolStripMenuItem.Click += new System.EventHandler(this.bresenhamToolStripMenuItem_Click);
            // 
            // circuloBresenhamToolStripMenuItem
            // 
            this.circuloBresenhamToolStripMenuItem.Name = "circuloBresenhamToolStripMenuItem";
            this.circuloBresenhamToolStripMenuItem.Size = new System.Drawing.Size(218, 72);
            this.circuloBresenhamToolStripMenuItem.Text = "Circulo Bresenham";
            this.circuloBresenhamToolStripMenuItem.Click += new System.EventHandler(this.circuloBresenhamToolStripMenuItem_Click);
            // 
            // floodFillToolStripMenuItem
            // 
            this.floodFillToolStripMenuItem.Name = "floodFillToolStripMenuItem";
            this.floodFillToolStripMenuItem.Size = new System.Drawing.Size(122, 72);
            this.floodFillToolStripMenuItem.Text = "Flood Fill";
            // 
            // pnlWrapper
            // 
            this.pnlWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWrapper.Location = new System.Drawing.Point(0, 76);
            this.pnlWrapper.Name = "pnlWrapper";
            this.pnlWrapper.Size = new System.Drawing.Size(1102, 563);
            this.pnlWrapper.TabIndex = 1;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 639);
            this.Controls.Add(this.pnlWrapper);
            this.Controls.Add(this.mnsNav);
            this.MainMenuStrip = this.mnsNav;
            this.Name = "FrmHome";
            this.Text = "FrmHome";
            this.mnsNav.ResumeLayout(false);
            this.mnsNav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsNav;
        private System.Windows.Forms.ToolStripMenuItem dDAToolStripMenuItem;
        private System.Windows.Forms.Panel pnlWrapper;
        private System.Windows.Forms.ToolStripMenuItem bresenhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circuloBresenhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floodFillToolStripMenuItem;
    }
}