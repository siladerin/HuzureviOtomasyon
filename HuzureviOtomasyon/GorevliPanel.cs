using System;
using System.Windows.Forms;

namespace HuzureviOtomasyon
{
    public partial class GorevliPanel : Form
    {
        public GorevliPanel()
        {
            InitializeComponent();
        }
        private void GorevliPanel_Load(object sender, EventArgs e)
        {

        }
        private void bttnZiyaretci_Click(object sender, EventArgs e)
        {
            ZiyaretciForm ziyaretciForm = new ZiyaretciForm();
            ziyaretciForm.Show();
        }

        private void btnHastaIslemleri_Click(object sender, EventArgs e)
        {
            HastaForm hf = new HastaForm();
            hf.Show();
        }

        private void btnIlacIslemleri_Click(object sender, EventArgs e)
        {
            IlacForm ilac = new IlacForm();
            ilac.Show();
        }

        private void btnSaglikIslemleri_Click(object sender, EventArgs e)
        {
            SaglikForm saglik = new SaglikForm();
            saglik.Show();
        }

        private void btnOdaIslemleri_Click(object sender, EventArgs e)
        {
            OdaForm odaForm = new OdaForm("Görevli");
            odaForm.Show();

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
