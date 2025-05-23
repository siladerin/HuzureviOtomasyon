namespace HuzureviOtomasyon
{
    partial class ZiyaretciForm
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
            this.cmbHastaSec = new System.Windows.Forms.ComboBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.dtpZiyaretTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnZiyaretciEkle = new System.Windows.Forms.Button();
            this.btnZiyaretciSil = new System.Windows.Forms.Button();
            this.dgvZiyaretciler = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZiyaretciler)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbHastaSec
            // 
            this.cmbHastaSec.FormattingEnabled = true;
            this.cmbHastaSec.Location = new System.Drawing.Point(185, 108);
            this.cmbHastaSec.Name = "cmbHastaSec";
            this.cmbHastaSec.Size = new System.Drawing.Size(200, 24);
            this.cmbHastaSec.TabIndex = 0;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(185, 191);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 22);
            this.txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(185, 229);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(200, 22);
            this.txtSoyad.TabIndex = 2;
            // 
            // dtpZiyaretTarihi
            // 
            this.dtpZiyaretTarihi.Location = new System.Drawing.Point(185, 270);
            this.dtpZiyaretTarihi.Name = "dtpZiyaretTarihi";
            this.dtpZiyaretTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpZiyaretTarihi.TabIndex = 3;
            // 
            // btnZiyaretciEkle
            // 
            this.btnZiyaretciEkle.Location = new System.Drawing.Point(241, 317);
            this.btnZiyaretciEkle.Name = "btnZiyaretciEkle";
            this.btnZiyaretciEkle.Size = new System.Drawing.Size(75, 23);
            this.btnZiyaretciEkle.TabIndex = 4;
            this.btnZiyaretciEkle.Text = "Kayıt Ekle";
            this.btnZiyaretciEkle.UseVisualStyleBackColor = true;
            this.btnZiyaretciEkle.Click += new System.EventHandler(this.btnZiyaretciEkle_Click);
            // 
            // btnZiyaretciSil
            // 
            this.btnZiyaretciSil.Location = new System.Drawing.Point(559, 270);
            this.btnZiyaretciSil.Name = "btnZiyaretciSil";
            this.btnZiyaretciSil.Size = new System.Drawing.Size(75, 23);
            this.btnZiyaretciSil.TabIndex = 5;
            this.btnZiyaretciSil.Text = "Kayıt Sil";
            this.btnZiyaretciSil.UseVisualStyleBackColor = true;
            this.btnZiyaretciSil.Click += new System.EventHandler(this.btnZiyaretciSil_Click);
            // 
            // dgvZiyaretciler
            // 
            this.dgvZiyaretciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZiyaretciler.Location = new System.Drawing.Point(407, 101);
            this.dgvZiyaretciler.Name = "dgvZiyaretciler";
            this.dgvZiyaretciler.RowTemplate.Height = 24;
            this.dgvZiyaretciler.Size = new System.Drawing.Size(372, 150);
            this.dgvZiyaretciler.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hasta :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Soyad :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tarih :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ziyaretçi Bilgileri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ziyaretçi Bilgileri";
            // 
            // ZiyaretciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvZiyaretciler);
            this.Controls.Add(this.btnZiyaretciSil);
            this.Controls.Add(this.btnZiyaretciEkle);
            this.Controls.Add(this.dtpZiyaretTarihi);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.cmbHastaSec);
            this.Name = "ZiyaretciForm";
            this.Text = "ZiyaretçiForm";
            this.Load += new System.EventHandler(this.ZiyaretciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZiyaretciler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbHastaSec;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.DateTimePicker dtpZiyaretTarihi;
        private System.Windows.Forms.Button btnZiyaretciEkle;
        private System.Windows.Forms.Button btnZiyaretciSil;
        private System.Windows.Forms.DataGridView dgvZiyaretciler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}