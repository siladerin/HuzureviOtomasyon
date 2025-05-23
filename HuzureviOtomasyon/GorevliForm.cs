using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace HuzureviOtomasyon
{
    public partial class GorevliForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["HuzureviDb"].ConnectionString;

        public GorevliForm()
        {
            InitializeComponent();
        }

        private void GorevliForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM bakicilar", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvGorevliler.DataSource = dt;

                if (dgvGorevliler.Columns.Contains("bakici_id"))
                    dgvGorevliler.Columns["bakici_id"].Visible = false;

                dgvGorevliler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvGorevliler.ReadOnly = true;
            }
        }

        private void Temizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTelefon.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO bakicilar (ad, soyad, telefon_no) 
                                 VALUES (@ad, @soyad, @telefon_no)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                cmd.Parameters.AddWithValue("@telefon_no", txtTelefon.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Görevli başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                Temizle();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvGorevliler.CurrentRow != null)
            {
                int bakiciId = Convert.ToInt32(dgvGorevliler.CurrentRow.Cells["bakici_id"].Value);

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE bakicilar 
                                     SET ad = @ad, soyad = @soyad, telefon_no = @telefon_no 
                                     WHERE bakici_id = @bakici_id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                    cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                    cmd.Parameters.AddWithValue("@telefon_no", txtTelefon.Text);
                    cmd.Parameters.AddWithValue("@bakici_id", bakiciId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Görevli bilgisi güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                    Temizle();
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvGorevliler.CurrentRow != null)
            {
                int bakiciId = Convert.ToInt32(dgvGorevliler.CurrentRow.Cells["bakici_id"].Value);

                DialogResult result = MessageBox.Show("Bu görevliliği silmek istediğinize emin misiniz?",
                                                      "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM bakicilar WHERE bakici_id = @bakici_id";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@bakici_id", bakiciId);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Görevli silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Listele();
                        Temizle();
                    }
                }
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele(); // Manuel listeleme butonu
        }

        private void dgvGorevliler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtAd.Text = dgvGorevliler.Rows[e.RowIndex].Cells["ad"].Value?.ToString();
                txtSoyad.Text = dgvGorevliler.Rows[e.RowIndex].Cells["soyad"].Value?.ToString();
                txtTelefon.Text = dgvGorevliler.Rows[e.RowIndex].Cells["telefon_no"].Value?.ToString();
            }
        }
    }
}
