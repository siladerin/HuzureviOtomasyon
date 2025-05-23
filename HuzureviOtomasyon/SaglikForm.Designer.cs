namespace HuzureviOtomasyon
{
    partial class SaglikForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHastaSec = new System.Windows.Forms.ComboBox();
            this.btnSaglikKaydet = new System.Windows.Forms.Button();
            this.dgvSaglik = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDoktorSec = new System.Windows.Forms.ComboBox();
            this.cmbHastalikSec = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDurumAciklama = new System.Windows.Forms.TextBox();
            this.btnSaglikSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaglik)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mevcut Hastanın Hastalık Bilgileri";
            // 
            // cmbHastaSec
            // 
            this.cmbHastaSec.FormattingEnabled = true;
            this.cmbHastaSec.Location = new System.Drawing.Point(147, 137);
            this.cmbHastaSec.Name = "cmbHastaSec";
            this.cmbHastaSec.Size = new System.Drawing.Size(157, 24);
            this.cmbHastaSec.TabIndex = 1;
            // 
            // btnSaglikKaydet
            // 
            this.btnSaglikKaydet.Location = new System.Drawing.Point(182, 333);
            this.btnSaglikKaydet.Name = "btnSaglikKaydet";
            this.btnSaglikKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnSaglikKaydet.TabIndex = 4;
            this.btnSaglikKaydet.Text = "Kaydet";
            this.btnSaglikKaydet.UseVisualStyleBackColor = true;
            this.btnSaglikKaydet.Click += new System.EventHandler(this.btnSaglikKaydet_Click);
            // 
            // dgvSaglik
            // 
            this.dgvSaglik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaglik.Location = new System.Drawing.Point(348, 119);
            this.dgvSaglik.Name = "dgvSaglik";
            this.dgvSaglik.RowTemplate.Height = 24;
            this.dgvSaglik.Size = new System.Drawing.Size(431, 150);
            this.dgvSaglik.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hasta :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Doktor :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hastalık :";
            // 
            // cmbDoktorSec
            // 
            this.cmbDoktorSec.FormattingEnabled = true;
            this.cmbDoktorSec.Location = new System.Drawing.Point(147, 184);
            this.cmbDoktorSec.Name = "cmbDoktorSec";
            this.cmbDoktorSec.Size = new System.Drawing.Size(157, 24);
            this.cmbDoktorSec.TabIndex = 9;
            // 
            // cmbHastalikSec
            // 
            this.cmbHastalikSec.FormattingEnabled = true;
            this.cmbHastalikSec.Location = new System.Drawing.Point(147, 234);
            this.cmbHastalikSec.Name = "cmbHastalikSec";
            this.cmbHastalikSec.Size = new System.Drawing.Size(157, 24);
            this.cmbHastalikSec.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Açıklama :";
            // 
            // txtDurumAciklama
            // 
            this.txtDurumAciklama.Location = new System.Drawing.Point(147, 281);
            this.txtDurumAciklama.Name = "txtDurumAciklama";
            this.txtDurumAciklama.Size = new System.Drawing.Size(157, 22);
            this.txtDurumAciklama.TabIndex = 12;
            // 
            // btnSaglikSil
            // 
            this.btnSaglikSil.Location = new System.Drawing.Point(530, 294);
            this.btnSaglikSil.Name = "btnSaglikSil";
            this.btnSaglikSil.Size = new System.Drawing.Size(75, 23);
            this.btnSaglikSil.TabIndex = 13;
            this.btnSaglikSil.Text = "Kayıt Sil";
            this.btnSaglikSil.UseVisualStyleBackColor = true;
            this.btnSaglikSil.Click += new System.EventHandler(this.btnSaglikSil_Click);
            // 
            // SaglikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaglikSil);
            this.Controls.Add(this.txtDurumAciklama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbHastalikSec);
            this.Controls.Add(this.cmbDoktorSec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSaglik);
            this.Controls.Add(this.btnSaglikKaydet);
            this.Controls.Add(this.cmbHastaSec);
            this.Controls.Add(this.label1);
            this.Name = "SaglikForm";
            this.Text = "SaglikForm";
            this.Load += new System.EventHandler(this.SaglikForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaglik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHastaSec;
        private System.Windows.Forms.Button btnSaglikKaydet;
        private System.Windows.Forms.DataGridView dgvSaglik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDoktorSec;
        private System.Windows.Forms.ComboBox cmbHastalikSec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDurumAciklama;
        private System.Windows.Forms.Button btnSaglikSil;
    }
}