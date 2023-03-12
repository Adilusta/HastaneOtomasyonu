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
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControlsEkleme
{
    public partial class userSekrtrEkle : UserControl
    {
        public userSekrtrEkle()
        {
            InitializeComponent();
        }
        SekreterManager sekreterManager = new SekreterManager(new SekreterRepository());

        //SEKRETER EKLEME
        private void BtnUserSekrtrEkle_Click(object sender, EventArgs e)
        {
            try
            {

           
                Sekreter sekreter = new Sekreter 
                {
                    Sekreter_adi=txtSekreterEkleAdi.Text,
                    Sekreter_soyadi=txtSekreterEkleSoyadi.Text,
           
                    Sekreter_email= txtSekreterEkleEmail.Text,
                    Sekreter_tcno = txtSekreterEkleTc.Text,
                    Sekreter_telNo = txtSekreterEkleTelNo.Text,
                    Sekreter_yasi = Convert.ToInt32(txtSekreterEkleYasi.Text),
                    Sekreter_bransid = Convert.ToInt32(ComboBoxSekreterEkleBrans.SelectedValue),
                };

            //CİNSİYET ERKEK OLARAK SEÇİLDİYSE 
            if (RadioBtnSekrtrEkleCinsiyetE.Checked)
            {
              sekreter. Sekreter_cinsiyeti = RadioBtnSekrtrEkleCinsiyetE.Text;
            }
            //CİNSİYET KADIN OLARAK SEÇİLDİYSE
            else if (RadioBtnSekrtrEkleCinsiyetK.Checked)
            {
                sekreter.Sekreter_cinsiyeti = RadioBtnSekrtrEkleCinsiyetK.Text;
            }
            else
            {
                MessageBox.Show("Lütfen bir cinsiyet seçiniz");
            }
            bool sekreterGecerlimi = Validator.SekreterValidate(sekreter);

            if (sekreterGecerlimi)
            {
                sekreterManager.SekreterEkle(sekreter);
                MessageBox.Show("Sekreter eklendi");
             
            }
            else
            {
                MessageBox.Show("Sekreter eklenemedi lütfen geçerli bilgiler giriniz");
            }


            }
            catch 
            {

                MessageBox.Show("Lütfen tc no ve yaş alanlarını doğru şekilde doldurunuz");
            }



        }

        private void userSekrtrEkle_Load(object sender, EventArgs e)
        {
            //Branşları combobox a getiriyoruz.
            var branslar = sekreterManager.BranslariGetir(ComboBoxSekreterEkleBrans);
            ComboBoxSekreterEkleBrans = branslar;
        }
    }
}
