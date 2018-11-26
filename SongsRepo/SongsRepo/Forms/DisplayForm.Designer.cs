namespace SongsRepo.Forms
{
    partial class DisplayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.scrollDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scrollUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyBindingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDefaultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scrollDownToolStripMenuItem,
            this.scrollUpToolStripMenuItem,
            this.playSongToolStripMenuItem,
            this.keyBindingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // scrollDownToolStripMenuItem
            // 
            this.scrollDownToolStripMenuItem.Name = "scrollDownToolStripMenuItem";
            this.scrollDownToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.scrollDownToolStripMenuItem.Text = "Scroll down";
            this.scrollDownToolStripMenuItem.Click += new System.EventHandler(this.scrollDownToolStripMenuItem_Click);
            // 
            // scrollUpToolStripMenuItem
            // 
            this.scrollUpToolStripMenuItem.Name = "scrollUpToolStripMenuItem";
            this.scrollUpToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.scrollUpToolStripMenuItem.Text = "Scroll up";
            this.scrollUpToolStripMenuItem.Click += new System.EventHandler(this.scrollUpToolStripMenuItem_Click);
            // 
            // playSongToolStripMenuItem
            // 
            this.playSongToolStripMenuItem.Name = "playSongToolStripMenuItem";
            this.playSongToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.playSongToolStripMenuItem.Text = "Play song";
            this.playSongToolStripMenuItem.Click += new System.EventHandler(this.playSongToolStripMenuItem_Click);
            // 
            // keyBindingsToolStripMenuItem
            // 
            this.keyBindingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDefaultsToolStripMenuItem});
            this.keyBindingsToolStripMenuItem.Name = "keyBindingsToolStripMenuItem";
            this.keyBindingsToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.keyBindingsToolStripMenuItem.Text = "Key bindings...";
            // 
            // viewDefaultsToolStripMenuItem
            // 
            this.viewDefaultsToolStripMenuItem.Name = "viewDefaultsToolStripMenuItem";
            this.viewDefaultsToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.viewDefaultsToolStripMenuItem.Text = "View defaults";
            this.viewDefaultsToolStripMenuItem.Click += new System.EventHandler(this.viewDefaultsToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.axAcroPDF1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 422);
            this.splitContainer1.SplitterDistance = 396;
            this.splitContainer1.TabIndex = 1;
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(0, 0);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(396, 422);
            this.axAcroPDF1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(400, 422);
            this.textBox1.TabIndex = 0;
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DisplayForm";
            this.Text = "DisplayForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DisplayForm_FormClosed);
            this.Load += new System.EventHandler(this.DisplayForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DisplayForm_KeyDown_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem scrollDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scrollUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyBindingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDefaultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playSongToolStripMenuItem;
    }
}