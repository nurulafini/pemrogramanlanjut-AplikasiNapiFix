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
    public class TamuRepository
    {
        // deklarsi objek DbContext
        private DbContext _context;

        // constructor
        public TamuRepository(DbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Method untuk menampilkan data Tamu berdasarkan id_tamu
        /// </summary>
        /// <param nama_tamu="id_tamu"></param>
        /// <returns></returns>
        public Tamu GetById_tamu(string id_tamu)
        {
            // deklarasi objek Tamu
            Tamu tamu = null;

            var sql = @"select id_tamu, nama_tamu, jeniskelamin_tamu, alamat_tamu, notlp_tamu 
                        from tamu 
                        where id_tamu = @id_tamu";

            // membuat objek command menggunakan blok using
            using (var cmd = new OleDbCommand(sql, _context.Conn))
            {
                // set nilai parameter @npm
                cmd.Parameters.AddWithValue("@id_tamu", id_tamu);

                // membuat objek dtr (data reader) menggunakan blok using, untuk menampung hasil perintah SELECT
                using (var dtr = cmd.ExecuteReader())
                {
                    // panggil method Read untuk mendapatkan baris dari hasil query
                    if (dtr.Read()) // jika data mahasiswa ditemukan
                    {
                        // membuat objek dari class Mahasiswa
                        tamu = new Tamu();

                        // set nilai property objek mahasiswa
                        tamu.id_tamu = dtr["id_tamu"].ToString();
                        tamu.nama_tamu = Convert.ToString(dtr["nama_tamu"]);
                        tamu.jeniskelamin_tamu = dtr["jeniskelamin_tamu"].ToString();
                        tamu.alamat_tamu = dtr["alamat_tamu"].ToString();
                        tamu.notlp_tamu = dtr["notlp_tamu"].ToString();
                    }
                }
            }

            return tamu;
        }

        /// <summary>
        /// Method untuk menampilkan data Tamu berdasarkan pencarian nama
        /// </summary>
        /// <param nama_tamu="nama_tamu"></param>
        /// <returns></returns>
        public List<Tamu> GetByNama_tamu(string nama_tamu)
        {
            // membuat objek collection
            var list = new List<Tamu>();

            var sql = @"select id_tamu, nama_tamu, jeniskelamin_tamu, alamat_tamu, notlp_tamu 
                        from tamu 
                        where nama_tamu like @nama_tamu
                        order by nama_tamu";

            // membuat objek command menggunakan blok using
            using (var cmd = new OleDbCommand(sql, _context.Conn))
            {
                // set nilai parameter @nama
                cmd.Parameters.AddWithValue("@nama_tamu", "%" + nama_tamu + "%");

                // membuat objek dtr (data reader) menggunakan blok using, untuk menampung hasil perintah SELECT
                using (var dtr = cmd.ExecuteReader())
                {
                    // panggil method Read untuk mendapatkan baris dari hasil query
                    while (dtr.Read())
                    {
                        // membuat objek dari class Mahasiswa
                        var tamu = new Tamu();

                        // set nilai property objek mahasiswa
                        tamu.id_tamu = dtr["id_tamu"].ToString();
                        tamu.nama_tamu = Convert.ToString(dtr["nama_tamu"]);
                        tamu.jeniskelamin_tamu = dtr["jeniskelamin_tamu"].ToString();
                        tamu.alamat_tamu = dtr["alamat_tamu"].ToString();
                        tamu.notlp_tamu = dtr["notlp_tamu"].ToString();

                        // tambahkan objek mahasiswa ke dalam collection
                        list.Add(tamu);
                    }
                }
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

            var sql = @"select id_tamu, nama_tamu, jeniskelamin_tamu, alamat_tamu, notlp_tamu
                        from tamu
                        order by nama_tamu";

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
                        var tamu = new Tamu();

                        tamu.id_tamu = dtr["id_tamu"].ToString();
                        tamu.nama_tamu = Convert.ToString(dtr["nama_tamu"]);
                        tamu.jeniskelamin_tamu = dtr["jeniskelamin_tamu"].ToString();
                        tamu.alamat_tamu = dtr["alamat_tamu"].ToString();
                        tamu.notlp_tamu = dtr["notlp_tamu"].ToString();

                        // tambahkan objek mahasiswa ke dalam collection
                        list.Add(tamu);
                    }
                }
            }

            return list;
        }

        public int Save(Tamu obj)
        {
            var result = 0;

            var sql = @"insert into tamu (id_tamu, nama_tamu, jeniskelamin_tamu, alamat_tamu, notlp_tamu)
                        values (@id_tamu, @nama_tamu, @jeniskelamin_tamu, @alamat_tamu, @notlp_tamu)";

            // membuat objek command menggunakan blok using
            using (var cmd = new OleDbCommand(sql, _context.Conn))
            {
                // set nilai parameter @npm, @nama dan @alamat
                cmd.Parameters.AddWithValue("@id_tamu", obj.id_tamu);
                cmd.Parameters.AddWithValue("@nama_tamu", obj.nama_tamu);
                cmd.Parameters.AddWithValue("@jeniskelamin_tamu", obj.jeniskelamin_tamu);
                cmd.Parameters.AddWithValue("@alamat_tamu", obj.alamat_tamu);
                cmd.Parameters.AddWithValue("@notlp_tamu", obj.notlp_tamu);

                // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                result = cmd.ExecuteNonQuery();
            }

            return result;
        }

        public int Update(Tamu obj)
        {
            var result = 0;

            var sql = @"update tamu set nama_tamu = @nama_tamu, jeniskelamin_tamu = @jeniskelamin_tamu, alamat_tamu = @alamat_tamu, notlp_tamu = @notlp_tamu
                        where id_tamu = @id_tamu";

            // membuat objek command menggunakan blok using
            using (var cmd = new OleDbCommand(sql, _context.Conn))
            {
                // set nilai parameter @npm, @nama dan @alamat
                cmd.Parameters.AddWithValue("@nama_tamu", obj.nama_tamu);
                cmd.Parameters.AddWithValue("@jeniskelamin_tamu", obj.jeniskelamin_tamu);
                cmd.Parameters.AddWithValue("@alamat_tamu", obj.alamat_tamu);
                cmd.Parameters.AddWithValue("@notlp_tamu", obj.notlp_tamu);
                cmd.Parameters.AddWithValue("@id_tamu", obj.id_tamu);

                // jalankan perintah UPDATE dan tampung hasilnya ke dalam variabel result
                result = cmd.ExecuteNonQuery();
            }

            return result;
        }

        public int Delete(Tamu obj)
        {
            var result = 0;

            var sql = @"delete from tamu
                        where id_tamu = @id_tamu";

            // membuat objek command menggunakan blok using
            using (var cmd = new OleDbCommand(sql, _context.Conn))
            {
                // set nilai parameter @npm
                cmd.Parameters.AddWithValue("@id_tamu", obj.id_tamu);

                // jalankan perintah DELETE dan tampung hasilnya ke dalam variabel result
                result = cmd.ExecuteNonQuery();
            }

            return result;
        }
    }
}
