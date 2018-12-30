namespace AplikasiNapi.View
{
    partial class FrmPetugas
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
            this.lvwPetugas = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCari3 = new System.Windows.Forms.TextBox();
            this.btnCari3 = new System.Windows.Forms.Button();
            this.btnTambah3 = new System.Windows.Forms.Button();
            this.btnPerbaiki3 = new System.Windows.Forms.Button();
            this.btnHapus3 = new System.Windows.Forms.Button();
            this.btnSimpan3 = new System.Windows.Forms.Button();
            this.btnBatal3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId3 = new System.Windows.Forms.TextBox();
            this.txtNama3 = new System.Windows.Forms.TextBox();
            this.txtJenisKelamin3 = new System.Windows.Forms.TextBox();
            this.txtTempat3 = new System.Windows.Forms.TextBox();
            this.txtNoTlp3 = new System.Windows.Forms.TextBox();
            this.txtAlamat3 = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTglLahir3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvwPetugas
            // 
            this.lvwPetugas.Location = new System.Drawing.Point(12, 47);
            this.lvwPetugas.Name = "lvwPetugas";
            this.lvwPetugas.Size = new System.Drawing.Size(1346, 282);
            this.lvwPetugas.TabIndex = 0;
            this.lvwPetugas.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cari Petugas";
            // 
            // txtCari3
            // 
            this.txtCari3.Location = new System.Drawing.Point(85, 12);
            this.txtCari3.Name = "txtCari3";
            this.txtCari3.Size = new System.Drawing.Size(260, 20);
            this.txtCari3.TabIndex = 2;
            // 
            // btnCari3
            // 
            this.btnCari3.Location = new System.Drawing.Point(364, 10);
            this.btnCari3.Name = "btnCari3";
            this.btnCari3.Size = new System.Drawing.Size(75, 23);
            this.btnCari3.TabIndex = 3;
            this.btnCari3.Text = "Cari";
            this.btnCari3.UseVisualStyleBackColor = true;
            this.btnCari3.Click += new System.EventHandler(this.btnCari3_Click);
            // 
            // btnTambah3
            // 
            this.btnTambah3.Location = new System.Drawing.Point(12, 336);
            this.btnTambah3.Name = "btnTambah3";
            this.btnTambah3.Size = new System.Drawing.Size(75, 23);
            this.btnTambah3.TabIndex = 4;
            this.btnTambah3.Text = "Tambah";
            this.btnTambah3.UseVisualStyleBackColor = true;
            this.btnTambah3.Click += new System.EventHandler(this.btnTambah3_Click);
            // 
            // btnPerbaiki3
            // 
            this.btnPerbaiki3.Location = new System.Drawing.Point(118, 336);
            this.btnPerbaiki3.Name = "btnPerbaiki3";
            this.btnPerbaiki3.Size = new System.Drawing.Size(75, 23);
            this.btnPerbaiki3.TabIndex = 5;
            this.btnPerbaiki3.Text = "Perbaiki";
            this.btnPerbaiki3.UseVisualStyleBackColor = true;
            this.btnPerbaiki3.Click += new System.EventHandler(this.btnPerbaiki3_Click);
            // 
            // btnHapus3
            // 
            this.btnHapus3.Location = new System.Drawing.Point(232, 336);
            this.btnHapus3.Name = "btnHapus3";
            this.btnHapus3.Size = new System.Drawing.Size(75, 23);
            this.btnHapus3.TabIndex = 6;
            this.btnHapus3.Text = "Hapus";
            this.btnHapus3.UseVisualStyleBackColor = true;
            this.btnHapus3.Click += new System.EventHandler(this.btnHapus3_Click);
            // 
            // btnSimpan3
            // 
            this.btnSimpan3.Location = new System.Drawing.Point(13, 526);
            this.btnSimpan3.Name = "btnSimpan3";
            this.btnSimpan3.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan3.TabIndex = 7;
            this.btnSimpan3.Text = "Simpan";
            this.btnSimpan3.UseVisualStyleBackColor = true;
            this.btnSimpan3.Click += new System.EventHandler(this.btnSimpan3_Click);
            // 
            // btnBatal3
            // 
            this.btnBatal3.Location = new System.Drawing.Point(118, 526);
            this.btnBatal3.Name = "btnBatal3";
            this.btnBatal3.Size = new System.Drawing.Size(75, 23);
            this.btnBatal3.TabIndex = 8;
            this.btnBatal3.Text = "Batal";
            this.btnBatal3.UseVisualStyleBackColor = true;
            this.btnBatal3.Click += new System.EventHandler(this.btnBatal3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Jenis Kelamin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tempat Lahir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 487);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tanggal Lahir";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(408, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Alamat";
            // 
            // txtId3
            // 
            this.txtId3.Location = new System.Drawing.Point(108, 380);
            this.txtId3.Name = "txtId3";
            this.txtId3.Size = new System.Drawing.Size(100, 20);
            this.txtId3.TabIndex = 15;
            // 
            // txtNama3
            // 
            this.txtNama3.Location = new System.Drawing.Point(108, 414);
            this.txtNama3.Name = "txtNama3";
            this.txtNama3.Size = new System.Drawing.Size(199, 20);
            this.txtNama3.TabIndex = 16;
            // 
            // txtJenisKelamin3
            // 
            this.txtJenisKelamin3.Location = new System.Drawing.Point(517, 380);
            this.txtJenisKelamin3.Name = "txtJenisKelamin3";
            this.txtJenisKelamin3.Size = new System.Drawing.Size(132, 20);
            this.txtJenisKelamin3.TabIndex = 17;
            // 
            // txtTempat3
            // 
            this.txtTempat3.Location = new System.Drawing.Point(108, 450);
            this.txtTempat3.Name = "txtTempat3";
            this.txtTempat3.Size = new System.Drawing.Size(100, 20);
            this.txtTempat3.TabIndex = 18;
            // 
            // txtNoTlp3
            // 
            this.txtNoTlp3.Location = new System.Drawing.Point(517, 487);
            this.txtNoTlp3.Name = "txtNoTlp3";
            this.txtNoTlp3.Size = new System.Drawing.Size(141, 20);
            this.txtNoTlp3.TabIndex = 19;
            // 
            // txtAlamat3
            // 
            this.txtAlamat3.Location = new System.Drawing.Point(517, 414);
            this.txtAlamat3.Name = "txtAlamat3";
            this.txtAlamat3.Size = new System.Drawing.Size(287, 54);
            this.txtAlamat3.TabIndex = 20;
            this.txtAlamat3.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(408, 487);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "No. Telepon";
            // 
            // txtTglLahir3
            // 
            this.txtTglLahir3.Location = new System.Drawing.Point(108, 484);
            this.txtTglLahir3.Name = "txtTglLahir3";
            this.txtTglLahir3.Size = new System.Drawing.Size(179, 20);
            this.txtTglLahir3.TabIndex = 22;
            // 
            // FrmPetugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.txtTglLahir3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAlamat3);
            this.Controls.Add(this.txtNoTlp3);
            this.Controls.Add(this.txtTempat3);
            this.Controls.Add(this.txtJenisKelamin3);
            this.Controls.Add(this.txtNama3);
            this.Controls.Add(this.txtId3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBatal3);
            this.Controls.Add(this.btnSimpan3);
            this.Controls.Add(this.btnHapus3);
            this.Controls.Add(this.btnPerbaiki3);
            this.Controls.Add(this.btnTambah3);
            this.Controls.Add(this.btnCari3);
            this.Controls.Add(this.txtCari3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwPetugas);
            this.Name = "FrmPetugas";
            this.Text = "Data Petugas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwPetugas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCari3;
        private System.Windows.Forms.Button btnCari3;
        private System.Windows.Forms.Button btnTambah3;
        private System.Windows.Forms.Button btnPerbaiki3;
        private System.Windows.Forms.Button btnHapus3;
        private System.Windows.Forms.Button btnSimpan3;
        private System.Windows.Forms.Button btnBatal3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId3;
        private System.Windows.Forms.TextBox txtNama3;
        private System.Windows.Forms.TextBox txtJenisKelamin3;
        private System.Windows.Forms.TextBox txtTempat3;
        private System.Windows.Forms.TextBox txtNoTlp3;
        private System.Windows.Forms.RichTextBox txtAlamat3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTglLahir3;
    }
}