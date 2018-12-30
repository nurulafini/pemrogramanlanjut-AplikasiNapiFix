using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using AplikasiNapi.Model.Entity;
using AplikasiNapi.Model.Repository;
using AplikasiNapi.Model.Context;

namespace AplikasiNapi.Controller
{
    public class PetugasController
    {
        // deklarasi objek Repository untuk menjalankan operasi CRUD
        private PetugasRepository _repository;

        /// <summary>
        /// Method untuk menampilkan data Petugas berdasarkan id_petugas
        /// </summary>
        /// <param name="id_petugas"></param>
        /// <returns></returns>
        public Petugas GetById_petugas(string id_petugas)
        {
            // deklarasi objek Petugas
            Petugas petugas = null;

            // membuat objek context menggunakan blok using
            using (var context = new DbContext())
            {
                _repository = new PetugasRepository(context);
                petugas = _repository.GetById_petugas(id_petugas);
            }

            return petugas;
        }

        /// <summary>
        /// Method untuk menampilkan data mahasiwa berdasarkan nama
        /// </summary>
        /// <param name="nama"></param>
        /// <returns></returns>
        public List<Petugas> GetByNama_petugas(string nama_petugas)
        {
            // membuat objek collection
            var list = new List<Petugas>();

            // membuat objek context menggunakan blok using
            using (var context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PetugasRepository(context);

                // panggil method GetByNama yang ada di dalam class repository
                list = _repository.GetByNama_petugas(nama_petugas);
            }

            return list;
        }

        /// <summary>
        /// Method untuk menampilkan semua data mahasiwa
        /// </summary>
        /// <returns></returns>
        public List<Petugas> GetAll()
        {
            // membuat objek collection
            var list = new List<Petugas>();

            // membuat objek context menggunakan blok using
            using (var context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PetugasRepository(context);

                // panggil method GetAll yang ada di dalam class repository
                list = _repository.GetAll();
            }

            return list;
        }

        public int Save(Petugas obj)
        {
            var result = 0;

            // cek nilai id_petugas yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(obj.id_petugas))
            {
                MessageBox.Show("id_petugas harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek nilai nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(obj.nama_petugas))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (var context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PetugasRepository(context);

                // panggil method Save yang ada di dalam class repository
                result = _repository.Save(obj);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Petugas berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Petugas gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Update(Petugas obj)
        {
            var result = 0;

            // cek nilai id_petugas yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(obj.id_petugas))
            {
                MessageBox.Show("id_petugas harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek nilai nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(obj.nama_petugas))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (var context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PetugasRepository(context);

                // panggil method Update yang ada di dalam class repository
                result = _repository.Update(obj);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Petugas berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Petugas gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Petugas obj)
        {
            var result = 0;

            // cek nilai id_petugas yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(obj.id_petugas))
            {
                MessageBox.Show("id_petugas harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (var context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PetugasRepository(context);

                // panggil method Delete yang ada di dalam class repository
                result = _repository.Delete(obj);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Petugas berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Petugas gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }
    }
}
