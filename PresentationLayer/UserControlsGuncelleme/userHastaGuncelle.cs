using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.AccessDb;
using EntityLayer;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControlsGuncelleme
{
    public partial class userHastaGuncelle : UserControl
    {
        public userHastaGuncelle()
        {
            InitializeComponent();
        }
        SekreterManager sekreterManager = new SekreterManager(new SekreterRepository());

        //GÜNCELLENECEK HASTA BİLGİLERİNİ FORMA GETİRME
        private void BtnUserHastaGetir_Click(object sender, EventArgs e)
        {


           var guncellenecekHasta= sekreterManager.HastaGetir(txtBoxHastaGuncelleTcNo.Text);
            txtBoxHastaGuncelleAdi.Text = guncellenecekHasta.Hasta_adi;
            txtBoxHastaGuncelleSoyadi.Text = guncellenecekHasta.Hasta_soyadi;
            txtBoxHastaGuncelleYas.Text = guncellenecekHasta.Hasta_yasi.ToString();
            txtBoxHastaGuncelleTelNo.Text = guncellenecekHasta.Hasta_telNo;
            txtBoxHastaGuncelleEmail.Text = guncellenecekHasta.Hasta_email;

            //Cinsiyeti erkekse radiobuttondan erkek olanı seçili hale getiriyoruz.
            if (guncellenecekHasta.Hasta_cinsiyeti=="Erkek")
            {
                RBtnHastaGuncelleCinsiyetE.Checked = true;
            }
            //Cinsiyeti kadınsa radiobuttondan erkek olanı seçili hale getiriyoruz.
            if (guncellenecekHasta.Hasta_cinsiyeti=="Kadın")
            {
                RBtnHastaGuncelleCinsiyetK.Checked = true;
            }
          


        }

        private void BtnUserHastaGuncelle_Click(object sender, EventArgs e)
        {

            Hasta hasta = new Hasta
            {
                Hasta_adi = txtBoxHastaGuncelleAdi.Text,
                Hasta_soyadi = txtBoxHastaGuncelleSoyadi.Text,
                Hasta_yasi = Convert.ToInt32(txtBoxHastaGuncelleYas.Text),
                Hasta_telNo = txtBoxHastaGuncelleTelNo.Text,
                Hasta_email = txtBoxHastaGuncelleEmail.Text,
                Hasta_tcno = txtBoxHastaGuncelleTcNo.Text,
                Hasta_cinsiyeti = "Erkek"
                
             };
            //Erkek olan radiobutton seçiliyse cinsiyeti erkek olarak güncelliyoruz.
            if (RBtnHastaGuncelleCinsiyetE.Checked)
            {
                hasta.Hasta_cinsiyeti = "Erkek";
            }
            //Kadın olan radiobutton seçiliyse cinsiyeti kadın olarak güncelliyoruz.
            if (RBtnHastaGuncelleCinsiyetK.Checked)
            {
                hasta.Hasta_cinsiyeti = "Kadın";
            }

            sekreterManager.HastaGuncelle(hasta);
            MessageBox.Show("Hasta Güncellendi");
        }
    }
}
