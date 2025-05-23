namespace HuzureviOtomasyon
{
    partial class IlacForm
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
            this.txtIlacAdi = new System.Windows.Forms.TextBox();
            this.txtDozaj = new System.Windows.Forms.TextBox();
            this.btnIlacEkle = new System.Windows.Forms.Button();
            this.dgvIlaclar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIlaclar)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbHastaSec
            // 
            this.cmbHastaSec.FormattingEnabled = true;
            this.cmbHastaSec.Location = new System.Drawing.Point(166, 135);
            this.cmbHastaSec.Name = "cmbHastaSec";
            this.cmbHastaSec.Size = new System.Drawing.Size(172, 24);
            this.cmbHastaSec.TabIndex = 0;
            // 
            // txtIlacAdi
            // 
            this.txtIlacAdi.Location = new System.Drawing.Point(166, 177);
            this.txtIlacAdi.Name = "txtIlacAdi";
            this.txtIlacAdi.Size = new System.Drawing.Size(172, 22);
            this.txtIlacAdi.TabIndex = 1;
            // 
            // txtDozaj
            // 
            this.txtDozaj.Location = new System.Drawing.Point(166, 221);
            this.txtDozaj.Name = "txtDozaj";
            this.txtDozaj.Size = new System.Drawing.Size(172, 22);
            this.txtDozaj.TabIndex = 2;
            // 
            // btnIlacEkle
            // 
            this.btnIlacEkle.Location = new System.Drawing.Point(292, 316);
            this.btnIlacEkle.Name = "btnIlacEkle";
            this.btnIlacEkle.Size = new System.Drawing.Size(146, 38);
            this.btnIlacEkle.TabIndex = 3;
            this.btnIlacEkle.Text = "İlaçlar Listele";
            this.btnIlacEkle.UseVisualStyleBackColor = true;
            this.btnIlacEkle.Click += new System.EventHandler(this.btnIlacEkle_Click);
            // 
            // dgvIlaclar
            // 
            this.dgvIlaclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIlaclar.Location = new System.Drawing.Point(370, 116);
            this.dgvIlaclar.Name = "dgvIlaclar";
            this.dgvIlaclar.RowTemplate.Height = 24;
            this.dgvIlaclar.Size = new System.Drawing.Size(405, 150);
            this.dgvIlaclar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hasta :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dozaj Bilgisi  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "İlaç Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "İlaç Bilgisi";
            // 
            // IlacForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvIlaclar);
            this.Controls.Add(this.btnIlacEkle);
            this.Controls.Add(this.txtDozaj);
            this.Controls.Add(this.txtIlacAdi);
            this.Controls.Add(this.cmbHastaSec);
            this.Name = "IlacForm";
            this.Text = "IlacForm";
            this.Load += new System.EventHandler(this.IlacForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIlaclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbHastaSec;
        private System.Windows.Forms.TextBox txtIlacAdi;
        private System.Windows.Forms.TextBox txtDozaj;
        private System.Windows.Forms.Button btnIlacEkle;
        private System.Windows.Forms.DataGridView dgvIlaclar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}