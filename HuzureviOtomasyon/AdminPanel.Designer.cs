namespace HuzureviOtomasyon
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHastaIslemleri = new System.Windows.Forms.Button();
            this.btnGorevliIslemleri = new System.Windows.Forms.Button();
            this.btnOdaIslemleri = new System.Windows.Forms.Button();
            this.btnDoktorIslemleri = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHastaIslemleri
            // 
            this.btnHastaIslemleri.Location = new System.Drawing.Point(317, 112);
            this.btnHastaIslemleri.Name = "btnHastaIslemleri";
            this.btnHastaIslemleri.Size = new System.Drawing.Size(185, 39);
            this.btnHastaIslemleri.TabIndex = 0;
            this.btnHastaIslemleri.Text = "Hasta İşlemleri";
            this.btnHastaIslemleri.UseVisualStyleBackColor = true;
            this.btnHastaIslemleri.Click += new System.EventHandler(this.btnHastaIslemleri_Click);
            // 
            // btnGorevliIslemleri
            // 
            this.btnGorevliIslemleri.Location = new System.Drawing.Point(317, 157);
            this.btnGorevliIslemleri.Name = "btnGorevliIslemleri";
            this.btnGorevliIslemleri.Size = new System.Drawing.Size(185, 45);
            this.btnGorevliIslemleri.TabIndex = 1;
            this.btnGorevliIslemleri.Text = "Görevli İşlemleri";
            this.btnGorevliIslemleri.UseVisualStyleBackColor = true;
            this.btnGorevliIslemleri.Click += new System.EventHandler(this.btnGorevliIslemleri_Click);
            // 
            // btnOdaIslemleri
            // 
            this.btnOdaIslemleri.Location = new System.Drawing.Point(317, 208);
            this.btnOdaIslemleri.Name = "btnOdaIslemleri";
            this.btnOdaIslemleri.Size = new System.Drawing.Size(185, 41);
            this.btnOdaIslemleri.TabIndex = 2;
            this.btnOdaIslemleri.Text = "Oda İşlemleri";
            this.btnOdaIslemleri.UseVisualStyleBackColor = true;
            this.btnOdaIslemleri.Click += new System.EventHandler(this.btnOdaIslemleri_Click);
            // 
            // btnDoktorIslemleri
            // 
            this.btnDoktorIslemleri.Location = new System.Drawing.Point(317, 255);
            this.btnDoktorIslemleri.Name = "btnDoktorIslemleri";
            this.btnDoktorIslemleri.Size = new System.Drawing.Size(185, 38);
            this.btnDoktorIslemleri.TabIndex = 3;
            this.btnDoktorIslemleri.Text = "Doktor İşlemleri";
            this.btnDoktorIslemleri.UseVisualStyleBackColor = true;
            this.btnDoktorIslemleri.Click += new System.EventHandler(this.btnDoktorIslemleri_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(317, 299);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(185, 40);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Admin Panel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnDoktorIslemleri);
            this.Controls.Add(this.btnOdaIslemleri);
            this.Controls.Add(this.btnGorevliIslemleri);
            this.Controls.Add(this.btnHastaIslemleri);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHastaIslemleri;
        private System.Windows.Forms.Button btnGorevliIslemleri;
        private System.Windows.Forms.Button btnOdaIslemleri;
        private System.Windows.Forms.Button btnDoktorIslemleri;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label1;
    }
}