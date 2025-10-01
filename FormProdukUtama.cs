using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoneksiDatabase
{
    public partial class FormProdukUtama : Form
    {
        public FormProdukUtama()
        {
            InitializeComponent();
        }

        private void FormProdukUtama_Load(object sender, EventArgs e)
        {
            LoadDataProduk();
        }

        private void LoadDataProduk()
        {
            dgvProduk.Rows.Clear();
            dgvProduk.Columns.Clear();
            using (SqlConnection conn = Koneksi.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT p.Id, p.NamaProduk, p.Harga, p.Stok, p.Deskripsi, k.NamaKategori
                                    FROM Produk p
                                    LEFT JOIN Kategori k ON p.KategoriId = k.Id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    // Tambahkan kolom ke grid
                    dgvProduk.Columns.Add("Id", "ID");
                    dgvProduk.Columns.Add("NamaProduk", "Nama Produk");
                    dgvProduk.Columns.Add("Harga", "Harga");
                    dgvProduk.Columns.Add("Stok", "Stok");
                    dgvProduk.Columns.Add("Kategori", "Kategori");
                    dgvProduk.Columns.Add("Deskripsi", "Deskripsi"); // Kolom baru


                    while (reader.Read())
                    {
                        dgvProduk.Rows.Add(
                        reader["Id"],
                        reader["NamaProduk"],
                        reader["Harga"],
                        reader["Stok"],
                        reader["NamaKategori"],
                        reader["Deskripsi"] // Data baru
                        );
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menampilkan data: " + ex.Message);
                }
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormProdukDetail frm = new FormProdukDetail();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadDataProduk(); // refresh data setelah tambah
            }
        }
    }
}

