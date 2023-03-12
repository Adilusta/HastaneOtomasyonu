using BusinessLayer.Concrete;
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

namespace PresentationLayer.UserControlsGuncelleme
{
    public partial class userDrGuncelle : UserControl
    {
        public userDrGuncelle()
        {
            InitializeComponent();
        }
        SekreterManager sekreterManager = new SekreterManager(new SekreterRepository());
        private void BtnUserDrKayitGetir_Click(object sender, EventArgs e)
        {

            var guncellenecekDoktor = sekreterManager.DoktorGetir(txtBoxDrGuncelleTcNo.Text);
            txtBoxDrGuncelleAdi.Text = guncellenecekDoktor.Doktor_adi;
            txtBoxDrGuncelleSoyadi.Text = guncellenecekDoktor.Doktor_soyadi;
            txtBoxDrGuncelleYas.Text = guncellenecekDoktor.Doktor_yasi.ToString();
            txtBoxDrGuncelleTelNo.Text = guncellenecekDoktor.Doktor_tel_no;
            txtBoxDrGuncelleEmail.Text = guncellenecekDoktor.Doktor_email;
            CBoxDrGuncelleBrans.SelectedValue = guncellenecekDoktor.Doktor_bransid;

            //Cinsiyeti erkekse radiobuttondan erkek olanı seçili hale getiriyoruz.
            if (guncellenecekDoktor.Doktor_cinsiyeti == "Erkek")
            {
                RBtnDrGuncelleCinsiyetE.Checked = true;
            }
            //Cinsiyeti kadınsa radiobuttondan erkek olanı seçili hale getiriyoruz.
            if (guncellenecekDoktor.Doktor_cinsiyeti == "Kadın")
            {
                RBtnDrGuncelleCinsiyetK.Checked = true;
            }
        }

        private void BtnUserDrGuncelle_Click(object sender, EventArgs e)
        {
            Doktor doktor = new Doktor
            {
                Doktor_adi = txtBoxDrGuncelleAdi.Text,
                Doktor_soyadi = txtBoxDrGuncelleSoyadi.Text,
                Doktor_tcNo = txtBoxDrGuncelleTcNo.Text,
                Doktor_yasi = Convert.ToInt32(txtBoxDrGuncelleYas.Text),
                Doktor_tel_no = txtBoxDrGuncelleTelNo.Text,
                Doktor_email = txtBoxDrGuncelleEmail.Text,
                Doktor_bransid = Convert.ToInt32 (CBoxDrGuncelleBrans.SelectedValue)
             
              


             };
       
            //Erkek olan radiobutton seçiliyse cinsiyeti erkek olarak güncelliyoruz.
            if (RBtnDrGuncelleCinsiyetE.Checked)
            {
                doktor.Doktor_cinsiyeti = "Erkek";

            }
            //Kadın olan radiobutton seçiliyse cinsiyeti kadın olarak güncelliyoruz.
            if (RBtnDrGuncelleCinsiyetK.Checked)
            {
                doktor.Doktor_cinsiyeti = "Kadın";
            }

                sekreterManager.DoktorGuncelle(doktor);
                MessageBox.Show("Doktor Güncellendi");

        }

        private void userDrGuncelle_Load(object sender, EventArgs e)
        {
            var branslar = sekreterManager.BranslariGetir(CBoxDrGuncelleBrans);
            CBoxDrGuncelleBrans = branslar;
        }


    }
}
