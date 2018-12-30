using System.Collections.Generic;

using System.Windows.Forms;
using AplikasiNapi.Model.Entity;
using AplikasiNapi.Model.Repository;
using AplikasiNapi.Model.Context;

namespace AplikasiNapi.Controller
{
    public class TamuController
    {
        // deklarasi objek Repository untuk menjalankan operasi CRUD
        private TamuRepository _repository;

        /// <summary>
        /// Method untuk menampilkan data Tamu berdasarkan id_tamu
        /// </summary>
        /// <param name="id_tamu"></param>
        /// <returns></returns>
        public Tamu GetById_tamu(string id_tamu)
        {
            // deklarasi objek Tamu
            Tamu tamu = null;

            // membuat objek context menggunakan blok using
            using (var context = new DbContext())
            {
                _repository = new TamuRepository(context);
                tamu = _repository.GetById_tamu(id_tamu);
            }

            return tamu;
        }

        /// <summary>
        /// Method untuk menampilkan data mahasiwa berdasarkan nama
        /// </summary>
        /// <param name="nama"></param>
        /// <returns></returns>
        public List<Tamu> GetByNama_tamu(string nama_tamu)
        {
            // membuat objek collection
            var list = new List<Tamu>();

            // membuat objek context menggunakan blok using
            using (var context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new TamuRepository(context);

                // panggil method GetByNama yang ada di dalam class repository
                list = _repository.GetByNama_tamu(nama_tamu);
            }

            return list;
        }

        /// <summary>
        /// Method untuk menampilkan semua data mahasiwa
        /// </summary>
        /// <returns></returns>
        public List<Tamu> GetAll()
        {
            // membuat objek collection
            var list = new List<Tamu>();

            // membuat objek context menggunakan blok using
            using (var context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new TamuRepository(context);

                // panggil method GetAll yang ada di dalam class repository
                list = _repository.GetAll();
            }

            return list;
        }

        public int Save(Tamu obj)
        {
            var result = 0;

            // cek nilai id_tamu yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(obj.id_tamu))
            {
                MessageBox.Show("id_tamu harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek nilai nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(obj.nama_tamu))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (var context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new TamuRepository(context);

                // panggil method Save yang ada di dalam class repository
                result = _repository.Save(obj);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Tamu berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Tamu gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Update(Tamu obj)
        {
            var result = 0;

            // cek nilai id_tamu yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(obj.id_tamu))
            {
                MessageBox.Show("id_tamu harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek nilai nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(obj.nama_tamu))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (var context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new TamuRepository(context);

                // panggil method Update yang ada di dalam class repository
                result = _repository.Update(obj);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Tamu berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Tamu gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Tamu obj)
        {
            var result = 0;

            // cek nilai id_tamu yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(obj.id_tamu))
            {
                MessageBox.Show("id_tamu harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (var context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new TamuRepository(context);

                // panggil method Delete yang ada di dalam class repository
                result = _repository.Delete(obj);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Tamu berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Tamu gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }
    }
}
