namespace AplikasiNapi.View
{
    partial class FrmUtama
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
            this.mnNarapidana = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTamu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPetugas = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pengaturanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnKeluar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnNarapidana,
            this.mnTamu,
            this.mnPetugas,
            this.pengaturanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnNarapidana
            // 
            this.mnNarapidana.Name = "mnNarapidana";
            this.mnNarapidana.Size = new System.Drawing.Size(80, 20);
            this.mnNarapidana.Text = "Narapidana";
            this.mnNarapidana.Click += new System.EventHandler(this.mnNarapidana_Click);
            // 
            // mnTamu
            // 
            this.mnTamu.Name = "mnTamu";
            this.mnTamu.Size = new System.Drawing.Size(49, 20);
            this.mnTamu.Text = "Tamu";
            this.mnTamu.Click += new System.EventHandler(this.mnTamu_Click);
            // 
            // mnPetugas
            // 
            this.mnPetugas.Name = "mnPetugas";
            this.mnPetugas.Size = new System.Drawing.Size(61, 20);
            this.mnPetugas.Text = "Petugas";
            this.mnPetugas.Click += new System.EventHandler(this.mnPetugas_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pengaturanToolStripMenuItem
            // 
            this.pengaturanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnKeluar});
            this.pengaturanToolStripMenuItem.Name = "pengaturanToolStripMenuItem";
            this.pengaturanToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.pengaturanToolStripMenuItem.Text = "Pengaturan";
            // 
            // mnKeluar
            // 
            this.mnKeluar.Name = "mnKeluar";
            this.mnKeluar.Size = new System.Drawing.Size(180, 22);
            this.mnKeluar.Text = "Keluar";
            this.mnKeluar.Click += new System.EventHandler(this.mnKeluar_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(350, 17);
            this.toolStripStatusLabel1.Text = "Copyrights © 2018 Aplikasi Arsip Narapidana. All rights reserved. ";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // FrmUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmUtama";
            this.Text = "Apilkasi Narapidana";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnNarapidana;
        private System.Windows.Forms.ToolStripMenuItem mnTamu;
        private System.Windows.Forms.ToolStripMenuItem mnPetugas;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem pengaturanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnKeluar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}