using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AplikasiNapi.Controller;
using AplikasiNapi.Model.Entity;

namespace AplikasiNapi.View
{
    public partial class FrmPetugas : Form
    {
        // deklarasi objek controller
        private PetugasController _controller;

        // deklarasi private variabel/field _addData
        private bool _addData;


        public FrmPetugas()
        {

            InitializeComponent();
            InisialisasiListView();

            // membuat objek controller
            _controller = new PetugasController();


            // tampilkan data mahasiwa
            LoadDataPetugas();

            // atur ulang posisi tombol Simpan dan Batal
            // disamakan dg posisi tombol Tambah dan Perbaiki
            //btnSimpan3.Location = btnTambah3.Location;
            //btnBatal3.Location = btnPerbaiki3.Location;
        }
        private void LoadDataPetugas()
        {
            // kosongkan data listview Petugas
            lvwPetugas.Items.Clear();

            // panggil method GetAll untuk mendapatkan semua data Petugas
            var list = _controller.GetAll();

            // lakukan perulangan untuk menampilkan data Petugas ke listview
            foreach (var petugas in list)
            {
                var noUrut = lvwPetugas.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(petugas.id_petugas);
                item.SubItems.Add(petugas.nama_petugas);
                item.SubItems.Add(petugas.jeniskelamin_petugas);
                item.SubItems.Add(petugas.tempatlahir_petugas);
                item.SubItems.Add(petugas.tanggallahir_petugas);
                item.SubItems.Add(petugas.alamat_petugas);
                item.SubItems.Add(petugas.notlp_petugas);

                lvwPetugas.Items.Add(item);
            }
        }

        // format kolom listview
        private void InisialisasiListView()
        {
            lvwPetugas.View = System.Windows.Forms.View.Details;
            lvwPetugas.FullRowSelect = true;
            lvwPetugas.GridLines = true;

            lvwPetugas.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwPetugas.Columns.Add("ID", 30, HorizontalAlignment.Center);
            lvwPetugas.Columns.Add("Nama", 200, HorizontalAlignment.Left);
            lvwPetugas.Columns.Add("Jenis Kelamin", 140, HorizontalAlignment.Left);
            lvwPetugas.Columns.Add("Tempat Lahir", 120, HorizontalAlignment.Left);
            lvwPetugas.Columns.Add("Tanggal Lahir", 100, HorizontalAlignment.Left);
            lvwPetugas.Columns.Add("Alamat", 250, HorizontalAlignment.Left);
            lvwPetugas.Columns.Add("No. Telepon", 150, HorizontalAlignment.Left);


        }

        private void btnTambah3_Click(object sender, EventArgs e)
        {
            // status untuk operasi tambah atau perbaiki
            _addData = true; // operasi tambah data baru

            // kosongkan isian npm, nama dan alamat
            txtId3.Clear();
            txtNama3.Clear();
            txtJenisKelamin3.Clear();
            txtTempat3.Clear();
            txtTglLahir3.Clear();
            txtAlamat3.Clear();
            txtNoTlp3.Clear();

            // fokus ke textbox npm
            txtId3.Focus();

            // sembunyikan btnTambah, btnPerbaiki dan btnHapus
            btnTambah3.Visible = false;
            btnPerbaiki3.Visible = false;
            btnHapus3.Visible = false;

            // tampilkan btnSimpan dan btnBatal
            btnSimpan3.Visible = true;
            btnBatal3.Visible = true;
        }

        private void btnSimpan3_Click(object sender, EventArgs e)
        {
            // membuat objek dari class Petugas
            var petugas = new Petugas();

            // set nilai property objek Petugas
            petugas.id_petugas = txtId3.Text;
            petugas.nama_petugas = txtNama3.Text;
            petugas.jeniskelamin_petugas = txtJenisKelamin3.Text;
            petugas.tempatlahir_petugas = txtTempat3.Text;
            petugas.tanggallahir_petugas = txtTglLahir3.Text;
            petugas.alamat_petugas = txtAlamat3.Text;
            petugas.notlp_petugas = txtNoTlp3.Text;

            var result = 0;

            if (_addData == true) // tambah data baru, panggil method Save
                result = _controller.Save(petugas);
            else // edit data, panggil method Update
                result = _controller.Update(petugas);

            if (result > 0) // tambah/edit data berhasil
            {
                // reset inputan dta
                txtId3.Clear();
                txtNama3.Clear();
                txtJenisKelamin3.Clear();
                txtTempat3.Clear();
                txtTglLahir3.Clear();
                txtAlamat3.Clear();
                txtNoTlp3.Clear();

                txtId3.Focus();

                // tampilkan kembali tombol tambah, perbaiki dan hapus
                btnTambah3.Visible = true;
                btnPerbaiki3.Visible = true;
                btnHapus3.Visible = true;

                // sembunyikan tombol simpan dan batal
                btnSimpan3.Visible = false;
                btnBatal3.Visible = false;

                // refresh data yang ditampilkan
                LoadDataPetugas();
            }
        }

        private void btnPerbaiki3_Click(object sender, EventArgs e)
        {
            // cek apakah data Petugas sudah dipilih
            if (lvwPetugas.SelectedItems.Count > 0)
            {
                _addData = false;

                // ambil index listview yang di pilih
                var index = lvwPetugas.SelectedIndices[0];

                var item = lvwPetugas.Items[index];
                txtId3.Text = item.SubItems[1].Text;
                txtNama3.Text = item.SubItems[2].Text;
                txtJenisKelamin3.Text = item.SubItems[3].Text;
                txtTempat3.Text = item.SubItems[4].Text;
                txtTglLahir3.Text = item.SubItems[5].Text;
                txtAlamat3.Text = item.SubItems[6].Text;
                txtNoTlp3.Text = item.SubItems[7].Text;

                // fokus ke textbox npm
                txtId3.Focus();

                // sembunyikan tombol tambah, perbaiki dan hapus
                btnTambah3.Visible = false;
                btnPerbaiki3.Visible = false;
                btnHapus3.Visible = false;

                // tampilkan tombol simpan dan batal
                btnSimpan3.Visible = true;
                btnBatal3.Visible = true;
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data Petugas belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnHapus3_Click(object sender, EventArgs e)
        {
            // cek apakah data Petugas sudah dipilih
            if (lvwPetugas.SelectedItems.Count > 0)
            {
                // tampilkan konfirmasi
                var konfirmasi = MessageBox.Show("Apakah data Petugas ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil index listview yang di pilih
                    var index = lvwPetugas.SelectedIndices[0];
                    var item = lvwPetugas.Items[index];

                    // membuat objek dari class Petugas
                    var petugas = new Petugas();
                    petugas.id_petugas = item.SubItems[1].Text;

                    var result = _controller.Delete(petugas);
                    if (result > 0) LoadDataPetugas(); // jika hapus berhasil, referesh data Petugas
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data Petugas belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBatal3_Click(object sender, EventArgs e)
        {
            // sembunyikan btnTambah, btnPerbaiki dan btnHapus
            btnTambah3.Visible = true;
            btnPerbaiki3.Visible = true;
            btnHapus3.Visible = true;

            // tampilkan btnSimpan dan btnBatal
            btnSimpan3.Visible = false;
            btnBatal3.Visible = false;

            // kosongkan isian npm, nama dan alamat
            txtId3.Clear();
            txtNama3.Clear();
            txtJenisKelamin3.Clear();
            txtTempat3.Clear();
            txtTglLahir3.Clear();
            txtAlamat3.Clear();
            txtNoTlp3.Clear();
        }

        private void btnCari3_Click(object sender, EventArgs e)
        {
            // kosongkan data listview mahasiswa
            lvwPetugas.Items.Clear();

            // panggil method GetByNama untuk mendapatkan semua data mahasiswa
            var list = _controller.GetByNama_petugas(txtCari3.Text);

            // lakukan perulangan untuk menampilkan data mahasiswa ke listview
            foreach (var petugas in list)
            {
                var noUrut = lvwPetugas.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(petugas.id_petugas);
                item.SubItems.Add(petugas.nama_petugas);
                item.SubItems.Add(petugas.jeniskelamin_petugas);
                item.SubItems.Add(petugas.tempatlahir_petugas);
                item.SubItems.Add(petugas.tanggallahir_petugas);
                item.SubItems.Add(petugas.alamat_petugas);
                item.SubItems.Add(petugas.notlp_petugas);

                lvwPetugas.Items.Add(item);
            }
        }
    }
}
