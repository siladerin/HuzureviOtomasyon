using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace HuzureviOtomasyon
{
    public partial class OdaForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["HuzureviDb"].ConnectionString;
        private string kullaniciRol;

        public OdaForm(string rol)
        {
            InitializeComponent();
            kullaniciRol = rol;
        }


        private void OdaForm_Load(object sender, EventArgs e)
        {
            Listele();

            if (kullaniciRol == "Görevli")
            {
                btnOdaEkle.Enabled = false;
                btnOdaSil.Enabled = false;
                btnListele.Enabled = false;
                txtOdaNo.Enabled = false;
                label2.Enabled = false;
            }
        }


        private void Listele()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                o.oda_id, 
                o.oda_numarasi AS 'Oda Numarası',
                ISNULL((SELECT STRING_AGG(h.ad + ' ' + h.soyad, ', ') 
                        FROM hastalar h 
                        WHERE h.oda_id = o.oda_id), 'Boş') AS 'Hasta Bilgisi'
            FROM odalar o";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOdalar.DataSource = dt;

                dgvOdalar.Columns["oda_id"].Visible = false;
                dgvOdalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvOdalar.ReadOnly = true;
            }
        }

        private void Temizle()
        {
            txtOdaNo.Text = "";
        }


        private void btnOdaEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO odalar (oda_numarasi) VALUES (@oda_numarasi)", con);
                    cmd.Parameters.AddWithValue("@oda_numarasi", txtOdaNo.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Oda başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listele();
                    Temizle();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                    MessageBox.Show("Bu oda numarası zaten kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void btnOdaSil_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOdaNo.Text))
            {
                DialogResult result = MessageBox.Show($"Oda {txtOdaNo.Text} silinecek. Bu odadaki hastalar boşa çıkarılacak. Emin misiniz?",
                                                      "Oda Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        try
                        {
                            con.Open();

                            // 1. Adım: Oda numarasına göre oda_id'yi bul
                            SqlCommand findCmd = new SqlCommand("SELECT oda_id FROM odalar WHERE oda_numarasi = @oda_numarasi", con);
                            findCmd.Parameters.AddWithValue("@oda_numarasi", txtOdaNo.Text);
                            object odaIdObj = findCmd.ExecuteScalar();

                            if (odaIdObj != null)
                            {
                                int odaId = Convert.ToInt32(odaIdObj);

                                // 2. Adım: Bu odadaki hastaların oda_id'sini NULL yap
                                SqlCommand updateCmd = new SqlCommand(
                                    "UPDATE hastalar SET oda_id = NULL WHERE oda_id = @oda_id", con);
                                updateCmd.Parameters.AddWithValue("@oda_id", odaId);
                                updateCmd.ExecuteNonQuery();

                                // 3. Adım: Odayı sil
                                SqlCommand deleteCmd = new SqlCommand(
                                    "DELETE FROM odalar WHERE oda_id = @oda_id", con);
                                deleteCmd.Parameters.AddWithValue("@oda_id", odaId);
                                deleteCmd.ExecuteNonQuery();

                                MessageBox.Show($"Oda {txtOdaNo.Text} başarıyla silindi ve hastalar boşa çıkarıldı.", "Bilgi",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Listele();
                                Temizle();
                            }
                            else
                            {
                                MessageBox.Show($"Oda {txtOdaNo.Text} bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Silme Hatası: " + ex.Message);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir oda numarası girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void dgvOdalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtOdaNo.Text = dgvOdalar.Rows[e.RowIndex].Cells["oda_numarasi"].Value?.ToString();
            }
        }
    }
}
