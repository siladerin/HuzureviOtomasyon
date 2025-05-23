using System;
using System.Windows.Forms;

namespace HuzureviOtomasyon
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void btnHastaIslemleri_Click(object sender, EventArgs e)
        {
            HastaForm hastaForm = new HastaForm();
            hastaForm.Show();
        }

        private void btnGorevliIslemleri_Click(object sender, EventArgs e)
        {
            GorevliForm gorevliForm = new GorevliForm();
            gorevliForm.Show();
        }

        private void btnOdaIslemleri_Click(object sender, EventArgs e)
        {
            OdaForm odaForm = new OdaForm("Admin");
            odaForm.Show();

        }

        private void btnDoktorIslemleri_Click(object sender, EventArgs e)
        {
            DoktorForm doktorForm = new DoktorForm();
            doktorForm.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            // Şu an için boş kalabilir, ileride istersek açılışta bir şeyler yükleyebiliriz.
        }

    }
}
