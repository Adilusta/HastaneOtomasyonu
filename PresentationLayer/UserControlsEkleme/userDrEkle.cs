using BusinessLayer.Concrete;
using BusinessLayer.Validations;
using DataAccessLayer.Concrete.AccessDb;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControlsEkleme
{
    public partial class userDrEkle : UserControl
    {
        public userDrEkle()
        {
            InitializeComponent();
        }
        SekreterManager sekreterManager = new SekreterManager(new SekreterRepository());
        private void userDrEkle_Load(object sender, EventArgs e)
        {
            //Branşları combobox a getiriyoruz.

            var branslar = sekreterManager.BranslariGetir(ComboBoxDrEkleBrans);
            ComboBoxDrEkleBrans = branslar;
        }

        //DOKTOR EKLEME
        private void BtnUserDrEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Doktor doktor = new Doktor
                {
                    Doktor_adi = txtBoxDrEkleAdi.Text,
                    Doktor_soyadi = txtBoxDrEkleSoyadi.Text,
                    Doktor_tcNo = txtBoxDrEkleTcNo.Text,
                    Doktor_yasi = Convert.ToInt32(txtBoxDrEkleYas.Text),
                    Doktor_tel_no = txtBoxDrEkleTelNo.Text,
                    Doktor_email = txtBoxDrEkleEmail.Text,
                    Doktor_bransid = Convert.ToInt32 (ComboBoxDrEkleBrans.SelectedValue),

                };
                //CİNSİYET ERKEK OLARAK SEÇİLDİYSE 
                if (RadioBtnDrEkleCinsiyetE.Checked)
                {
                    doktor.Doktor_cinsiyeti = RadioBtnDrEkleCinsiyetE.Text;
                }
                //CİNSİYET KADIN OLARAK SEÇİLDİYSE 
                else if (RadioBtnDrEkleCinsiyetK.Checked)
                {
                    doktor.Doktor_cinsiyeti = RadioBtnDrEkleCinsiyetK.Text;
                }
                else
                {
                    MessageBox.Show("Lütfen bir cinsiyet seçiniz");
                }

                bool doktorGecerlimi = Validator.DoktorValidate(doktor);

                if (doktorGecerlimi)
                {
                    sekreterManager.DoktorEkle(doktor);
                    MessageBox.Show("Doktor eklendi");
                }
                else
                {
                    MessageBox.Show("Doktor eklenemedi lütfen geçerli bilgiler giriniz");
                }

                     
            }
            catch 
            {

                MessageBox.Show("Lütfen tc no ve yaş alanlarını doğru şekilde doldurunuz");
            }

        }
       
        
    }
}
