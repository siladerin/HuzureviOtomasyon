using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace HuzureviOtomasyon
{
    public partial class SaglikForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["HuzureviDb"].ConnectionString;

        public SaglikForm()
        {
            InitializeComponent();
        }

        private void SaglikForm_Load(object sender, EventArgs e)
        {
            HastaListesiniYukle();
            DoktorListesiniYukle();
            HastalikListesiniYukle();
            SaglikListesiniYukle();
        }

        private void HastaListesiniYukle()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT hasta_id, ad + ' ' + soyad AS hasta_adi FROM hastalar", con);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                cmbHastaSec.DisplayMember = "hasta_adi";
                cmbHastaSec.ValueMember = "hasta_id";
                cmbHastaSec.DataSource = dt;

                con.Close();
            }
        }

        private void DoktorListesiniYukle()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT doktor_id, ad + ' ' + soyad AS doktor_adi FROM doktorlar", con);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                cmbDoktorSec.DisplayMember = "doktor_adi";
                cmbDoktorSec.ValueMember = "doktor_id";
                cmbDoktorSec.DataSource = dt;

                con.Close();
            }
        }
        private void btnSaglikSil_Click(object sender, EventArgs e)
        {
            if (dgvSaglik.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Seçilen sağlık bilgisini silmek istediğinizden emin misiniz?",
                                                       "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int kayitId = Convert.ToInt32(dgvSaglik.CurrentRow.Cells["kayit_id"].Value);

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM hasta_saglik_durumu WHERE kayit_id = @kayit_id";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@kayit_id", kayitId);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Sağlık bilgisi silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SaglikListesiniYukle();
                    }
                }
            }
        }


        private void HastalikListesiniYukle()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT hastalik_id, hastalik_adi FROM hastaliklar", con);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                cmbHastalikSec.DisplayMember = "hastalik_adi";
                cmbHastalikSec.ValueMember = "hastalik_id";
                cmbHastalikSec.DataSource = dt;

                con.Close();
            }
        }

        private void btnSaglikKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO hasta_saglik_durumu 
                        (hasta_id, doktor_id, hastalik_id, saglik_durumu)
                        VALUES (@hasta_id, @doktor_id, @hastalik_id, @saglik_durumu)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@hasta_id", cmbHastaSec.SelectedValue);
                    cmd.Parameters.AddWithValue("@doktor_id", cmbDoktorSec.SelectedValue);
                    cmd.Parameters.AddWithValue("@hastalik_id", cmbHastalikSec.SelectedValue);
                    cmd.Parameters.AddWithValue("@saglik_durumu", txtDurumAciklama.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Sağlık durumu kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SaglikListesiniYukle();
                    Temizle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaglikListesiniYukle()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT s.kayit_id,
                           h.ad + ' ' + h.soyad AS hasta_adi,
                           d.ad + ' ' + d.soyad AS doktor_adi,
                           ha.hastalik_adi,
                           s.saglik_durumu
                    FROM hasta_saglik_durumu s
                    JOIN hastalar h ON s.hasta_id = h.hasta_id
                    JOIN doktorlar d ON s.doktor_id = d.doktor_id
                    JOIN hastaliklar ha ON s.hastalik_id = ha.hastalik_id";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSaglik.DataSource = dt;

                dgvSaglik.Columns["kayit_id"].Visible = false;
                dgvSaglik.Columns["hasta_adi"].HeaderText = "Hasta";
                dgvSaglik.Columns["doktor_adi"].HeaderText = "Doktor";
                dgvSaglik.Columns["hastalik_adi"].HeaderText = "Hastalık";
                dgvSaglik.Columns["saglik_durumu"].HeaderText = "Durum";

                dgvSaglik.ReadOnly = true;
                dgvSaglik.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        private void Temizle()
        {
            cmbHastaSec.SelectedIndex = -1;
            cmbDoktorSec.SelectedIndex = -1;
            cmbHastalikSec.SelectedIndex = -1;
            txtDurumAciklama.Text = "";
        }
    }
}
