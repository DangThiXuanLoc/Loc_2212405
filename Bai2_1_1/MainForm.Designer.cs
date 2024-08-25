namespace Bai2_1_1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.họTênCủaSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmlBai1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmlBai2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmlBai3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBai4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 48);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 24);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.họTênCủaSinhViênToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(800, 24);
            this.menuStrip3.TabIndex = 2;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // họTênCủaSinhViênToolStripMenuItem
            // 
            this.họTênCủaSinhViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmlBai1,
            this.tsmlBai2,
            this.tsmlBai3,
            this.tsmiBai4});
            this.họTênCủaSinhViênToolStripMenuItem.Name = "họTênCủaSinhViênToolStripMenuItem";
            this.họTênCủaSinhViênToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.họTênCủaSinhViênToolStripMenuItem.Text = "Họ tên của sinh viên";
            // 
            // tsmlBai1
            // 
            this.tsmlBai1.Image = ((System.Drawing.Image)(resources.GetObject("tsmlBai1.Image")));
            this.tsmlBai1.Name = "tsmlBai1";
            this.tsmlBai1.Size = new System.Drawing.Size(180, 22);
            this.tsmlBai1.Text = "Bài 1";
            this.tsmlBai1.Click += new System.EventHandler(this.tsmlBai1_Click);
            // 
            // tsmlBai2
            // 
            this.tsmlBai2.Image = ((System.Drawing.Image)(resources.GetObject("tsmlBai2.Image")));
            this.tsmlBai2.Name = "tsmlBai2";
            this.tsmlBai2.Size = new System.Drawing.Size(180, 22);
            this.tsmlBai2.Text = "Bài 2";
            this.tsmlBai2.Click += new System.EventHandler(this.tsmlBai2_Click);
            // 
            // tsmlBai3
            // 
            this.tsmlBai3.Image = ((System.Drawing.Image)(resources.GetObject("tsmlBai3.Image")));
            this.tsmlBai3.Name = "tsmlBai3";
            this.tsmlBai3.Size = new System.Drawing.Size(180, 22);
            this.tsmlBai3.Text = "Bài 3";
            this.tsmlBai3.Click += new System.EventHandler(this.tsmlBai3_Click);
            // 
            // tsmiBai4
            // 
            this.tsmiBai4.Name = "tsmiBai4";
            this.tsmiBai4.Size = new System.Drawing.Size(180, 22);
            this.tsmiBai4.Text = "Bài 4";
            this.tsmiBai4.Click += new System.EventHandler(this.tsmiBai4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Chương trình chính";
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem họTênCủaSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmlBai1;
        private System.Windows.Forms.ToolStripMenuItem tsmlBai2;
        private System.Windows.Forms.ToolStripMenuItem tsmlBai3;
        private System.Windows.Forms.ToolStripMenuItem tsmiBai4;
    }
}

