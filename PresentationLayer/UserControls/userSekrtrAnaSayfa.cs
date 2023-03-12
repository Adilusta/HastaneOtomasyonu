using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PresentationLayer.UserControls
{
    public partial class userSekrtrAnaSayfa : UserControl
    {
        public userSekrtrAnaSayfa()
        {
            InitializeComponent();
        }

        private void userSekrtrAnaSayfa_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblTarih.Text = dateTime.ToShortDateString();
            lblSaat.Text = dateTime.Hour.ToString() + ":" + dateTime.Minute.ToString();
            //DoktoraGoreHastaGrafigiGetir();
            //BransaGoreHastaSayisiGrafigiGetir();

        }

        //private void buttonGrafikler_Click(object sender, EventArgs e)
        //{
        //    DoktoraGoreHastaGrafigiGetir();
        //}
        //private void DoktoraGoreHastaGrafigiGetir()
        //{
            
        //    using (OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
        //   "Data Source =|DataDirectory|\\HastaneOtomasyonuDb.mdb"))
        //    {
        //        connection.Open();
        //        //string query = "SELECT doktor_id, COUNT(*) as Randevu_Sayisi FROM Randevular GROUP BY doktor_id";
        //        string query = @"SELECT Doktorlar.Doktor_adi, COUNT(Randevular.Doktor_id) as Randevu_Sayisi FROM Randevular, Doktorlar WHERE Randevular.Doktor_id = Doktorlar.Doktor_id 
        //        GROUP BY Doktorlar.Doktor_adi";

             



        //        OleDbCommand command = new OleDbCommand(query, connection);
        //        OleDbDataAdapter adapter = new OleDbDataAdapter(command);
        //        DataTable table = new DataTable();
        //        adapter.Fill(table);
        //        chart1.DataSource = table;
        //        chart1.Series["Series1"].XValueMember = "Doktor_adi";
        //        chart1.Series["Series1"].YValueMembers = "Randevu_Sayisi";
        //        chart1.Series["Series1"].Name = "Hasta Sayıları";
        //        chart1.DataBind();


        //        //Y ekseninin 0'dan başlayarak 1'er 1'er artmasını istiyoruz.
        //        chart1.ChartAreas[0].AxisY.Interval = 1;

        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            //BransaGoreHastaSayisiGrafigiGetir();
        }
        //private void BransaGoreHastaSayisiGrafigiGetir()
        //{

        //    OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
        //   "Data Source =|DataDirectory|\\HastaneOtomasyonuDb.mdb") ;
        //    baglanti.Open();

        //        string query = @"SELECT Branslar.Brans_ismi, COUNT(*) as Randevu_Sayisi FROM Randevular,
        //         Branslar WHERE Randevular.Brans_id = Branslar.Brans_id
        //        GROUP BY Branslar.Brans_ismi";






        //    OleDbCommand command = new OleDbCommand(query, baglanti);
            
        //         OleDbDataReader reader = command.ExecuteReader();
                
        //            while (reader.Read())
        //            {
        //                string bransAdi = reader["Brans_ismi"].ToString();
        //                int randevuSayisi = Convert.ToInt32(reader["Randevu_Sayisi"]);
        //                chart2.Series["Series1"].Points.AddXY(bransAdi, randevuSayisi);
                   
        //             }
        //    chart2.Series["Series1"].Name = "Hasta Sayıları";
        //    baglanti.Close();
        //}

        private void BtnDrGoreGrafik_Click(object sender, EventArgs e)
        {
            panelGrafik.Controls.Clear();
            userDrGoreHastaGrafik userDrGoreHastaGrafik = new userDrGoreHastaGrafik();
            panelGrafik.Controls.Add(userDrGoreHastaGrafik);
            
        }

        private void BtnBransaGoreGrafik_Click(object sender, EventArgs e)
        {
            panelGrafik.Controls.Clear();
            userBransaGoreGrafik userBransaGoreGrafik = new userBransaGoreGrafik();
            panelGrafik.Controls.Add(userBransaGoreGrafik);
        }

        
    }
}

