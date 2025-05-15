using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace KamusMiniApp
{
    public partial class FormTambahEdit : Form
    {
        private int? id = null;

        public FormTambahEdit()
        {
            InitializeComponent();
            this.Text = "Tambah Kata Baru";
        }

        public FormTambahEdit(int id, string indonesia, string inggris, string keterangan)
        {
            InitializeComponent();
            this.Text = "Edit Kata";
            this.id = id;
            txtIndonesia.Text = indonesia;
            txtInggris.Text = inggris;
            txtKeterangan.Text = keterangan;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIndonesia.Text) || string.IsNullOrWhiteSpace(txtInggris.Text))
            {
                MessageBox.Show("Kata Indonesia dan Inggris harus diisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@KataIndonesia", txtIndonesia.Text.Trim()),
                    new SqlParameter("@KataInggris", txtInggris.Text.Trim()),
                    new SqlParameter("@Keterangan", string.IsNullOrWhiteSpace(txtKeterangan.Text) ? (object)DBNull.Value : txtKeterangan.Text.Trim())
                };

                if (id.HasValue)
                {
                    // Edit kata
                    SqlParameter[] editParams = new SqlParameter[parameters.Length + 1];
                    editParams[0] = new SqlParameter("@Id", id.Value);
                    Array.Copy(parameters, 0, editParams, 1, parameters.Length);

                    DatabaseHelper.ExecuteNonQuery("EXEC sp_UpdateKata @Id, @KataIndonesia, @KataInggris, @Keterangan", editParams);
                }
                else
                {
                    // Tambah kata baru
                    DatabaseHelper.ExecuteNonQuery("EXEC sp_TambahKata @KataIndonesia, @KataInggris, @Keterangan", parameters);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}