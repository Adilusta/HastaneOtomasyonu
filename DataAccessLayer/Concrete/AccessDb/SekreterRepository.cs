using EntityLayer;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DataAccessLayer.Concrete.AccessDb
{
    public class SekreterRepository : ISekreterDal
    {

        OleDbConnection baglanti = new OleDbConnection
            ("Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source =|DataDirectory|\\HastaneOtomasyonuDb.mdb");
        public bool GirisBasariliMi(Sekreter sekreter)
        {
            //veritabanı bağlantısını açıyoruz
            baglanti.Open();

            /*Sekreter e mail ve şifreyi veritabanındaki sekreter e mail ve şifreyle karşılaştıran 
            sorguyu yazıyoruz*/
            string komutString = "select * from Sekreterler " +
                "where Sekreter_email=@Sekreter_email and Sekreter_sifre=@Sekreter_sifre";
            OleDbCommand komut = new OleDbCommand(komutString, baglanti);
            //Parametreleri ekliyoruz
            komut.Parameters.AddWithValue("Sekreter_email", sekreter.Sekreter_email);
            komut.Parameters.AddWithValue("Sekreter_sifre", sekreter.Sekreter_sifre);

            //Veritabanından okuma yapıyoruz
            OleDbDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                // eğer okuma başarılı olursa böyle bir sekreter var demektir giriş başarılı
                baglanti.Close();
                return true;
            }
            else
            {
                // eğer okuma başarısız olursa böyle bir sekreter yok demektir giriş başarısız
                baglanti.Close();
                return false;
            }
        }
        public bool HastaMevcutMu(string tcNo)
        {
            baglanti.Open();
            //Verdiğimiz hasta tc ye göre hastaları getiriyoruz.
            string query = "SELECT * FROM Hastalar WHERE Hasta_tcno = @Hasta_tcno";
            OleDbCommand command = new OleDbCommand(query, baglanti);

            //Tc no parametresini ekliyoruz
            command.Parameters.AddWithValue("@Hasta_tcno", tcNo);
            OleDbDataReader reader = command.ExecuteReader();

            /*reader.HasRows(satır kontrolü) özelliği ile getirdiğimiz hastaları kontrol ediyoruz.
            eğer o tc noya ait hasta(satır) varsa true döner yoksa false */
            if (reader.HasRows)
            {
                baglanti.Close();
                return true;
                // Verilen Tc No ya sahip veritabanında hasta var yani hasta mevcut.
            }
            else
            {
                baglanti.Close();
                return false;
                // Verilen Tc No ya sahip veritabanında hasta yok yani hasta mevcut değil.
            }
        }

        #region GETİRME İŞLEMLERİ
        public ComboBox BranslariGetir(ComboBox comboBox)
        {
            baglanti.Open();
            //Branslar tablosundaki verileri çekiyoruz.
            string sql = "SELECT * FROM Branslar";
            OleDbCommand komut = new OleDbCommand(sql, baglanti);
            OleDbDataReader reader = komut.ExecuteReader();
            //Branslar diye bir brans listesi oluşturup veritbanından veri okuyarak içini dolduruyoruz
            List<Brans> branslar = new List<Brans>();
            while (reader.Read())
            {
                branslar.Add(new Brans
                {
                    Brans_id = Convert.ToInt32(reader["Brans_id"]),
                    Brans_ismi = reader["Brans_ismi"].ToString()

                });
            }

            /*Parametre olarak verilen combobox ın, datasource özelliğine veritabanından veri okuyarak
             içini doldurduğumuz branslar listesini koyuyoruz.
              */
            comboBox.DataSource = branslar;
            //comboboxta bir branş seçildiği zaman arka planda onun değeri Brans_id si oluyor.
            comboBox.ValueMember = "Brans_id";
            //comboboxta bir branş seçilmesi için branş ismini gösteriyoruz bu özellik ile
            comboBox.DisplayMember = "Brans_ismi";
            baglanti.Close();
            return comboBox;
        }
        public ComboBox DoktorlariGetir(ComboBox comboBox)
        {
            baglanti.Open();
            string sql = "SELECT * FROM Doktorlar";
            OleDbCommand komut = new OleDbCommand(sql, baglanti);
            OleDbDataReader reader = komut.ExecuteReader();
            List<Doktor> doktorlar = new List<Doktor>();
            while (reader.Read())
            {
                doktorlar.Add(new Doktor
                {
                    Doktor_id = Convert.ToInt32(reader["Doktor_id"]),
                    Doktor_adi = reader["Doktor_adi"].ToString()

                });
            }
            comboBox.DataSource = doktorlar;
            comboBox.DisplayMember = "Doktor_adi";
            comboBox.ValueMember = "Doktor_id";
            baglanti.Close();
            return comboBox;
        }
        public Hasta HastaGetir(string tcNo)
        {
            baglanti.Open();
            //Hasta tc noya göre hasta getiriyoruz.
            string komutString = "SELECT * FROM Hastalar where Hasta_tcno=@Hasta_tcno";
            OleDbCommand komut = new OleDbCommand(komutString, baglanti);
            //tcNo parametresini ekliyoruz.
            komut.Parameters.AddWithValue("Hasta_tcno", tcNo);
            OleDbDataReader reader = komut.ExecuteReader();
            /* Hasta sınıfından bir nesne  oluşturup içini veritabanından okuduğumuz hasta
             * verileri ile dolduruyoruz */
            Hasta hasta = new Hasta();
            while (reader.Read())
            {
                hasta.Hasta_adi = reader["Hasta_adi"].ToString();
                hasta.Hasta_soyadi = reader["Hasta_soyadi"].ToString();
                hasta.Hasta_tcno = reader["Hasta_tcno"].ToString();
                hasta.Hasta_yasi = Convert.ToInt32(reader["Hasta_yasi"]);
                hasta.Hasta_cinsiyeti = reader["Hasta_cinsiyeti"].ToString();
                hasta.Hasta_telNo = reader["Hasta_telNo"].ToString();
                hasta.Hasta_email = reader["Hasta_email"].ToString();
            }
            baglanti.Close();
            //içini doldurduğumuz hasta nesneni return ediyoruz.
            return hasta;
        }
        public Doktor DoktorGetir(string tcNo)
        {
            baglanti.Open();
            string komutString = "SELECT * FROM Doktorlar where Doktor_tcNo=@Doktor_tcNo";
            OleDbCommand komut = new OleDbCommand(komutString, baglanti);
            komut.Parameters.AddWithValue("Doktor_tcNo", tcNo);
            OleDbDataReader reader = komut.ExecuteReader();

            Doktor doktor = new Doktor();
            while (reader.Read())
            {
                doktor.Doktor_id = Convert.ToInt32(reader["Doktor_id"]);
                doktor.Doktor_adi = reader["Doktor_adi"].ToString();
                doktor.Doktor_soyadi = reader["Doktor_soyadi"].ToString();
                doktor.Doktor_tcNo = reader["Doktor_tcNo"].ToString();
                doktor.Doktor_yasi = Convert.ToInt32(reader["Doktor_yasi"]);
                doktor.Doktor_cinsiyeti = reader["Doktor_cinsiyeti"].ToString();
                doktor.Doktor_tel_no = reader["Doktor_tel_no"].ToString();
                doktor.Doktor_bransid = Convert.ToInt32(reader["Doktor_bransid"]);
                doktor.Doktor_email = (reader["Doktor_email"].ToString());
            }
            baglanti.Close();
            return doktor;
        }
        public Sekreter SekreterGetir(string tcNo)
        {
            baglanti.Open();
            string komutString = "SELECT * FROM Sekreterler where Sekreter_tcno=@Sekreter_tcno";
            OleDbCommand komut = new OleDbCommand(komutString, baglanti);
            komut.Parameters.AddWithValue("Sekreter_tcno", tcNo);
            OleDbDataReader reader = komut.ExecuteReader();

            Sekreter sekreter = new Sekreter();
            while (reader.Read())
            {

                sekreter.Sekreter_adi = reader["Sekreter_adi"].ToString();
                sekreter.Sekreter_soyadi = reader["Sekreter_soyadi"].ToString();
                sekreter.Sekreter_tcno = reader["Sekreter_tcno"].ToString();
                sekreter.Sekreter_yasi = Convert.ToInt32(reader["Sekreter_yasi"]);
                sekreter.Sekreter_cinsiyeti = reader["Sekreter_cinsiyeti"].ToString();
                sekreter.Sekreter_telNo = reader["Sekreter_telNo"].ToString();
                sekreter.Sekreter_bransid = Convert.ToInt32(reader["Sekreter_bransid"]);
                sekreter.Sekreter_email = (reader["Sekreter_email"].ToString());
            }
            baglanti.Close();
            return sekreter;
        }
        public List<Doktor> BransaGoreDoktorGetir(int brans_id)
        {
            baglanti.Open();
            /*Verilen brans id ye göre veritabanından sorgu çekiyoruz */
            string komutString = "SELECT * FROM Doktorlar where Doktor_bransid=@Doktor_bransid";
            OleDbCommand komut = new OleDbCommand(komutString, baglanti);
            //brans_id yi parametre olarak ekliyoruz.
            komut.Parameters.AddWithValue("Doktor_bransid", brans_id);
            OleDbDataReader reader = komut.ExecuteReader();
            /*Doktorlar listesi oluşturuyoruz ve while döngüsü ile veritabanından çektiğimiz verileri
             * bu listeye atıyoruz*/
            List<Doktor> doktorlar = new List<Doktor>();
            while (reader.Read())
            {
                doktorlar.Add(new Doktor
                {
                    Doktor_id = Convert.ToInt32(reader["Doktor_id"]),
                    Doktor_adi = reader["Doktor_adi"].ToString(),
                    Doktor_soyadi = reader["Doktor_soyadi"].ToString(),
                    Doktor_bransid = Convert.ToInt32(reader["Doktor_bransid"])


                });
            }
            baglanti.Close();
            //doktorlar listesini return ediyoruz.
            return doktorlar;
        }

        public List<Randevu> HastayaGoreRandevulariGetir(string tcNo)
        {
            baglanti.Open();
            //Hasta tc no ya göre Randevular tablosundan randevuları getirir.
            string komutString = "SELECT * FROM Randevular where Hasta_tcNo=@Hasta_tcNo";
            OleDbCommand komut = new OleDbCommand(komutString, baglanti);
            komut.Parameters.AddWithValue("Hasta_tcNo", tcNo);
            OleDbDataReader reader = komut.ExecuteReader();
            /* Randevular listesi oluşturup veritabanından veri okuyarak bu listeye atar*/
            List<Randevu> randevular = new List<Randevu>();
            while (reader.Read())
            {
                randevular.Add(new Randevu
                {
                    Randevu_id = Convert.ToInt32(reader["Randevu_id"]),
                    Doktor_id = Convert.ToInt32(reader["Doktor_id"]),
                    Hasta_tcNo = reader["Hasta_tcNo"].ToString(),
                    Randevu_saati = reader["Randevu_saati"].ToString(),
                    Randevu_tarihi = reader["Randevu_tarihi"].ToString(),
                    //Brans_adi = reader["Brans_adi"].ToString()

                });
            }
            baglanti.Close();
            //randevular listesini return eder.
            return randevular;
        }
        public Randevu RandevuIdyeGoreRandevuGetir(int randevuId)
        {
            baglanti.Open();
            string komutString = "SELECT * FROM Randevular where Randevu_id=@Randevu_id";
            OleDbCommand komut = new OleDbCommand(komutString, baglanti);
            komut.Parameters.AddWithValue("Randevu_id", randevuId);
            OleDbDataReader reader = komut.ExecuteReader();


            Randevu randevu = new Randevu();

            while (reader.Read())
            {

                randevu.Randevu_id = Convert.ToInt32(reader["Randevu_id"]);
                randevu.Doktor_id = Convert.ToInt32(reader["Doktor_id"]);
                randevu.Hasta_tcNo = reader["Hasta_tcNo"].ToString();
                randevu.Randevu_saati = reader["Randevu_saati"].ToString();
                randevu.Randevu_tarihi = reader["Randevu_tarihi"].ToString();
                randevu.Brans_adi = reader["Brans_adi"].ToString();

            }
            baglanti.Close();
            return randevu;
        }

        public string EskiRandevuKayitlariniGetir(Randevu randevuBilgileri)
        {
            baglanti.Open();
            string komutString = "SELECT * FROM Randevular WHERE" +
                " Doktor_id=@Doktor_id AND Hasta_tcNo = @Hasta_tcNo AND" +
                " Randevu_saati = @Randevu_saati AND Randevu_tarihi=@Randevu_tarihi";
            OleDbCommand komut = new OleDbCommand(komutString, baglanti);
            komut.Parameters.AddWithValue("Doktor_id", randevuBilgileri.Doktor_id);
            komut.Parameters.AddWithValue("Hasta_tcNo", randevuBilgileri.Hasta_tcNo);
            komut.Parameters.AddWithValue("Randevu_saati", randevuBilgileri.Randevu_saati);
            komut.Parameters.AddWithValue("Randevu_tarihi", randevuBilgileri.Randevu_tarihi);
            OleDbDataReader reader = komut.ExecuteReader();


            Randevu randevu = new Randevu();

            while (reader.Read())
            {

                randevu.Randevu_notu = reader["Randevu_notu"].ToString();
            }
            baglanti.Close();
            return randevu.Randevu_notu;
        }


        #endregion

        #region EKLEME İŞLEMLERİ
        public void HastaEkle(Hasta hasta)
        {
            baglanti.Open();
            //Hastalar tablosuna veri girmemizi sağlayan sql sorgusu
            string komutString = "insert into Hastalar" +
                "(Hasta_adi,Hasta_soyadi,Hasta_tcno,Hasta_yasi,Hasta_cinsiyeti,Hasta_telNo,Hasta_email)" +
                " values (@Hasta_adi, @Hasta_soyadi, @Hasta_tcno, @Hasta_yasi, @Hasta_cinsiyeti, " +
                "@Hasta_telNo, @Hasta_email) ";

            OleDbCommand komut = new OleDbCommand(komutString, baglanti);
            /* Parametreleri ekliyoruz bu şekilde*/
            komut.Parameters.AddWithValue("Hasta_adi", hasta.Hasta_adi);
            komut.Parameters.AddWithValue("Hasta_soyadi", hasta.Hasta_soyadi);
            komut.Parameters.AddWithValue("Hasta_tcno", hasta.Hasta_tcno);
            komut.Parameters.AddWithValue("Hasta_yasi", hasta.Hasta_yasi);
            komut.Parameters.AddWithValue("Hasta_cinsiyeti", hasta.Hasta_cinsiyeti);
            komut.Parameters.AddWithValue("Hasta_telNo", hasta.Hasta_telNo);
            komut.Parameters.AddWithValue("Hasta_email", hasta.Hasta_email);

            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public void DoktorEkle(Doktor doktor)
        {
            baglanti.Open();
            string komutString = "insert into Doktorlar(Doktor_adi,Doktor_soyadi,Doktor_tcNo," +
                "Doktor_yasi,Doktor_cinsiyeti,Doktor_tel_no,Doktor_email,Doktor_bransid) " +
                "values (@Doktor_adi, @Doktor_soyadi, @Doktor_tcNo, @Doktor_yasi, " +
                "@Doktor_cinsiyeti, @Doktor_tel_no,@Doktor_email, @Doktor_bransid)";

            OleDbCommand komut = new OleDbCommand(komutString, baglanti);
            komut.Parameters.AddWithValue("Doktor_adi", doktor.Doktor_adi);
            komut.Parameters.AddWithValue("Doktor_soyadi", doktor.Doktor_soyadi);
            komut.Parameters.AddWithValue("Doktor_tcNo", doktor.Doktor_tcNo);
            komut.Parameters.AddWithValue("Doktor_yasi", doktor.Doktor_yasi);
            komut.Parameters.AddWithValue("Doktor_cinsiyeti", doktor.Doktor_cinsiyeti);
            komut.Parameters.AddWithValue("Doktor_tel_no", doktor.Doktor_tel_no);
            komut.Parameters.AddWithValue("Doktor_email", doktor.Doktor_email);
            komut.Parameters.AddWithValue("Doktor_bransid", doktor.Doktor_bransid);

            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public void SekreterEkle(Sekreter sekreter)
        {
            baglanti.Open();
            string komutString = "insert into Sekreterler(Sekreter_adi,Sekreter_soyadi," +
                "Sekreter_tcno,Sekreter_yasi,Sekreter_cinsiyeti,Sekreter_telNo," +
                "Sekreter_bransid,Sekreter_email) " +
                "values (@Sekreter_adi, @Sekreter_soyadi, @Sekreter_tcno, " +
                "@Sekreter_yasi, @Sekreter_cinsiyeti, @Sekreter_telNo," +
                "@Sekreter_bransid, @Sekreter_email)";

            OleDbCommand komut = new OleDbCommand(komutString, baglanti);
            komut.Parameters.AddWithValue("Sekreter_adi", sekreter.Sekreter_adi);
            komut.Parameters.AddWithValue("Sekreter_soyadi", sekreter.Sekreter_soyadi);
            komut.Parameters.AddWithValue("Sekreter_tcno", sekreter.Sekreter_tcno);
            komut.Parameters.AddWithValue("Sekreter_yasi", sekreter.Sekreter_yasi);
            komut.Parameters.AddWithValue("Sekreter_cinsiyeti", sekreter.Sekreter_cinsiyeti);
            komut.Parameters.AddWithValue("Sekreter_telNo", sekreter.Sekreter_telNo);
            komut.Parameters.AddWithValue("Sekreter_bransid", sekreter.Sekreter_bransid);
            komut.Parameters.AddWithValue("Sekreter_email", sekreter.Sekreter_email);

            komut.ExecuteNonQuery();
            baglanti.Close();
        }


        public void RandevuEkle(Randevu randevu)
        {
            baglanti.Open();
            string komutString = "INSERT INTO Randevular (Doktor_id, Hasta_tcNo, " +
                "Randevu_saati,Randevu_tarihi,Brans_id) VALUES (@Doktor_id, @Hasta_tcNo, " +
                "@Randevu_saati,@Randevu_tarihi,@Brans_id)";

            OleDbCommand command = new OleDbCommand(komutString, baglanti);
            command.Parameters.AddWithValue("@Doktor_id", randevu.Doktor_id);
            command.Parameters.AddWithValue("@Hasta_tcNo", randevu.Hasta_tcNo);
            command.Parameters.AddWithValue("@Randevu_saati", randevu.Randevu_saati);
            command.Parameters.AddWithValue("@Randevu_tarihi", randevu.Randevu_tarihi);
            command.Parameters.AddWithValue("@Brans_id", randevu.Brans_id);
            command.ExecuteNonQuery();

            baglanti.Close();
        }
        public void RandevuNotuEkle(Randevu randevu)
        {
            baglanti.Open();
            string komutString = "UPDATE Randevular SET Randevu_notu=@Randevu_notu " +
                "WHERE Hasta_tcNo = @Hasta_tcNo AND Randevu_saati = @Randevu_saati AND " +
                "Randevu_tarihi=@Randevu_tarihi";

            OleDbCommand komut = new OleDbCommand(komutString, baglanti);

            komut.Parameters.AddWithValue("Randevu_notu", randevu.Randevu_notu);
            komut.Parameters.AddWithValue("Hasta_tcNo", randevu.Hasta_tcNo);
            komut.Parameters.AddWithValue("Randevu_saati", randevu.Randevu_saati);
            komut.Parameters.AddWithValue("Randevu_tarihi", randevu.Randevu_tarihi);



            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        #endregion
        #region SİLME İŞLEMLERİ
        public void Hastasil(Hasta hasta)
        {
            baglanti.Open();
            /*Parametre olarak verdiğimiz hasta tc noya sahip olan hastayı bulur ve o
             * hastayı tamamen veritabanından siler*/
            string komutString = "delete * from Hastalar where Hasta_tcno=@Hasta_tcno";
            OleDbCommand komut = new OleDbCommand(komutString, baglanti);
            komut.Parameters.AddWithValue("Hasta_tcno", hasta.Hasta_tcno);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public void DoktorSil(Doktor doktor)
        {
            baglanti.Open();

            string komutString = "delete * from Doktorlar where Doktor_tcNo=@Doktor_tcNo";


            OleDbCommand komut = new OleDbCommand(komutString, baglanti);
            komut.Parameters.AddWithValue("Doktor_tcNo", doktor.Doktor_tcNo);

            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public void SekreterSil(Sekreter sekreter)
        {
            baglanti.Open();
            string komutString = "delete * from Sekreterler where Sekreter_tcno=@Sekreter_tcno";
            OleDbCommand komut = new OleDbCommand(komutString, baglanti);
            komut.Parameters.AddWithValue("Sekreter_tcno", sekreter.Sekreter_tcno);

            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public void RandevuSil(int Randevu_id)
        {
            baglanti.Open();
            string komutString = "Delete * from Randevular where Randevu_id=@Randevu_id";
            OleDbCommand komut = new OleDbCommand(komutString, baglanti);
            komut.Parameters.AddWithValue("Randevu_id", Randevu_id);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        #endregion
        #region GÜNCELLEME İŞLEMLERİ
        public void HastaGuncelle(Hasta hasta)
        {
            baglanti.Open();
            string komutString = "UPDATE Hastalar SET Hasta_adi = @Hasta_adi,Hasta_soyadi = @Hasta_soyadi,Hasta_yasi=@Hasta_yasi,Hasta_cinsiyeti=@Hasta_cinsiyeti,Hasta_telNo=@Hasta_telNo,Hasta_email=@Hasta_email WHERE Hasta_tcno = @Hasta_tcno";

            OleDbCommand komut = new OleDbCommand(komutString, baglanti);

            komut.Parameters.AddWithValue("Hasta_adi", hasta.Hasta_adi);
            komut.Parameters.AddWithValue("Hasta_soyadi", hasta.Hasta_soyadi);
            komut.Parameters.AddWithValue("Hasta_yasi", hasta.Hasta_yasi);
            komut.Parameters.AddWithValue("Hasta_cinsiyeti", hasta.Hasta_cinsiyeti);
            komut.Parameters.AddWithValue("Hasta_telNo", hasta.Hasta_telNo);
            komut.Parameters.AddWithValue("Hasta_email", hasta.Hasta_email);
            komut.Parameters.AddWithValue("Hasta_tcno", hasta.Hasta_tcno);

            komut.ExecuteNonQuery();
            baglanti.Close();



        }
        public void DoktorGuncelle(Doktor doktor)
        {
            baglanti.Open();
            /*Update sorgusu ile doktor güncelleme işlemi gerçekleştiriyor bu sql sorgusu. Parametre olarak
             aldığımız doktor nesnesinin tc no özelliği ile veritabanından çektiğimiz doktor tc no özelliğini
            karşılaştırıyoruz.Eğer tc no lar aynıysa doktoru güncelliyor.*/

            string komutString = "UPDATE Doktorlar SET Doktor_adi = @Doktor_adi,Doktor_soyadi = @Doktor_soyadi," +
                "Doktor_yasi=@Doktor_yasi,Doktor_cinsiyeti=@Doktor_cinsiyeti,Doktor_tel_no=@Doktor_tel_no," +
                "Doktor_bransid=@Doktor_bransid,Doktor_email=@Doktor_email WHERE Doktor_tcNo = @Doktor_tcNo";

            OleDbCommand komut = new OleDbCommand(komutString, baglanti);

            //Parametreleri ekliyoruz.
            komut.Parameters.AddWithValue("Doktor_adi", doktor.Doktor_adi);
            komut.Parameters.AddWithValue("Doktor_soyadi", doktor.Doktor_soyadi);
            komut.Parameters.AddWithValue("Doktor_yasi", doktor.Doktor_yasi);
            komut.Parameters.AddWithValue("Doktor_cinsiyeti", doktor.Doktor_cinsiyeti);
            komut.Parameters.AddWithValue("Doktor_tel_no", doktor.Doktor_tel_no);
            komut.Parameters.AddWithValue("Doktor_bransid", doktor.Doktor_bransid);
            komut.Parameters.AddWithValue("Doktor_email", doktor.Doktor_email);
            komut.Parameters.AddWithValue("Doktor_tcNo", doktor.Doktor_tcNo);

            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public void SekreterGuncelle(Sekreter sekreter)
        {
            baglanti.Open();
            string komutString = "UPDATE Sekreterler SET Sekreter_adi = @Sekreter_adi," +
                "Sekreter_soyadi = @Sekreter_soyadi,Sekreter_yasi=@Sekreter_yasi," +
                "Sekreter_cinsiyeti=@Sekreter_cinsiyeti,Sekreter_telNo=@Sekreter_telNo," +
                "Sekreter_bransid=@Sekreter_bransid,Sekreter_email=@Sekreter_email WHERE " +
                "Sekreter_tcno = @Sekreter_tcno";

            OleDbCommand komut = new OleDbCommand(komutString, baglanti);
            komut.Parameters.AddWithValue("Sekreter_adi", sekreter.Sekreter_adi);
            komut.Parameters.AddWithValue("Sekreter_soyadi", sekreter.Sekreter_soyadi);
            komut.Parameters.AddWithValue("Sekreter_yasi", sekreter.Sekreter_yasi);
            komut.Parameters.AddWithValue("Sekreter_cinsiyeti", sekreter.Sekreter_cinsiyeti);
            komut.Parameters.AddWithValue("Sekreter_telNo", sekreter.Sekreter_telNo);
            komut.Parameters.AddWithValue("Sekreter_bransid", sekreter.Sekreter_bransid);
            komut.Parameters.AddWithValue("Sekreter_email", sekreter.Sekreter_email);
            komut.Parameters.AddWithValue("Sekreter_tcno", sekreter.Sekreter_tcno);

            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public void RandevuGuncelle(Randevu randevu)
        {
            baglanti.Open();
            string komutString = "UPDATE Randevular SET Hasta_tcNo = @Hasta_tcNo," +
                "Randevu_saati = @Randevu_saati,Randevu_tarihi=@Randevu_tarihi WHERE Randevu_id = @Randevu_id";

            OleDbCommand komut = new OleDbCommand(komutString, baglanti);
            komut.Parameters.AddWithValue("Hasta_tcNo", randevu.Hasta_tcNo);
            komut.Parameters.AddWithValue("Randevu_saati", randevu.Randevu_saati);
            komut.Parameters.AddWithValue("Randevu_tarihi", randevu.Randevu_tarihi);
            komut.Parameters.AddWithValue("Randevu_id", randevu.Randevu_id);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        #endregion

        #region GRAFİK İŞLEMLERİ
        public Chart DoktoraGoreHastaGrafigiGetir(Chart chart)
        {
            baglanti.Open();
            /*Bu sorgu Doktorlar ve randevular tablolarını kullanarak, her bir
             * doktorun kaç tane hastası olduğunu getirir*/

            string komutString = @"SELECT Doktorlar.Doktor_adi, COUNT(Randevular.Doktor_id)
                as Randevu_Sayisi FROM Randevular, Doktorlar 
                WHERE Randevular.Doktor_id = Doktorlar.Doktor_id 
                GROUP BY Doktorlar.Doktor_adi";
            OleDbCommand komut = new OleDbCommand(komutString, baglanti);
            //Bir data adapter oluşturuyoruz ve içine sorgumuzdan dönen verileri atıyoruz.
            OleDbDataAdapter adapter = new OleDbDataAdapter(komut);
            //Bir datatable oluşturuyoruz
            DataTable table = new DataTable();
            //Veri tabanından dönen sonuçları datatable a dolduruyoruz.
            adapter.Fill(table);
            //chartımızın datasource özelliğine tablomuzu atıyoruz.
            chart.DataSource = table;
            //X ve Y eksenlerinde hangi özelliklerin olacağını belirliyoruz.
            chart.Series["Series1"].XValueMember = "Doktor_adi";
            chart.Series["Series1"].YValueMembers = "Randevu_Sayisi";
            chart.Series["Series1"].Name = "Hasta Sayıları";
            chart.DataBind();

            //Y ekseninin 0'dan başlayarak 1'er 1'er artmasını istiyoruz.
            chart.ChartAreas[0].AxisY.Interval = 1;
            //parametreden aldığımız chartı dolu şekilde geri döndürüyoruz böylece.
            return chart;
        }

        public Chart BransaGoreHastaSayisiGrafigiGetir(Chart chart)
        {
            baglanti.Open();

            string komutString =
                @"SELECT Branslar.Brans_ismi, COUNT(*) as Randevu_Sayisi 
                 FROM Randevular,
                 Branslar WHERE Randevular.Brans_id = Branslar.Brans_id
                 GROUP BY Branslar.Brans_ismi";
            OleDbCommand komut = new OleDbCommand(komutString, baglanti);

            OleDbDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                string bransAdi = reader["Brans_ismi"].ToString();
                int randevuSayisi = Convert.ToInt32(reader["Randevu_Sayisi"]);
                //X ve Y eksenlerinde hangi özelliklerin olacağını belirliyoruz.
                chart.Series["Series1"].Points.AddXY(bransAdi, randevuSayisi);
            }
            chart.Series["Series1"].Name = "Hasta Sayıları";
            baglanti.Close();
            return chart;
        }
        #endregion

    }
}
