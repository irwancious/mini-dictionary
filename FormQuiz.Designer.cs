namespace KamusMiniApp
{
    partial class FormQuiz
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
            this.lblSoal = new System.Windows.Forms.Label();
            this.rbOpsi1 = new System.Windows.Forms.RadioButton();
            this.rbOpsi2 = new System.Windows.Forms.RadioButton();
            this.rbOpsi3 = new System.Windows.Forms.RadioButton();
            this.rbOpsi4 = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            // lblSoal
            this.lblSoal.AutoSize = true;
            this.lblSoal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoal.Location = new System.Drawing.Point(20, 20);
            this.lblSoal.Name = "lblSoal";
            this.lblSoal.Size = new System.Drawing.Size(52, 21);
            this.lblSoal.TabIndex = 0;
            this.lblSoal.Text = "label1";
            
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
            
            // btnSubmit
            this.btnSubmit.Location = new System.Drawing.Point(20, 190);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 30);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            
            // FormQuiz
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 240);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rbOpsi4);
            this.Controls.Add(this.rbOpsi3);
            this.Controls.Add(this.rbOpsi2);
            this.Controls.Add(this.rbOpsi1);
            this.Controls.Add(this.lblSoal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kuis Kamus";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblSoal;
        private System.Windows.Forms.RadioButton rbOpsi1;
        private System.Windows.Forms.RadioButton rbOpsi2;
        private System.Windows.Forms.RadioButton rbOpsi3;
        private System.Windows.Forms.RadioButton rbOpsi4;
        private System.Windows.Forms.Button btnSubmit;
    }
}