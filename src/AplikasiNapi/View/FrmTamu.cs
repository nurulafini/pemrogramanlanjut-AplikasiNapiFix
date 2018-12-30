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
    public partial class FrmTamu : Form
    {
        // deklarasi objek controller
        private TamuController _controller;

        // deklarasi private variabel/field _addData
        private bool _addData;


        public FrmTamu()
        {

            InitializeComponent();
            InisialisasiListView();

            // membuat objek controller
            _controller = new TamuController();


            // tampilkan data mahasiwa
            LoadDataTamu();

            // atur ulang posisi tombol Simpan dan Batal
            // disamakan dg posisi tombol Tambah dan Perbaiki
            //btnSimpan2.Location = btnTambah2.Location;
            //btnBatal2.Location = btnPerbaiki2.Location;
        }
        private void LoadDataTamu()
        {
            // kosongkan data listview Tamu
            lvwTamu.Items.Clear();

            // panggil method GetAll untuk mendapatkan semua data Tamu
            var list = _controller.GetAll();

            // lakukan perulangan untuk menampilkan data Tamu ke listview
            foreach (var tamu in list)
            {
                var noUrut = lvwTamu.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(tamu.id_tamu);
                item.SubItems.Add(tamu.nama_tamu);
                item.SubItems.Add(tamu.jeniskelamin_tamu);
                item.SubItems.Add(tamu.alamat_tamu);
                item.SubItems.Add(tamu.notlp_tamu);

                lvwTamu.Items.Add(item);
            }
        }

        // format kolom listview
        private void InisialisasiListView()
        {
            lvwTamu.View = System.Windows.Forms.View.Details;
            lvwTamu.FullRowSelect = true;
            lvwTamu.GridLines = true;

            lvwTamu.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwTamu.Columns.Add("ID", 30, HorizontalAlignment.Center);
            lvwTamu.Columns.Add("Nama", 200, HorizontalAlignment.Left);
            lvwTamu.Columns.Add("Jenis Kelamin", 140, HorizontalAlignment.Left);
            lvwTamu.Columns.Add("Alamat", 250, HorizontalAlignment.Left);
            lvwTamu.Columns.Add("No. Telepon", 150, HorizontalAlignment.Left);


        }

        private void btnTambah2_Click(object sender, EventArgs e)
        {
            // status untuk operasi tambah atau perbaiki
            _addData = true; // operasi tambah data baru

            // kosongkan isian npm, nama dan alamat
            txtId2.Clear();
            txtNama2.Clear();
            txtJenisKelamin2.Clear();
            txtAlamat2.Clear();
            txtNoTlp2.Clear();

            // fokus ke textbox npm
            txtId2.Focus();

            // sembunyikan btnTambah, btnPerbaiki dan btnHapus
            btnTambah2.Visible = false;
            btnPerbaiki2.Visible = false;
            btnHapus2.Visible = false;

            // tampilkan btnSimpan dan btnBatal
            btnSimpan2.Visible = true;
            btnBatal2.Visible = true;
        }

        private void btnPerbaiki2_Click(object sender, EventArgs e)
        {
            // cek apakah data Narapidana sudah dipilih
            if (lvwTamu.SelectedItems.Count > 0)
            {
                _addData = false;

                // ambil index listview yang di pilih
                var index = lvwTamu.SelectedIndices[0];

                var item = lvwTamu.Items[index];
                txtId2.Text = item.SubItems[1].Text;
                txtNama2.Text = item.SubItems[2].Text;
                txtJenisKelamin2.Text = item.SubItems[3].Text;
                txtAlamat2.Text = item.SubItems[4].Text;
                txtNoTlp2.Text = item.SubItems[5].Text;

                // fokus ke textbox npm
                txtId2.Focus();

                // sembunyikan tombol tambah, perbaiki dan hapus
                btnTambah2.Visible = false;
                btnPerbaiki2.Visible = false;
                btnHapus2.Visible = false;

                // tampilkan tombol simpan dan batal
                btnSimpan2.Visible = true;
                btnBatal2.Visible = true;
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data Narapidana belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnHapus2_Click(object sender, EventArgs e)
        {
            // cek apakah data Tamu sudah dipilih
            if (lvwTamu.SelectedItems.Count > 0)
            {
                // tampilkan konfirmasi
                var konfirmasi = MessageBox.Show("Apakah data Tamu ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil index listview yang di pilih
                    var index = lvwTamu.SelectedIndices[0];
                    var item = lvwTamu.Items[index];

                    // membuat objek dari class Tamu
                    var tamu = new Tamu();
                    tamu.id_tamu = item.SubItems[1].Text;

                    var result = _controller.Delete(tamu);
                    if (result > 0) LoadDataTamu(); // jika hapus berhasil, referesh data Tamu
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data Tamu belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSimpan2_Click(object sender, EventArgs e)
        {
            // membuat objek dari class Narapidana
            var tamu = new Tamu();

            // set nilai property objek Narapidana
            tamu.id_tamu = txtId2.Text;
            tamu.nama_tamu = txtNama2.Text;
            tamu.jeniskelamin_tamu = txtJenisKelamin2.Text;
            tamu.alamat_tamu = txtAlamat2.Text;
            tamu.notlp_tamu = txtNoTlp2.Text;

            var result = 0;

            if (_addData == true) // tambah data baru, panggil method Save
                result = _controller.Save(tamu);
            else // edit data, panggil method Update
                result = _controller.Update(tamu);

            if (result > 0) // tambah/edit data berhasil
            {
                // reset inputan dta
                txtId2.Clear();
                txtNama2.Clear();
                txtJenisKelamin2.Clear();
                txtAlamat2.Clear();
                txtNoTlp2.Clear();

                txtId2.Focus();

                // tampilkan kembali tombol tambah, perbaiki dan hapus
                btnTambah2.Visible = true;
                btnPerbaiki2.Visible = true;
                btnHapus2.Visible = true;

                // sembunyikan tombol simpan dan batal
                btnSimpan2.Visible = false;
                btnBatal2.Visible = false;

                // refresh data yang ditampilkan
                LoadDataTamu();
            }
        }

        private void btnBatal2_Click(object sender, EventArgs e)
        {
            // sembunyikan btnTambah, btnPerbaiki dan btnHapus
            btnTambah2.Visible = true;
            btnPerbaiki2.Visible = true;
            btnHapus2.Visible = true;

            // tampilkan btnSimpan dan btnBatal
            btnSimpan2.Visible = false;
            btnBatal2.Visible = false;

            // kosongkan isian npm, nama dan alamat
            txtId2.Clear();
            txtNama2.Clear();
            txtJenisKelamin2.Clear();
            txtAlamat2.Clear();
            txtNoTlp2.Clear();
        }

        private void btnCari2_Click(object sender, EventArgs e)
        {
            // kosongkan data listview mahasiswa
            lvwTamu.Items.Clear();

            // panggil method GetByNama untuk mendapatkan semua data mahasiswa
            var list = _controller.GetByNama_tamu(txtCari2.Text);

            // lakukan perulangan untuk menampilkan data mahasiswa ke listview
            foreach (var tamu in list)
            {
                var noUrut = lvwTamu.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(tamu.id_tamu);
                item.SubItems.Add(tamu.nama_tamu);
                item.SubItems.Add(tamu.jeniskelamin_tamu);
                item.SubItems.Add(tamu.alamat_tamu);
                item.SubItems.Add(tamu.notlp_tamu);

                lvwTamu.Items.Add(item);
            }
        }
    }
}
