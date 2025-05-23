namespace HuzureviOtomasyon
{
    partial class GorevliPanel
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
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnOdaIslemleri = new System.Windows.Forms.Button();
            this.btnSaglikIslemleri = new System.Windows.Forms.Button();
            this.btnIlacIslemleri = new System.Windows.Forms.Button();
            this.btnHastaIslemleri = new System.Windows.Forms.Button();
            this.bttnZiyaretci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Görevli Panel";
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(312, 354);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(185, 40);
            this.btnCikis.TabIndex = 10;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnOdaIslemleri
            // 
            this.btnOdaIslemleri.Location = new System.Drawing.Point(312, 266);
            this.btnOdaIslemleri.Name = "btnOdaIslemleri";
            this.btnOdaIslemleri.Size = new System.Drawing.Size(185, 38);
            this.btnOdaIslemleri.TabIndex = 9;
            this.btnOdaIslemleri.Text = "Oda İşlemleri";
            this.btnOdaIslemleri.UseVisualStyleBackColor = true;
            this.btnOdaIslemleri.Click += new System.EventHandler(this.btnOdaIslemleri_Click);
            // 
            // btnSaglikIslemleri
            // 
            this.btnSaglikIslemleri.Location = new System.Drawing.Point(312, 219);
            this.btnSaglikIslemleri.Name = "btnSaglikIslemleri";
            this.btnSaglikIslemleri.Size = new System.Drawing.Size(185, 41);
            this.btnSaglikIslemleri.TabIndex = 8;
            this.btnSaglikIslemleri.Text = "Sağlık Durumu";
            this.btnSaglikIslemleri.UseVisualStyleBackColor = true;
            this.btnSaglikIslemleri.Click += new System.EventHandler(this.btnSaglikIslemleri_Click);
            // 
            // btnIlacIslemleri
            // 
            this.btnIlacIslemleri.Location = new System.Drawing.Point(312, 168);
            this.btnIlacIslemleri.Name = "btnIlacIslemleri";
            this.btnIlacIslemleri.Size = new System.Drawing.Size(185, 45);
            this.btnIlacIslemleri.TabIndex = 7;
            this.btnIlacIslemleri.Text = "İlaç İşlemleri";
            this.btnIlacIslemleri.UseVisualStyleBackColor = true;
            this.btnIlacIslemleri.Click += new System.EventHandler(this.btnIlacIslemleri_Click);
            // 
            // btnHastaIslemleri
            // 
            this.btnHastaIslemleri.Location = new System.Drawing.Point(312, 123);
            this.btnHastaIslemleri.Name = "btnHastaIslemleri";
            this.btnHastaIslemleri.Size = new System.Drawing.Size(185, 39);
            this.btnHastaIslemleri.TabIndex = 6;
            this.btnHastaIslemleri.Text = "Hasta İşlemleri";
            this.btnHastaIslemleri.UseVisualStyleBackColor = true;
            this.btnHastaIslemleri.Click += new System.EventHandler(this.btnHastaIslemleri_Click);
            // 
            // bttnZiyaretci
            // 
            this.bttnZiyaretci.Location = new System.Drawing.Point(312, 310);
            this.bttnZiyaretci.Name = "bttnZiyaretci";
            this.bttnZiyaretci.Size = new System.Drawing.Size(185, 38);
            this.bttnZiyaretci.TabIndex = 12;
            this.bttnZiyaretci.Text = "Ziyaretçi İşlemleri";
            this.bttnZiyaretci.UseVisualStyleBackColor = true;
            this.bttnZiyaretci.Click += new System.EventHandler(this.bttnZiyaretci_Click);
            // 
            // GorevliPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnZiyaretci);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnOdaIslemleri);
            this.Controls.Add(this.btnSaglikIslemleri);
            this.Controls.Add(this.btnIlacIslemleri);
            this.Controls.Add(this.btnHastaIslemleri);
            this.Name = "GorevliPanel";
            this.Text = "GorevliPanel";
            this.Load += new System.EventHandler(this.GorevliPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnOdaIslemleri;
        private System.Windows.Forms.Button btnSaglikIslemleri;
        private System.Windows.Forms.Button btnIlacIslemleri;
        private System.Windows.Forms.Button btnHastaIslemleri;
        private System.Windows.Forms.Button bttnZiyaretci;
    }
}