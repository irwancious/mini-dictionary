using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace KamusMiniApp
{
    public partial class Form1 : Form
    {
        // Variabel untuk quiz
        private int idKataBenar;
        private string jawabanBenar;

        public Form1()
        {
            InitializeComponent();
            LoadDaftarKata();
            MulaiQuiz(); // Memulai quiz saat form pertama kali dibuka
        }

        private void LoadDaftarKata()
        {
            DataTable dt = DatabaseHelper.ExecuteQuery("EXEC sp_GetAllKata");
            dataGridViewKata.DataSource = dt;
        }

        private void btnTerjemah_Click(object sender, EventArgs e)
        {
            string teks = txtTeksTerjemah.Text.Trim();
            bool dariIndonesia = rbIndonesia.Checked;

            if (string.IsNullOrEmpty(teks))
            {
                MessageBox.Show("Masukkan teks yang akan diterjemahkan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlParameter[] parameters = {
                new SqlParameter("@Teks", teks),
                new SqlParameter("@DariIndonesia", dariIndonesia)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery("EXEC sp_Terjemahkan @Teks, @DariIndonesia", parameters);

            if (dt.Rows.Count > 0)
            {
                txtHasilTerjemah.Text = dt.Rows[0]["Hasil"].ToString();
            }
            else
            {
                txtHasilTerjemah.Text = "Terjemahan tidak ditemukan";
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            using (FormTambahEdit form = new FormTambahEdit())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadDaftarKata();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewKata.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih kata yang akan diedit", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dataGridViewKata.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["Id"].Value);
            string indonesia = row.Cells["KataIndonesia"].Value.ToString();
            string inggris = row.Cells["KataInggris"].Value.ToString();
            string keterangan = row.Cells["Keterangan"].Value?.ToString();

            using (FormTambahEdit form = new FormTambahEdit(id, indonesia, inggris, keterangan))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadDaftarKata();
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dataGridViewKata.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih kata yang akan dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Apakah Anda yakin ingin menghapus kata ini?", "Konfirmasi", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridViewKata.SelectedRows[0].Cells["Id"].Value);
                SqlParameter[] parameters = { new SqlParameter("@Id", id) };
                DatabaseHelper.ExecuteNonQuery("EXEC sp_DeleteKata @Id", parameters);
                LoadDaftarKata();
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string keyword = txtCari.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadDaftarKata();
                return;
            }

            SqlParameter[] parameters = { new SqlParameter("@Keyword", keyword) };
            DataTable dt = DatabaseHelper.ExecuteQuery("EXEC sp_CariKata @Keyword", parameters);
            dataGridViewKata.DataSource = dt;
        }

        private void MulaiQuiz()
        {
            // Reset hasil sebelumnya
            lblHasilQuiz.Text = "";
            
            // Dapatkan kata acak untuk quiz
            DataTable dt = DatabaseHelper.ExecuteQuery("SELECT TOP 1 Id, KataIndonesia, KataInggris FROM Kata ORDER BY NEWID()");
            
            if (dt.Rows.Count == 0)
            {
                lblSoalQuiz.Text = "Tidak ada data kata untuk quiz";
                rbOpsi1.Visible = rbOpsi2.Visible = rbOpsi3.Visible = rbOpsi4.Visible = false;
                btnSubmitQuiz.Enabled = false;
                return;
            }

            DataRow row = dt.Rows[0];
            idKataBenar = Convert.ToInt32(row["Id"]);
            jawabanBenar = row["KataInggris"].ToString();

            lblSoalQuiz.Text = $"Apa terjemahan Inggris dari: '{row["KataIndonesia"]}'?";

            // Dapatkan opsi jawaban
            SqlParameter[] parameters = {
                new SqlParameter("@IdKataBenar", idKataBenar),
                new SqlParameter("@JumlahOpsi", 4)
            };

            DataTable dtOpsi = DatabaseHelper.ExecuteQuery("EXEC sp_GetQuizOptions @IdKataBenar, @JumlahOpsi", parameters);

            // Set opsi jawaban
            rbOpsi1.Text = dtOpsi.Rows[0][0].ToString();
            rbOpsi2.Text = dtOpsi.Rows[1][0].ToString();
            rbOpsi3.Text = dtOpsi.Rows[2][0].ToString();
            rbOpsi4.Text = dtOpsi.Rows[3][0].ToString();

            // Reset selection
            rbOpsi1.Checked = rbOpsi2.Checked = rbOpsi3.Checked = rbOpsi4.Checked = false;
        }

        private void btnSubmitQuiz_Click(object sender, EventArgs e)
        {
            string jawaban = "";
            if (rbOpsi1.Checked) jawaban = rbOpsi1.Text;
            else if (rbOpsi2.Checked) jawaban = rbOpsi2.Text;
            else if (rbOpsi3.Checked) jawaban = rbOpsi3.Text;
            else if (rbOpsi4.Checked) jawaban = rbOpsi4.Text;

            if (string.IsNullOrEmpty(jawaban))
            {
                lblHasilQuiz.Text = "Silakan pilih jawaban!";
                lblHasilQuiz.ForeColor = Color.Red;
                return;
            }

            if (jawaban == jawabanBenar)
            {
                lblHasilQuiz.Text = "Jawaban Anda benar!";
                lblHasilQuiz.ForeColor = Color.Green;
            }
            else
            {
                lblHasilQuiz.Text = $"Salah! Jawaban benar: {jawabanBenar}";
                lblHasilQuiz.ForeColor = Color.Red;
            }

            // Mulai quiz baru setelah 2 detik
            // Timer timer = new Timer();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 2000;
            timer.Tick += (s, args) => {
                timer.Stop();
                MulaiQuiz();
            };
            timer.Start();
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            using (FormQuiz form = new FormQuiz())
            {
                form.ShowDialog();
            }
        }
    }
}