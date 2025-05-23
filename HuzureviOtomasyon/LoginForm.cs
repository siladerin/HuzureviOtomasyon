using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace HuzureviOtomasyon
{
    public partial class LoginForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["HuzureviDb"].ConnectionString;

        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Şu anlık boş bırakabilirsin, bir şey yapmasına gerek yok
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tc = txtTc.Text.Trim();
            string sifre = txtSifre.Text.Trim();
            string rol = cmbRol.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(tc) || string.IsNullOrEmpty(sifre) || string.IsNullOrEmpty(rol))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd;

                if (rol == "Admin")
                {
                    cmd = new SqlCommand("SELECT COUNT(*) FROM bakicilar WHERE tc_numarasi = @tc AND sifre = @sifre AND rol = 'Admin'", con);
                }
                else
                {
                    cmd = new SqlCommand("SELECT COUNT(*) FROM bakicilar WHERE tc_numarasi = @tc AND sifre = @sifre AND rol = 'Görevli'", con);
                }

                cmd.Parameters.AddWithValue("@tc", tc);
                cmd.Parameters.AddWithValue("@sifre", sifre);

                int result = (int)cmd.ExecuteScalar();

                if (result > 0)
                {
                    if (rol == "Admin")
                    {
                        AdminPanel admin = new AdminPanel();
                        admin.Show();
                    }
                    else
                    {
                        GorevliPanel gorevli = new GorevliPanel();
                        gorevli.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı giriş. Bilgilerinizi kontrol edin.");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
