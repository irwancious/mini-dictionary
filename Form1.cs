using System;
using System.Data;
using Microsoft.Data.SqlClient;
// using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiniDictionaryApp
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=DictionaryDB;Integrated Security=True;TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();
            this.Text = "Kamus Mini Indonesia-Inggris by IRWAN";
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim().ToLower();
            string result = "";

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Masukkan kata yang akan diterjemahkan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand("sp_Translate", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        
                        if (rbIndoToEng.Checked)
                        {
                            command.Parameters.AddWithValue("@fromLang", "Indonesian");
                            command.Parameters.AddWithValue("@toLang", "English");
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@fromLang", "English");
                            command.Parameters.AddWithValue("@toLang", "Indonesian");
                        }
                        
                        command.Parameters.AddWithValue("@word", input);

                        var translatedWord = command.ExecuteScalar();
                        result = translatedWord != null ? translatedWord.ToString() : $"[{input} tidak ditemukan dalam kamus]";
                    }
                }

                txtOutput.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error translating: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            string indoWord = txtIndoWord.Text.Trim().ToLower();
            string engWord = txtEngWord.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(indoWord) || string.IsNullOrEmpty(engWord))
            {
                MessageBox.Show("Masukkan kata dalam kedua bahasa", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand("sp_AddWord", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@indoWord", indoWord);
                        command.Parameters.AddWithValue("@engWord", engWord);

                        var returnParameter = command.Parameters.Add("ReturnVal", SqlDbType.Int);
                        returnParameter.Direction = ParameterDirection.ReturnValue;

                        command.ExecuteNonQuery();

                        int result = (int)returnParameter.Value;
                        if (result == 1)
                        {
                            MessageBox.Show("Kata berhasil ditambahkan ke kamus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtIndoWord.Clear();
                            txtEngWord.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Kata sudah ada dalam kamus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding word: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand("sp_GetAllWords", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (var adapter = new SqlDataAdapter(command))
                        {
                            var dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            var wordList = new System.Text.StringBuilder();
                            wordList.AppendLine("Daftar Kata dalam Kamus:");
                            wordList.AppendLine("------------------------");
                            wordList.AppendLine("Indonesia\t|\tInggris");
                            wordList.AppendLine("------------------------");

                            foreach (DataRow row in dataTable.Rows)
                            {
                                wordList.AppendLine($"{row["Indonesian"]}\t|\t{row["English"]}");
                            }

                            MessageBox.Show(wordList.ToString(), "Daftar Kata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing words: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim().ToLower();
            
            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Masukkan kata kunci pencarian", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                    SELECT Indonesian, English 
                    FROM Dictionary 
                    WHERE Indonesian LIKE @search OR English LIKE @search
                    ORDER BY Indonesian";
                    
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@search", $"%{searchTerm}%");
                        
                        using (var adapter = new SqlDataAdapter(command))
                        {
                            var dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count == 0)
                            {
                                MessageBox.Show("Tidak ditemukan kata yang sesuai", "Hasil Pencarian", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            var wordList = new System.Text.StringBuilder();
                            wordList.AppendLine("Hasil Pencarian:");
                            wordList.AppendLine("------------------------");
                            wordList.AppendLine("Indonesia\t|\tInggris");
                            wordList.AppendLine("------------------------");

                            foreach (DataRow row in dataTable.Rows)
                            {
                                wordList.AppendLine($"{row["Indonesian"]}\t|\t{row["English"]}");
                            }

                            MessageBox.Show(wordList.ToString(), "Hasil Pencarian", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}