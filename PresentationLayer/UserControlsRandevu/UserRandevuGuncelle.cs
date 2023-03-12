using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.AccessDb;
using EntityLayer;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControlsRandevu
{
    public partial class UserRandevuGuncelle : UserControl
    {
        public UserRandevuGuncelle()
        {
            InitializeComponent();
        }
        SekreterManager sekreterManager = new SekreterManager(new SekreterRepository());

        private void UserRandevuGuncelle_Load(object sender, EventArgs e)
        {
            //CBoxRndvGuncelleHastaSecBol= sekreterManager.BranslariGetir(CBoxRndvGuncelleHastaSecBol);
        }

        private void BtnUserRandevuKaydiGetir_Click(object sender, EventArgs e)
        {
            //hasta tc no ya göre randevuları getiriyoruz.
            string hastaTcNO = txtBoxRndvGuncelleHastaTc.Text;
            var randevular= sekreterManager.HastayaGoreRandevulariGetir(hastaTcNO);

            listViewRandevuGuncelleRandevular.Items.Clear();
            
            foreach (Randevu randevu in randevular)
            {
                ListViewItem item = new ListViewItem(randevu.Randevu_id.ToString());
                item.SubItems.Add(randevu.Doktor_id.ToString());
                item.SubItems.Add(randevu.Hasta_tcNo);
                item.SubItems.Add(randevu.Randevu_saati);
                item.SubItems.Add(randevu.Randevu_tarihi);
                //item.SubItems.Add(randevu.Brans_adi);

                listViewRandevuGuncelleRandevular.Items.Add(item);
            }

            //txtBoxRndvGuncelleHastaTc.Enabled = true;
            //txtBoxRndvGuncelleHastaAd.Enabled = true;
            //txtBoxRndvGuncelleHastaSoyad.Enabled = true;
            //CBoxRndvGuncelleHastaSecBol.Enabled = true;
            //DateTimeRndvGuncelleRandvGunu.Enabled = true;
            //txtBoxRndvGuncelleRndvSaat.Enabled = true;
            //CBoxRndvGuncelleHastaSecDr.Enabled = true;
        }

        private void RandevuBilgileriniGetir()
        {
            //seçilen randevuya göre randevu bilgilerini listview a getiriyoruz.
            Randevu randevu = new Randevu();
            randevu.Randevu_id = Convert.ToInt32(listViewRandevuGuncelleRandevular.SelectedItems[0].Text);
            randevu= sekreterManager.RandevuIdyeGoreRandevuGetir(randevu.Randevu_id);
            txtBoxRndvGuncelleHastaTc.Text = randevu.Hasta_tcNo;
            txtBoxRndvGuncelleRandvGunu.Text = randevu.Randevu_tarihi;
            txtBoxRndvGuncelleRndvSaat.Text = randevu.Randevu_saati;
            


        }
        private void BtnUserRandevuGuncelle_Click(object sender, EventArgs e)
        {
            Randevu randevu = new Randevu();
            randevu.Randevu_id = Convert.ToInt32(listViewRandevuGuncelleRandevular.SelectedItems[0].Text);
            randevu.Randevu_tarihi = txtBoxRndvGuncelleRandvGunu.Text;
            randevu.Randevu_saati = txtBoxRndvGuncelleRndvSaat.Text;
            randevu.Hasta_tcNo = txtBoxRndvGuncelleHastaTc.Text;
            //randevu.Brans_adi = txtBoxRndvGuncelleBolum.Text;
            sekreterManager.RandevuGuncelle(randevu);
            MessageBox.Show("Randevu Güncellendi");
        }

        private void listViewRandevuGuncelleRandevular_SelectedIndexChanged(object sender, EventArgs e)
        {
            RandevuBilgileriniGetir();
            //Randevu randevu = new Randevu();
            //randevu.Randevu_id = Convert.ToInt32(listViewRandevuGuncelleRandevular.SelectedItems[0].Text);
            //randevu = sekreterManager.RandevuIdyeGoreRandevuGetir(randevu.Randevu_id);
            //txtBoxRndvGuncelleHastaTc.Text = randevu.Hasta_tcNo;
            //txtBoxRndvGuncelleBolum.Text = randevu.Brans_adi;
            //txtBoxRndvGuncelleRandvGunu.Text = randevu.Randevu_tarihi;
            //txtBoxRndvGuncelleRndvSaat.Text = randevu.Randevu_saati;
        }

      
    }
}
