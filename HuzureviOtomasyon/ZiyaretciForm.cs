using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace HuzureviOtomasyon
{
    public partial class ZiyaretciForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["HuzureviDb"].ConnectionString;

        public ZiyaretciForm()
        {
            InitializeComponent();
        }

        private void ZiyaretciForm_Load(object sender, EventArgs e)
        {
            HastaListesiniYukle();
            ZiyaretciListesiniYukle();
        }

        private void HastaListesiniYukle()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT hasta_id, ad + ' ' + soyad AS ad_soyad FROM hastalar", con);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                cmbHastaSec.DisplayMember = "ad_soyad";
                cmbHastaSec.ValueMember = "hasta_id";
                cmbHastaSec.DataSource = dt;

                con.Close();
            }
        }

        private void ZiyaretciListesiniYukle()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT z.ziyaretci_id, h.ad + ' ' + h.soyad AS hasta_adi, z.ad, z.soyad, z.ziyaret_tarihi " +
                    "FROM ziyaretciler z " +
                    "JOIN hastalar h ON z.hasta_id = h.hasta_id", con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvZiyaretciler.DataSource = dt;

                dgvZiyaretciler.Columns["ziyaretci_id"].Visible = false;
                dgvZiyaretciler.Columns["hasta_adi"].HeaderText = "Hasta Adı";
                dgvZiyaretciler.Columns["ad"].HeaderText = "Ziyaretçi Adı";
                dgvZiyaretciler.Columns["soyad"].HeaderText = "Ziyaretçi Soyadı";
                dgvZiyaretciler.Columns["ziyaret_tarihi"].HeaderText = "Ziyaret Tarihi";

                dgvZiyaretciler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvZiyaretciler.ReadOnly = true;
            }
        }

        private void btnZiyaretciEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO ziyaretciler (hasta_id, ad, soyad, ziyaret_tarihi)
                                     VALUES (@hasta_id, @ad, @soyad, @ziyaret_tarihi)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@hasta_id", cmbHastaSec.SelectedValue);
                    cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                    cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                    cmd.Parameters.AddWithValue("@ziyaret_tarihi", dtpZiyaretTarihi.Value.Date);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Ziyaretçi başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ZiyaretciListesiniYukle();
                    Temizle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnZiyaretciSil_Click(object sender, EventArgs e)
        {
            if (dgvZiyaretciler.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Seçilen ziyaretçiyi silmek istediğinize emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int ziyaretciId = Convert.ToInt32(dgvZiyaretciler.CurrentRow.Cells["ziyaretci_id"].Value);

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("DELETE FROM ziyaretciler WHERE ziyaretci_id = @ziyaretci_id", con);
                        cmd.Parameters.AddWithValue("@ziyaretci_id", ziyaretciId);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Ziyaretçi silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ZiyaretciListesiniYukle();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir ziyaretçi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Temizle()
        {
            cmbHastaSec.SelectedIndex = -1;
            txtAd.Text = "";
            txtSoyad.Text = "";
            dtpZiyaretTarihi.Value = DateTime.Now;
        }
    }
}
