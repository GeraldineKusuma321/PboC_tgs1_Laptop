using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static PBO_pr_Penjualan_laptop__Geraldine_H.K_222410103008.Laptopp;
using static System.Windows.Forms.DataFormats;
using Npgsql;
using System;


// NAMA : GERALDINE HENDRAESTI KUSUMANINGRUM
// NIM  : 222410103008
// KELAS : PBO C
// TUGAS 1

namespace PBO_pr_Penjualan_laptop__Geraldine_H.K_222410103008
{
    public partial class Laptopp : Form
    {

        private List<Laptop> listLaptop;
        private List<Transaksi> listTransaksi;
        private List<DetailTransaksi> listDetailTransaksi;

        public Laptopp()
        {
            InitializeComponent();

            listLaptop = new List<Laptop>();
            listTransaksi = new List<Transaksi>();
            listDetailTransaksi = new List<DetailTransaksi>();

            // Isi data laptop
            listLaptop.Add(new Laptop { Nama = "Lenovo", Harga = 12000000, Stok = 10 });
            listTransaksi.Add(new Transaksi { IdentitasTransaksi = "A1", Nama = "Lenovo" });
            listDetailTransaksi.Add(new DetailTransaksi { Transaksi = "A1", LaptopDibeli = "Lenovo", StokDibeli = 1 });



            dataGridView1.DataSource = listLaptop;
            dataGridView2.DataSource = listTransaksi;
            dataGridView3.DataSource = listDetailTransaksi;

            Read();
            ReadTransaksi();
            ReadDetailTransaksi();

        }
        public class Laptop
        {

            public string Nama { get; set; }
            public int Harga { get; set; }
            public int Stok { get; set; }

        }
        public class Transaksi
        {
            public string IdentitasTransaksi { get; set; }
            public string Nama { get; set; }


        }

        public class DetailTransaksi
        {
            public string Transaksi { get; set; }
            public string LaptopDibeli { get; set; }
            public int StokDibeli { get; set; }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            using (Form2 frmDataBaru = new Form2())
            {
                if (frmDataBaru.ShowDialog() == DialogResult.OK)
                {
                    Laptop newLaptop = new Laptop();
                    frmDataBaru.GetLaptop(newLaptop);

                    if (Insert(newLaptop))
                    {
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = listLaptop;
                    }
                }

                frmDataBaru.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form3 frmDataBaru = new Form3())
            {
                if (frmDataBaru.ShowDialog() == DialogResult.OK)
                {
                    Transaksi newtransaksi = new Transaksi();
                    frmDataBaru.GetTransaksi(newtransaksi);

                    if (Insert(newtransaksi))
                    {
                        dataGridView2.DataSource = null;
                        dataGridView2.DataSource = listTransaksi;
                    }

                }
                frmDataBaru.Close();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Form4 frmDataBaru = new Form4())
            {
                if (frmDataBaru.ShowDialog() == DialogResult.OK)
                {
                    DetailTransaksi newdetailtransaksi = new DetailTransaksi();
                    frmDataBaru.GetDetailTransaksi(newdetailtransaksi);

                    if (Insert(newdetailtransaksi))
                    {
                        dataGridView3.DataSource = null;
                        dataGridView3.DataSource = listDetailTransaksi;
                    }

                }
                frmDataBaru.Close();
            }
        }

        private bool Insert(Laptop laptop)
        {
            bool isSuccess = false;
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=geral;Database=Laptop;";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = @"INSERT INTO laptop(nama, harga, stok) VALUES(:nama, :harga, :stok)";

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("nama", laptop.Nama);
                    cmd.Parameters.AddWithValue("harga", laptop.Harga);
                    cmd.Parameters.AddWithValue("stok", laptop.Stok);

                    cmd.CommandType = System.Data.CommandType.Text;
                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            isSuccess = true;
                            listLaptop.Add(laptop);
                        }
                    }
                    catch (NpgsqlException ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                    }
                }
            }

            return isSuccess;
        }

        public bool Read()
        {


            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=geral;Database=Laptop;";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {


                string sql = "SELECT * FROM laptop";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.CommandText = sql;
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    listLaptop.Clear();
                    while (reader.Read())
                    {
                        Laptop laptop = new Laptop();

                        laptop.Nama = (string)reader["nama"];
                        laptop.Harga = (int)reader["harga"];
                        laptop.Stok = (int)reader["stok"];

                        listLaptop.Add(laptop);


                    }
                }

                return true;

            }
        }
        public bool UpdateLaptop(string nama, int harga, int stok)
        {
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=geral;Database=Laptop;";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "UPDATE laptop SET harga = :harga, stok = :stok WHERE nama = :nama";

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("nama", nama);
                    cmd.Parameters.AddWithValue("harga", harga);
                    cmd.Parameters.AddWithValue("stok", stok);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        // Data berhasil diupdate
                        return true;
                    }
                }
            }

            // Data tidak ditemukan atau terjadi kesalahan
            return false;
        }


        public bool Insert(Transaksi transaksi)
        {
            bool isSuccess = false;
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=geral;Database=Laptop;";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = @"INSERT INTO transaksi(identitas_transaksi, nama) VALUES(:identitasTransaksi, :nama)";

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("identitasTransaksi", transaksi.IdentitasTransaksi);
                    cmd.Parameters.AddWithValue("nama", transaksi.Nama);

                    cmd.CommandType = System.Data.CommandType.Text;
                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            isSuccess = true;
                            listTransaksi.Add(transaksi);
                        }
                    }
                    catch (NpgsqlException ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                    }
                }
            }

            return isSuccess;
        }
        public bool ReadTransaksi()
        {
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=geral;Database=Laptop;";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "SELECT * FROM transaksi";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.CommandText = sql;
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    listTransaksi.Clear();
                    while (reader.Read())
                    {
                        Transaksi transaksi = new Transaksi();

                        transaksi.IdentitasTransaksi = (string)reader["identitas_transaksi"];
                        transaksi.Nama = (string)reader["nama"];

                        listTransaksi.Add(transaksi);
                    }
                }

                return true;
            }
        }

        public bool Insert(DetailTransaksi detailTransaksi)
        {
            bool isSuccess = false;
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=geral;Database=Laptop;";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = @"INSERT INTO detail_transaksi(transaksi, laptop_dibeli, stok_dibeli) VALUES(:transaksi, :laptopDibeli, :stokDibeli)";

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("transaksi", detailTransaksi.Transaksi);
                    cmd.Parameters.AddWithValue("laptopDibeli", detailTransaksi.LaptopDibeli);
                    cmd.Parameters.AddWithValue("stokDibeli", detailTransaksi.StokDibeli);

                    cmd.CommandType = System.Data.CommandType.Text;
                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            isSuccess = true;
                            listDetailTransaksi.Add(detailTransaksi);
                        }
                    }
                    catch (NpgsqlException ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                    }
                }
            }

            return isSuccess;
        }

        public bool ReadDetailTransaksi()
        {
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=geral;Database=Laptop;";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "SELECT * FROM detail_transaksi";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.CommandText = sql;
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    listDetailTransaksi.Clear();
                    while (reader.Read())
                    {
                        DetailTransaksi detailTransaksi = new DetailTransaksi();

                        detailTransaksi.Transaksi = (string)reader["transaksi"];
                        detailTransaksi.LaptopDibeli = (string)reader["laptop_dibeli"];
                        detailTransaksi.StokDibeli = (int)reader["stok_dibeli"];

                        listDetailTransaksi.Add(detailTransaksi);
                    }
                }

                return true;
            }
        }

    }
}

