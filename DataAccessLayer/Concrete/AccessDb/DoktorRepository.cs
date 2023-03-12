using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.AccessDb
{
    public class DoktorRepository : IDoktorDal
    {
        
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = |DataDirectory|\\HastaneOtomasyonuDb.mdb");

        public bool GirisBasariliMi(Doktor doktor)
        {
            baglanti.Open();

            string komutString = "select * from Doktorlar where Doktor_email=@Doktor_email and Doktor_sifre=@Doktor_sifre";


            OleDbCommand komut = new OleDbCommand(komutString, baglanti);
            komut.Parameters.AddWithValue("Doktor_email", doktor.Doktor_email);
            komut.Parameters.AddWithValue("Doktor_sifre", doktor.Doktor_sifre);

            OleDbDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                baglanti.Close();
                return true;


            }
            else
            {
                baglanti.Close();
                return false;


            }


        }

        public void EskiKayitlariGetir()
        {
            throw new NotImplementedException();
        }


        public void RandevuGorusmesiKaydet()
        {
            throw new NotImplementedException();
        }
    }
}
