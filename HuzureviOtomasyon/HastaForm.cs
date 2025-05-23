using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace HuzureviOtomasyon
{
    public partial class HastaForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["HuzureviDb"].ConnectionString;

        public HastaForm()
        {
            InitializeComponent();
        }

        private void HastaForm_Load(object sender, EventArgs e)
        {
            Listele();
            OdaListesiniYukle();
        }
        private void btnHastaSil_Click(object sender, EventArgs e)
        {
            if (dgvHastalar.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Bu hastayı ve ona ait tüm kayıtları silmek istediğinizden emin misiniz?",
                                                       "Hasta Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int hastaId = Convert.ToInt32(dgvHastalar.CurrentRow.Cells["hasta_id"].Value);

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        // 1. İlişkili sağlık bilgilerini sil
                        SqlCommand cmd1 = new SqlCommand("DELETE FROM hasta_saglik_durumu WHERE hasta_id = @hasta_id", con);
                        cmd1.Parameters.AddWithValue("@hasta_id", hastaId);
                        cmd1.ExecuteNonQuery();

                        // 2. İlişkili ilaç kayıtlarını sil
                        SqlCommand cmd2 = new SqlCommand("DELETE FROM ilaclar WHERE hasta_id = @hasta_id", con);
                        cmd2.Parameters.AddWithValue("@hasta_id", hastaId);
                        cmd2.ExecuteNonQuery();

                        // 3. Hastayı sil
                        SqlCommand cmd3 = new SqlCommand("DELETE FROM hastalar WHERE hasta_id = @hasta_id", con);
                        cmd3.Parameters.AddWithValue("@hasta_id", hastaId);
                        cmd3.ExecuteNonQuery();

                        con.Close();

                        MessageBox.Show("Hasta ve tüm ilişkili veriler silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Listele();
                        Temizle();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir hasta seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void OdaListesiniYukle()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT oda_id, oda_numarasi FROM odalar", con);
                SqlDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(dr);

                cmbOdaSec.DisplayMember = "oda_numarasi"; // Kullanıcıya gösterilecek
                cmbOdaSec.ValueMember = "oda_id";         // Veritabanına gönderilecek
                cmbOdaSec.DataSource = dt;

                con.Close();
            }
        }

        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO hastalar (ad, soyad, dogum_tarihi, tc_numarasi, oda_id, kabul_tarihi) " +
                                   "VALUES (@ad, @soyad, @dogum_tarihi, @tc_numarasi, @oda_id, @kabul_tarihi)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                    cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                    cmd.Parameters.AddWithValue("@dogum_tarihi", dtpDogumTarihi.Value);
                    cmd.Parameters.AddWithValue("@tc_numarasi", txtTc.Text);
                    cmd.Parameters.AddWithValue("@oda_id", cmbOdaSec.SelectedValue); // Oda seçimi buradan geliyor
                    cmd.Parameters.AddWithValue("@kabul_tarihi", DateTime.Now);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Hasta başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                    Temizle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnHastaGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvHastalar.CurrentRow != null)
            {
                int hastaId = Convert.ToInt32(dgvHastalar.CurrentRow.Cells["hasta_id"].Value);

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "UPDATE hastalar SET ad = @ad, soyad = @soyad, dogum_tarihi = @dogum_tarihi, tc_numarasi = @tc_numarasi, oda_id = @oda_id WHERE hasta_id = @hasta_id";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                    cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                    cmd.Parameters.AddWithValue("@dogum_tarihi", dtpDogumTarihi.Value);
                    cmd.Parameters.AddWithValue("@tc_numarasi", txtTc.Text);
                    cmd.Parameters.AddWithValue("@oda_id", cmbOdaSec.SelectedValue); // ComboBox'tan seçilen oda
                    cmd.Parameters.AddWithValue("@hasta_id", hastaId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Hasta bilgileri güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                    Temizle();
                }
            }
        }

        private void dgvHastalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHastalar.Rows[e.RowIndex];

                txtAd.Text = row.Cells["ad"].Value?.ToString();
                txtSoyad.Text = row.Cells["soyad"].Value?.ToString();
                txtTc.Text = row.Cells["tc_numarasi"].Value?.ToString();
                dtpDogumTarihi.Value = Convert.ToDateTime(row.Cells["dogum_tarihi"].Value);
                cmbOdaSec.SelectedValue = row.Cells["oda_id"].Value; // Seçili oda gelsin
            }
        }

        private void Listele()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM hastalar", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvHastalar.DataSource = dt;
                    dgvHastalar.Columns["hasta_id"].Visible = false;
                    dgvHastalar.Columns["oda_id"].Visible = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Temizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTc.Text = "";
            dtpDogumTarihi.Value = DateTime.Now;
            cmbOdaSec.SelectedIndex = -1;
        }
    }
}
