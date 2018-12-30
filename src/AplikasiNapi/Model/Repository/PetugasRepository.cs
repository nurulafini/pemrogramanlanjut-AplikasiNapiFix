using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using AplikasiNapi.Model.Context;
using AplikasiNapi.Model.Entity;

namespace AplikasiNapi.Model.Repository
{
    /// <summary>
    /// Class repository berisi perintah untuk menjalankan operasi CRUD
    /// </summary>
    public class PetugasRepository
    {
        // deklarsi objek DbContext
        private DbContext _context;

        // constructor
        public PetugasRepository(DbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Method untuk menampilkan data Petugas berdasarkan id_petugas
        /// </summary>
        /// <param nama_petugas="id_petugas"></param>
        /// <returns></returns>
        public Petugas GetById_petugas(string id_petugas)
        {
            // deklarasi objek Petugas
            Petugas petugas = null;

            var sql = @"select id_petugas, nama_petugas, jeniskelamin_petugas, tempatlahir_petugas, tanggallahir_petugas, alamat_petugas, notlp_petugas 
                        from petugas 
                        where id_petugas = @id_petugas";

            // membuat objek command menggunakan blok using
            using (var cmd = new OleDbCommand(sql, _context.Conn))
            {
                // set nilai parameter @npm
                cmd.Parameters.AddWithValue("@id_petugas", id_petugas);

                // membuat objek dtr (data reader) menggunakan blok using, untuk menampung hasil perintah SELECT
                using (var dtr = cmd.ExecuteReader())
                {
                    // panggil method Read untuk mendapatkan baris dari hasil query
                    if (dtr.Read()) // jika data mahasiswa ditemukan
                    {
                        // membuat objek dari class Mahasiswa
                        petugas = new Petugas();

                        // set nilai property objek mahasiswa
                        petugas.id_petugas = dtr["id_petugas"].ToString();
                        petugas.nama_petugas = Convert.ToString(dtr["nama_petugas"]);
                        petugas.jeniskelamin_petugas = dtr["jeniskelamin_petugas"].ToString();
                        petugas.tempatlahir_petugas = dtr["tempatlahir_petugas"].ToString();
                        petugas.tanggallahir_petugas = dtr["tanggallahir_petugas"].ToString();
                        petugas.alamat_petugas = dtr["alamat_petugas"].ToString();
                        petugas.notlp_petugas = dtr["notlp_petugas"].ToString();
                    }
                }
            }

            return petugas;
        }

        /// <summary>
        /// Method untuk menampilkan data Petugas berdasarkan pencarian nama
        /// </summary>
        /// <param nama_petugas="nama_petugas"></param>
        /// <returns></returns>
        public List<Petugas> GetByNama_petugas(string nama_petugas)
        {
            // membuat objek collection
            var list = new List<Petugas>();

            var sql = @"select id_petugas, nama_petugas, jeniskelamin_petugas, tempatlahir_petugas, tanggallahir_petugas, alamat_petugas, notlp_petugas 
                        from petugas 
                        where nama_petugas like @nama_petugas
                        order by nama_petugas";

            // membuat objek command menggunakan blok using
            using (var cmd = new OleDbCommand(sql, _context.Conn))
            {
                // set nilai parameter @nama
                cmd.Parameters.AddWithValue("@nama_petugas", "%" + nama_petugas + "%");

                // membuat objek dtr (data reader) menggunakan blok using, untuk menampung hasil perintah SELECT
                using (var dtr = cmd.ExecuteReader())
                {
                    // panggil method Read untuk mendapatkan baris dari hasil query
                    while (dtr.Read())
                    {
                        // membuat objek dari class Mahasiswa
                        var petugas = new Petugas();

                        // set nilai property objek mahasiswa
                        petugas.id_petugas = dtr["id_petugas"].ToString();
                        petugas.nama_petugas = Convert.ToString(dtr["nama_petugas"]);
                        petugas.jeniskelamin_petugas = dtr["jeniskelamin_petugas"].ToString();
                        petugas.tempatlahir_petugas = dtr["tempatlahir_petugas"].ToString();
                        petugas.tanggallahir_petugas = dtr["tanggallahir_petugas"].ToString();
                        petugas.alamat_petugas = dtr["alamat_petugas"].ToString();
                        petugas.notlp_petugas = dtr["notlp_petugas"].ToString();

                        // tambahkan objek mahasiswa ke dalam collection
                        list.Add(petugas);
                    }
                }
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

            var sql = @"select id_petugas, nama_petugas, jeniskelamin_petugas, tempatlahir_petugas, tanggallahir_petugas, alamat_petugas, notlp_petugas
                        from petugas 
                        order by nama_petugas";

            // membuat objek command menggunakan blok using
            using (var cmd = new OleDbCommand(sql, _context.Conn))
            {
                // membuat objek dtr (data reader) menggunakan blok using, untuk menampung hasil perintah SELECT
                using (var dtr = cmd.ExecuteReader())
                {
                    // panggil method Read untuk mendapatkan baris dari hasil query
                    while (dtr.Read())
                    {
                        // membuat objek dari class Mahasiswa
                        var petugas = new Petugas();

                        petugas.id_petugas = dtr["id_petugas"].ToString();
                        petugas.nama_petugas = Convert.ToString(dtr["nama_petugas"]);
                        petugas.jeniskelamin_petugas = dtr["jeniskelamin_petugas"].ToString();
                        petugas.tempatlahir_petugas = dtr["tempatlahir_petugas"].ToString();
                        petugas.tanggallahir_petugas = dtr["tanggallahir_petugas"].ToString();
                        petugas.alamat_petugas = dtr["alamat_petugas"].ToString();
                        petugas.notlp_petugas = dtr["notlp_petugas"].ToString();

                        // tambahkan objek mahasiswa ke dalam collection
                        list.Add(petugas);
                    }
                }
            }

            return list;
        }

        public int Save(Petugas obj)
        {
            var result = 0;

            var sql = @"insert into petugas (id_petugas, nama_petugas, jeniskelamin_petugas, tempatlahir_petugas, tanggallahir_petugas, alamat_petugas, notlp_petugas)
                        values (@id_petugas, @nama_petugas, @jeniskelamin_petugas, @tempatlahir_petugas, @tanggallahir_petugas, @alamat_petugas, @notlp_petugas)";

            // membuat objek command menggunakan blok using
            using (var cmd = new OleDbCommand(sql, _context.Conn))
            {
                // set nilai parameter @npm, @nama dan @alamat
                cmd.Parameters.AddWithValue("@id_petugas", obj.id_petugas);
                cmd.Parameters.AddWithValue("@nama_petugas", obj.nama_petugas);
                cmd.Parameters.AddWithValue("@jeniskelamin_petugas", obj.jeniskelamin_petugas);
                cmd.Parameters.AddWithValue("@tempatlahir_petugas", obj.tempatlahir_petugas);
                cmd.Parameters.AddWithValue("@tanggallahir_petugas", obj.tanggallahir_petugas);
                cmd.Parameters.AddWithValue("@alamat_petugas", obj.alamat_petugas);
                cmd.Parameters.AddWithValue("@notlp_petugas", obj.notlp_petugas);

                // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                result = cmd.ExecuteNonQuery();
            }

            return result;
        }

        public int Update(Petugas obj)
        {
            var result = 0;

            var sql = @"update petugas set nama_petugas = @nama_petugas, jeniskelamin_petugas = @jeniskelamin_petugas, tempatlahir_petugas = @tempatlahir_petugas, tanggallahir_petugas = @tanggallahir_petugas, alamat_petugas = @alamat_petugas, notlp_petugas = @notlp_petugas
                        where id_petugas = @id_petugas";

            // membuat objek command menggunakan blok using
            using (var cmd = new OleDbCommand(sql, _context.Conn))
            {
                // set nilai parameter @npm, @nama dan @alamat
                cmd.Parameters.AddWithValue("@nama_petugas", obj.nama_petugas);
                cmd.Parameters.AddWithValue("@jeniskelamin_petugas", obj.jeniskelamin_petugas);
                cmd.Parameters.AddWithValue("@tempatlahir_petugas", obj.tempatlahir_petugas);
                cmd.Parameters.AddWithValue("@tanggallahir_petugas", obj.tanggallahir_petugas);
                cmd.Parameters.AddWithValue("@alamat_petugas", obj.alamat_petugas);
                cmd.Parameters.AddWithValue("@notlp_petugas", obj.notlp_petugas);
                cmd.Parameters.AddWithValue("@id_petugas", obj.id_petugas);

                // jalankan perintah UPDATE dan tampung hasilnya ke dalam variabel result
                result = cmd.ExecuteNonQuery();
            }

            return result;
        }

        public int Delete(Petugas obj)
        {
            var result = 0;

            var sql = @"delete from petugas
                        where id_petugas = @id_petugas";

            // membuat objek command menggunakan blok using
            using (var cmd = new OleDbCommand(sql, _context.Conn))
            {
                // set nilai parameter @npm
                cmd.Parameters.AddWithValue("@id_petugas", obj.id_petugas);

                // jalankan perintah DELETE dan tampung hasilnya ke dalam variabel result
                result = cmd.ExecuteNonQuery();
            }

            return result;
        }
    }
}
