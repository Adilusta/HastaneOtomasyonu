using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.AccessDb;
using EntityLayer;
using System.Security.Policy;
using BusinessLayer.Validations;

namespace PresentationLayer.UserControlsEkleme
{
    public partial class userHastaEkle : UserControl
    {
        public userHastaEkle()
        {
            InitializeComponent();
        }
        SekreterManager sekreterManager = new SekreterManager(new SekreterRepository());



        private void verileriGoruntule()
        {


        }
        private void HastaEkle()
        {
            try
            {


                Hasta hasta = new Hasta()
                {
                    Hasta_adi = txtBoxHastaEkleAdi.Text,
                    Hasta_soyadi = txtBoxHastaEkleSoyadi.Text,
                    Hasta_tcno = txtBoxHastaEkleTcNo.Text,
                    Hasta_yasi = Convert.ToInt32(txtBoxHastaEkleYas.Text),
                    Hasta_telNo = txtBoxHastaEkleTelNo.Text,
                    Hasta_email = txtBoxHastaEkleEmail.Text,
                };


                if (RadioBtnHastaEkleCinsiyetE.Checked)
                {
                    hasta.Hasta_cinsiyeti = RadioBtnHastaEkleCinsiyetE.Text;
                }

                else if (RadioBtnHastaEkleCinsiyetK.Checked)
                {
                    hasta.Hasta_cinsiyeti = RadioBtnHastaEkleCinsiyetK.Text;
                }
                else
                {
                    MessageBox.Show("Lütfen bir cinsiyet seçiniz");
                }
                bool hastaGecerlimi = Validator.HastaValidate(hasta);

                if (hastaGecerlimi)
                {
                    sekreterManager.HastaEkle(hasta);
                    MessageBox.Show("Hasta eklendi");
                    TxtBoxTemizle();
                }
                else
                {
                    MessageBox.Show("Hasta eklenemedi lütfen geçerli bilgiler giriniz");
                }
             
               
            }
            catch
            {

                MessageBox.Show("Lütfen tc no ve yaş alanlarını doğru şekilde doldurunuz");
            }



        }



        private void BtnUserHastaEkle_Click(object sender, EventArgs e)
        {
            HastaEkle();


        }

        private void TxtBoxTemizle()
        {
            txtBoxHastaEkleTcNo.Text = "";
            txtBoxHastaEkleAdi.Text = "";
            txtBoxHastaEkleSoyadi.Text = "";
            txtBoxHastaEkleYas.Text = "";
            RadioBtnHastaEkleCinsiyetK.Checked = false;
            RadioBtnHastaEkleCinsiyetE.Checked = false;
            txtBoxHastaEkleTelNo.Text = "";
            txtBoxHastaEkleEmail.Text = "";


        }


    }
}
//Provider=Microsoft.ACE.OLEDB.12.0;Data Source="C:\Users\Feyza\Desktop\görsel son yedek\görsel final\PresentationLayer\HastaneOtomasyonuDb\hastaneOtomasyonuDB.accdb"
