using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace KamusMiniApp
{
    public partial class FormQuiz : Form
    {
        private int idKataBenar;
        private string jawabanBenar;

        public FormQuiz()
        {
            InitializeComponent();
            MulaiQuiz();
        }

        private void MulaiQuiz()
        {
            // Dapatkan kata acak untuk quiz
            DataTable dt = DatabaseHelper.ExecuteQuery("SELECT TOP 1 Id, KataIndonesia, KataInggris FROM Kata ORDER BY NEWID()");
            
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data kata untuk quiz", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            DataRow row = dt.Rows[0];
            idKataBenar = Convert.ToInt32(row["Id"]);
            jawabanBenar = row["KataInggris"].ToString();

            lblSoal.Text = $"Apa terjemahan Inggris dari: '{row["KataIndonesia"]}'?";

            // Dapatkan opsi jawaban
            SqlParameter[] parameters = {
                new SqlParameter("@IdKataBenar", idKataBenar),
                new SqlParameter("@JumlahOpsi", 4)
            };

            DataTable dtOpsi = DatabaseHelper.ExecuteQuery("EXEC sp_GetQuizOptions @IdKataBenar, @JumlahOpsi", parameters);

            rbOpsi1.Text = dtOpsi.Rows[0][0].ToString();
            rbOpsi2.Text = dtOpsi.Rows[1][0].ToString();
            rbOpsi3.Text = dtOpsi.Rows[2][0].ToString();
            rbOpsi4.Text = dtOpsi.Rows[3][0].ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string jawaban = "";
            if (rbOpsi1.Checked) jawaban = rbOpsi1.Text;
            else if (rbOpsi2.Checked) jawaban = rbOpsi2.Text;
            else if (rbOpsi3.Checked) jawaban = rbOpsi3.Text;
            else if (rbOpsi4.Checked) jawaban = rbOpsi4.Text;

            if (string.IsNullOrEmpty(jawaban))
            {
                MessageBox.Show("Pilih salah satu jawaban", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (jawaban == jawabanBenar)
            {
                MessageBox.Show("Jawaban Anda benar!", "Hasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Jawaban Anda salah. Jawaban yang benar adalah: {jawabanBenar}", "Hasil", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            MulaiQuiz();
        }
    }
}