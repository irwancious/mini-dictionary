namespace KamusMiniApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTerjemah = new System.Windows.Forms.TabPage();
            this.txtHasilTerjemah = new System.Windows.Forms.TextBox();
            this.btnTerjemah = new System.Windows.Forms.Button();
            this.rbInggris = new System.Windows.Forms.RadioButton();
            this.rbIndonesia = new System.Windows.Forms.RadioButton();
            this.txtTeksTerjemah = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageDaftarKata = new System.Windows.Forms.TabPage();
            // this.btnQuiz = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewKata = new System.Windows.Forms.DataGridView();
            // tabPageQuiz
            this.tabPageQuiz = new System.Windows.Forms.TabPage();
            this.lblSoalQuiz = new System.Windows.Forms.Label();
            this.rbOpsi1 = new System.Windows.Forms.RadioButton();
            this.rbOpsi2 = new System.Windows.Forms.RadioButton();
            this.rbOpsi3 = new System.Windows.Forms.RadioButton();
            this.rbOpsi4 = new System.Windows.Forms.RadioButton();
            this.btnSubmitQuiz = new System.Windows.Forms.Button();
            this.lblHasilQuiz = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageTerjemah.SuspendLayout();
            this.tabPageDaftarKata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKata)).BeginInit();
            this.SuspendLayout();
            
            // tabControl1
            this.tabControl1.Controls.Add(this.tabPageTerjemah);
            this.tabControl1.Controls.Add(this.tabPageDaftarKata);
            this.tabControl1.Controls.Add(this.tabPageQuiz);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            
            // tabPageTerjemah
            this.tabPageTerjemah.Controls.Add(this.txtHasilTerjemah);
            this.tabPageTerjemah.Controls.Add(this.btnTerjemah);
            this.tabPageTerjemah.Controls.Add(this.rbInggris);
            this.tabPageTerjemah.Controls.Add(this.rbIndonesia);
            this.tabPageTerjemah.Controls.Add(this.txtTeksTerjemah);
            this.tabPageTerjemah.Controls.Add(this.label1);
            this.tabPageTerjemah.Location = new System.Drawing.Point(4, 24);
            this.tabPageTerjemah.Name = "tabPageTerjemah";
            this.tabPageTerjemah.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTerjemah.Size = new System.Drawing.Size(792, 422);
            this.tabPageTerjemah.TabIndex = 0;
            this.tabPageTerjemah.Text = "Terjemah";
            this.tabPageTerjemah.UseVisualStyleBackColor = true;
            
            // txtHasilTerjemah
            this.txtHasilTerjemah.Location = new System.Drawing.Point(20, 150);
            this.txtHasilTerjemah.Multiline = true;
            this.txtHasilTerjemah.Name = "txtHasilTerjemah";
            this.txtHasilTerjemah.ReadOnly = true;
            this.txtHasilTerjemah.Size = new System.Drawing.Size(750, 100);
            this.txtHasilTerjemah.TabIndex = 5;
            
            // btnTerjemah
            this.btnTerjemah.Location = new System.Drawing.Point(20, 100);
            this.btnTerjemah.Name = "btnTerjemah";
            this.btnTerjemah.Size = new System.Drawing.Size(100, 30);
            this.btnTerjemah.TabIndex = 4;
            this.btnTerjemah.Text = "Terjemahkan";
            this.btnTerjemah.UseVisualStyleBackColor = true;
            this.btnTerjemah.Click += new System.EventHandler(this.btnTerjemah_Click);
            
            // rbInggris
            this.rbInggris.AutoSize = true;
            this.rbInggris.Location = new System.Drawing.Point(150, 60);
            this.rbInggris.Name = "rbInggris";
            this.rbInggris.Size = new System.Drawing.Size(141, 19);
            this.rbInggris.TabIndex = 3;
            this.rbInggris.Text = "Inggris -> Indonesia";
            this.rbInggris.UseVisualStyleBackColor = true;
            
            // rbIndonesia
            this.rbIndonesia.AutoSize = true;
            this.rbIndonesia.Checked = true;
            this.rbIndonesia.Location = new System.Drawing.Point(20, 60);
            this.rbIndonesia.Name = "rbIndonesia";
            this.rbIndonesia.Size = new System.Drawing.Size(141, 19);
            this.rbIndonesia.TabIndex = 2;
            this.rbIndonesia.TabStop = true;
            this.rbIndonesia.Text = "Indonesia -> Inggris";
            this.rbIndonesia.UseVisualStyleBackColor = true;
            
            // txtTeksTerjemah
            this.txtTeksTerjemah.Location = new System.Drawing.Point(20, 30);
            this.txtTeksTerjemah.Name = "txtTeksTerjemah";
            this.txtTeksTerjemah.Size = new System.Drawing.Size(750, 23);
            this.txtTeksTerjemah.TabIndex = 1;
            
            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masukkan Teks:";
            
            // tabPageDaftarKata
            // this.tabPageDaftarKata.Controls.Add(this.btnQuiz);
            this.tabPageDaftarKata.Controls.Add(this.btnHapus);
            this.tabPageDaftarKata.Controls.Add(this.btnEdit);
            this.tabPageDaftarKata.Controls.Add(this.btnTambah);
            this.tabPageDaftarKata.Controls.Add(this.btnCari);
            this.tabPageDaftarKata.Controls.Add(this.txtCari);
            this.tabPageDaftarKata.Controls.Add(this.label2);
            this.tabPageDaftarKata.Controls.Add(this.dataGridViewKata);
            this.tabPageDaftarKata.Location = new System.Drawing.Point(4, 24);
            this.tabPageDaftarKata.Name = "tabPageDaftarKata";
            this.tabPageDaftarKata.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDaftarKata.Size = new System.Drawing.Size(792, 422);
            this.tabPageDaftarKata.TabIndex = 1;
            this.tabPageDaftarKata.Text = "Daftar Kata";
            this.tabPageDaftarKata.UseVisualStyleBackColor = true;
            
            // btnQuiz
            // this.btnQuiz.Location = new System.Drawing.Point(700, 20);
            // this.btnQuiz.Name = "btnQuiz";
            // this.btnQuiz.Size = new System.Drawing.Size(80, 30);
            // this.btnQuiz.TabIndex = 6;
            // this.btnQuiz.Text = "Quiz";
            // this.btnQuiz.UseVisualStyleBackColor = true;
            // this.btnQuiz.Click += new System.EventHandler(this.btnQuiz_Click);
            
            // btnHapus
            this.btnHapus.Location = new System.Drawing.Point(600, 20);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(80, 30);
            this.btnHapus.TabIndex = 5;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            
            // btnEdit
            this.btnEdit.Location = new System.Drawing.Point(500, 20);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 30);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            
            // btnTambah
            this.btnTambah.Location = new System.Drawing.Point(400, 20);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(80, 30);
            this.btnTambah.TabIndex = 3;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);

            // btnCari
            // this.btnCari = new System.Windows.Forms.Button();
            this.btnCari.Location = new System.Drawing.Point(300, 20);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(80, 30);
            this.btnCari.TabIndex = 8;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            
            
            // txtCari
            this.txtCari.Location = new System.Drawing.Point(80, 25);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(200, 23);
            this.txtCari.TabIndex = 2;
            
            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cari Kata:";
            
            // dataGridViewKata
            this.dataGridViewKata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewKata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKata.Location = new System.Drawing.Point(20, 60);
            this.dataGridViewKata.Name = "dataGridViewKata";
            this.dataGridViewKata.RowTemplate.Height = 25;
            this.dataGridViewKata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKata.Size = new System.Drawing.Size(750, 350);
            this.dataGridViewKata.TabIndex = 0;

            // tabPageQuiz
            this.tabPageQuiz.Controls.Add(this.lblHasilQuiz);
            this.tabPageQuiz.Controls.Add(this.btnSubmitQuiz);
            this.tabPageQuiz.Controls.Add(this.rbOpsi4);
            this.tabPageQuiz.Controls.Add(this.rbOpsi3);
            this.tabPageQuiz.Controls.Add(this.rbOpsi2);
            this.tabPageQuiz.Controls.Add(this.rbOpsi1);
            this.tabPageQuiz.Controls.Add(this.lblSoalQuiz);
            this.tabPageQuiz.Location = new System.Drawing.Point(4, 24);
            this.tabPageQuiz.Name = "tabPageQuiz";
            this.tabPageQuiz.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQuiz.Size = new System.Drawing.Size(792, 422);
            this.tabPageQuiz.TabIndex = 2;
            this.tabPageQuiz.Text = "Quiz";
            this.tabPageQuiz.UseVisualStyleBackColor = true;

            // Komponen Quiz
            this.lblSoalQuiz.AutoSize = true;
            this.lblSoalQuiz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoalQuiz.Location = new System.Drawing.Point(20, 20);
            this.lblSoalQuiz.Name = "lblSoalQuiz";
            this.lblSoalQuiz.Size = new System.Drawing.Size(52, 21);
            this.lblSoalQuiz.TabIndex = 0;
            this.lblSoalQuiz.Text = "Soal: ";
            
            // this.rbOpsi1.AutoSize = true;
            // this.rbOpsi1.Location = new System.Drawing.Point(20, 60);
            // this.rbOpsi1.Name = "rbOpsi1";
            // this.rbOpsi1.Size = new System.Drawing.Size(94, 19);
            // this.rbOpsi1.TabIndex = 1;
            // this.rbOpsi1.TabStop = true;
            // this.rbOpsi1.Text = "radioButton1";
            // this.rbOpsi1.UseVisualStyleBackColor = true;

            // rbOpsi1
            this.rbOpsi1.AutoSize = true;
            this.rbOpsi1.Location = new System.Drawing.Point(20, 60);
            this.rbOpsi1.Name = "rbOpsi1";
            this.rbOpsi1.Size = new System.Drawing.Size(94, 19);
            this.rbOpsi1.TabIndex = 1;
            this.rbOpsi1.TabStop = true;
            this.rbOpsi1.Text = "radioButton1";
            this.rbOpsi1.UseVisualStyleBackColor = true;
            
            // rbOpsi2
            this.rbOpsi2.AutoSize = true;
            this.rbOpsi2.Location = new System.Drawing.Point(20, 90);
            this.rbOpsi2.Name = "rbOpsi2";
            this.rbOpsi2.Size = new System.Drawing.Size(94, 19);
            this.rbOpsi2.TabIndex = 2;
            this.rbOpsi2.TabStop = true;
            this.rbOpsi2.Text = "radioButton2";
            this.rbOpsi2.UseVisualStyleBackColor = true;
            
            // rbOpsi3
            this.rbOpsi3.AutoSize = true;
            this.rbOpsi3.Location = new System.Drawing.Point(20, 120);
            this.rbOpsi3.Name = "rbOpsi3";
            this.rbOpsi3.Size = new System.Drawing.Size(94, 19);
            this.rbOpsi3.TabIndex = 3;
            this.rbOpsi3.TabStop = true;
            this.rbOpsi3.Text = "radioButton3";
            this.rbOpsi3.UseVisualStyleBackColor = true;
            
            // rbOpsi4
            this.rbOpsi4.AutoSize = true;
            this.rbOpsi4.Location = new System.Drawing.Point(20, 150);
            this.rbOpsi4.Name = "rbOpsi4";
            this.rbOpsi4.Size = new System.Drawing.Size(94, 19);
            this.rbOpsi4.TabIndex = 4;
            this.rbOpsi4.TabStop = true;
            this.rbOpsi4.Text = "radioButton4";
            this.rbOpsi4.UseVisualStyleBackColor = true;
            
            // rbOpsi2, rbOpsi3, rbOpsi4 konfigurasi serupa...
            
            this.btnSubmitQuiz.Location = new System.Drawing.Point(20, 190);
            this.btnSubmitQuiz.Name = "btnSubmitQuiz";
            this.btnSubmitQuiz.Size = new System.Drawing.Size(100, 30);
            this.btnSubmitQuiz.TabIndex = 5;
            this.btnSubmitQuiz.Text = "Submit";
            this.btnSubmitQuiz.UseVisualStyleBackColor = true;
            this.btnSubmitQuiz.Click += new System.EventHandler(this.btnSubmitQuiz_Click);
            
            this.lblHasilQuiz.AutoSize = true;
            this.lblHasilQuiz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHasilQuiz.Location = new System.Drawing.Point(150, 195);
            this.lblHasilQuiz.Name = "lblHasilQuiz";
            this.lblHasilQuiz.Size = new System.Drawing.Size(0, 21);
            this.lblHasilQuiz.TabIndex = 6;
            
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Kamus Mini App";
            this.tabControl1.ResumeLayout(false);
            this.tabPageTerjemah.ResumeLayout(false);
            this.tabPageTerjemah.PerformLayout();
            this.tabPageDaftarKata.ResumeLayout(false);
            this.tabPageDaftarKata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKata)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTerjemah;
        private System.Windows.Forms.TabPage tabPageDaftarKata;
        private System.Windows.Forms.TextBox txtHasilTerjemah;
        private System.Windows.Forms.Button btnTerjemah;
        private System.Windows.Forms.RadioButton rbInggris;
        private System.Windows.Forms.RadioButton rbIndonesia;
        private System.Windows.Forms.TextBox txtTeksTerjemah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewKata;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        // private System.Windows.Forms.Button btnQuiz;

        private System.Windows.Forms.TabPage tabPageQuiz;
        private System.Windows.Forms.Label lblSoalQuiz;
        private System.Windows.Forms.RadioButton rbOpsi1;
        private System.Windows.Forms.RadioButton rbOpsi2;
        private System.Windows.Forms.RadioButton rbOpsi3;
        private System.Windows.Forms.RadioButton rbOpsi4;
        private System.Windows.Forms.Button btnSubmitQuiz;
        private System.Windows.Forms.Label lblHasilQuiz;
    }
}