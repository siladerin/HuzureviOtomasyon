using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace HuzureviOtomasyon
{
    public partial class IlacForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["HuzureviDb"].ConnectionString;

        public IlacForm()
        {
            InitializeComponent();
        }

        private void IlacForm_Load(object sender, EventArgs e)
        {
            HastaListesiniYukle();
            IlacListesiniYukle();
        }

        private void HastaListesiniYukle()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT hasta_id, ad + ' ' + soyad AS ad_soyad FROM hastalar", con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                cmbHastaSec.DisplayMember = "ad_soyad";
                cmbHastaSec.ValueMember = "hasta_id";
                cmbHastaSec.DataSource = dt;

                con.Close();
            }
        }

        private void btnIlacEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO ilaclar (hasta_id, ilac_adi, dozaj) VALUES (@hasta_id, @ilac_adi, @dozaj)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@hasta_id", cmbHastaSec.SelectedValue);
                    cmd.Parameters.AddWithValue("@ilac_adi", txtIlacAdi.Text);
                    cmd.Parameters.AddWithValue("@dozaj", txtDozaj.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("İlaç başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IlacListesiniYukle();
                    Temizle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IlacListesiniYukle()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT i.ilac_id, h.ad + ' ' + h.soyad AS hasta_adi, i.ilac_adi, i.dozaj " +
                                                        "FROM ilaclar i " +
                                                        "JOIN hastalar h ON i.hasta_id = h.hasta_id", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvIlaclar.DataSource = dt;

                // Gereksiz kolonları gizle
                dgvIlaclar.Columns["ilac_id"].Visible = false;

                // Başlıkları düzenle
                dgvIlaclar.Columns["hasta_adi"].HeaderText = "Hasta Adı";
                dgvIlaclar.Columns["ilac_adi"].HeaderText = "İlaç Adı";
                dgvIlaclar.Columns["dozaj"].HeaderText = "Dozaj";

                // Kolon genişliklerini ayarla
                dgvIlaclar.Columns["hasta_adi"].Width = 150;
                dgvIlaclar.Columns["ilac_adi"].Width = 150;
                dgvIlaclar.Columns["dozaj"].Width = 100;

                // Sadece okuma moduna al
                dgvIlaclar.ReadOnly = true;

                // Satır bazlı seçim
                dgvIlaclar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }


        private void Temizle()
        {
            cmbHastaSec.SelectedIndex = -1;
            txtIlacAdi.Text = "";
            txtDozaj.Text = "";
        }
    }
}
