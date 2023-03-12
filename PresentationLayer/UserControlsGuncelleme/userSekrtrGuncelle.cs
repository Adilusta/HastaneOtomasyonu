using BusinessLayer.Concrete;
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

namespace PresentationLayer.UserControlsGuncelleme
{
    public partial class userSekrtrGuncelle : UserControl
    {
        public userSekrtrGuncelle()
        {
            InitializeComponent();
        }
        SekreterManager sekreterManager = new SekreterManager(new SekreterRepository());
        private void BtnUserSekrtrKayitGetir_Click(object sender, EventArgs e)
        {
            var guncellenecekSekreter = sekreterManager.SekreterGetir(txtBoxSekrtrGuncelleTcNo.Text);
            txtBoxSekrtrGuncelleAdi.Text = guncellenecekSekreter.Sekreter_adi;
            txtBoxSekrtrGuncelleSoyadi.Text = guncellenecekSekreter.Sekreter_soyadi;
            txtBoxSekrtrGuncelleYas.Text = guncellenecekSekreter.Sekreter_yasi.ToString();
            txtBoxSekrtrGuncelleTelNo.Text = guncellenecekSekreter.Sekreter_telNo;
            txtBoxSekrtrGuncelleEmail.Text = guncellenecekSekreter.Sekreter_email;
            CBoxSekrtrGuncelleBrans.SelectedValue = guncellenecekSekreter.Sekreter_bransid;

            //Cinsiyeti erkekse radiobuttondan erkek olanı seçili hale getiriyoruz.
            if (guncellenecekSekreter.Sekreter_cinsiyeti == "Erkek")
            {
               RBtnSekrtrGuncelleCinsiyetE.Checked = true;
            }
            //Cinsiyeti kadınsa radiobuttondan erkek olanı seçili hale getiriyoruz.
            if (guncellenecekSekreter.Sekreter_cinsiyeti == "Kadın")
            {
                RBtnSekrtrGuncelleCinsiyetK.Checked = true;
            }
        }

        private void userSekrtrGuncelle_Load(object sender, EventArgs e)
        {
            var branslar = sekreterManager.BranslariGetir(CBoxSekrtrGuncelleBrans);
            CBoxSekrtrGuncelleBrans = branslar;
        }

        private void BtnUserSekrtrGuncelle_Click(object sender, EventArgs e)
        {
            Sekreter sekreter= new Sekreter
            {
                Sekreter_adi = txtBoxSekrtrGuncelleAdi.Text,
                Sekreter_soyadi = txtBoxSekrtrGuncelleSoyadi.Text,
                Sekreter_tcno = txtBoxSekrtrGuncelleTcNo.Text,
                Sekreter_yasi = Convert.ToInt32(txtBoxSekrtrGuncelleYas.Text),
                Sekreter_telNo = txtBoxSekrtrGuncelleTelNo.Text,
                Sekreter_email = txtBoxSekrtrGuncelleEmail.Text,
                Sekreter_bransid = Convert.ToInt32(CBoxSekrtrGuncelleBrans.SelectedValue)




            };

            //Erkek olan radiobutton seçiliyse cinsiyeti erkek olarak güncelliyoruz.
            if (RBtnSekrtrGuncelleCinsiyetE.Checked)
            {
               sekreter.Sekreter_cinsiyeti = "Erkek";

            }
            //Kadın olan radiobutton seçiliyse cinsiyeti kadın olarak güncelliyoruz.
            if (RBtnSekrtrGuncelleCinsiyetK.Checked)
            {
                sekreter.Sekreter_cinsiyeti = "Kadın";
            }

            sekreterManager.SekreterGuncelle(sekreter);
            MessageBox.Show("Sekreter Güncellendi");
        }
    }
}
