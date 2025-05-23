using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace HuzureviOtomasyon
{
    public partial class DoktorForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["HuzureviDb"].ConnectionString;

        public DoktorForm()
        {
            InitializeComponent();
        }

        private void DoktorForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM doktorlar", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDoktorlar.DataSource = dt;

                if (dgvDoktorlar.Columns.Contains("doktor_id"))
                    dgvDoktorlar.Columns["doktor_id"].Visible = false;

                dgvDoktorlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvDoktorlar.ReadOnly = true;
            }
        }

        private void Temizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtUzmanlik.Text = "";
            txtTelefon.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO doktorlar (ad, soyad, uzmanlik, telefon_no)
                                 VALUES (@ad, @soyad, @uzmanlik, @telefon_no)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                cmd.Parameters.AddWithValue("@uzmanlik", txtUzmanlik.Text);
                cmd.Parameters.AddWithValue("@telefon_no", txtTelefon.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Doktor başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                Temizle();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvDoktorlar.CurrentRow != null)
            {
                int doktorId = Convert.ToInt32(dgvDoktorlar.CurrentRow.Cells["doktor_id"].Value);

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE doktorlar 
                                     SET ad = @ad, soyad = @soyad, uzmanlik = @uzmanlik, telefon_no = @telefon_no 
                                     WHERE doktor_id = @doktor_id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                    cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                    cmd.Parameters.AddWithValue("@uzmanlik", txtUzmanlik.Text);
                    cmd.Parameters.AddWithValue("@telefon_no", txtTelefon.Text);
                    cmd.Parameters.AddWithValue("@doktor_id", doktorId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Doktor bilgisi güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                    Temizle();
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvDoktorlar.CurrentRow != null)
            {
                int doktorId = Convert.ToInt32(dgvDoktorlar.CurrentRow.Cells["doktor_id"].Value);

                DialogResult result = MessageBox.Show("Bu doktoru silmek istediğinize emin misiniz?",
                                                      "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM doktorlar WHERE doktor_id = @doktor_id";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@doktor_id", doktorId);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Doktor silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Listele();
                        Temizle();
                    }
                }
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void dgvDoktorlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtAd.Text = dgvDoktorlar.Rows[e.RowIndex].Cells["ad"].Value?.ToString();
                txtSoyad.Text = dgvDoktorlar.Rows[e.RowIndex].Cells["soyad"].Value?.ToString();
                txtUzmanlik.Text = dgvDoktorlar.Rows[e.RowIndex].Cells["uzmanlik"].Value?.ToString();
                txtTelefon.Text = dgvDoktorlar.Rows[e.RowIndex].Cells["telefon_no"].Value?.ToString();
            }
        }
    }
}
