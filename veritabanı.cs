using System;
using System.Data;
using System.Data.SqlClient;

namespace VTIslemleri
{
    class VeritabaniIslemleri
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=huzurevi;Integrated Security=True");
        public DataTable datatbl = new DataTable();
        public SqlDataAdapter adtr = new SqlDataAdapter();
        public SqlCommand sqlkomut = new SqlCommand();

        public DataTable Select(string sorgu)
        {
            if (Baglan())
            {
                datatbl = new DataTable();
                sqlkomut.Connection = baglanti;
                sqlkomut.CommandText = sorgu;
                adtr.SelectCommand = sqlkomut;
                adtr.Fill(datatbl);
                BaglantiKapat();
                return datatbl;
            }
            else
                return null;
        }

        public int Insert(string sorgu)
        {
            if (Baglan())
            {
                sqlkomut.Connection = baglanti;
                sqlkomut.CommandText = sorgu;
                int sayi = sqlkomut.ExecuteNonQuery();
                BaglantiKapat();
                return sayi;
            }
            else
                return 0;
        }

        public int UpdateDelete(string sorgu)
        {
            if (Baglan())
            {
                sqlkomut.Connection = baglanti;
                sqlkomut.CommandText = sorgu;
                int sayi = sqlkomut.ExecuteNonQuery();
                BaglantiKapat();
                return sayi;
            }
            else
                return 0;
        }

        private bool Baglan()
        {
            try
            {
                baglanti.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void BaglantiKapat()
        {
            try
            {
                baglanti.Close();
            }
            catch
            {
                // Bağlantı kapanma hatasını önemseme
            }
        }
    }
}
