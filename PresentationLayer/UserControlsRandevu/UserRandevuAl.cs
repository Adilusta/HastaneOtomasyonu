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
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControlsRandevu
{
    public partial class UserRandevuAl : UserControl
    {
        SekreterManager sekreterManager = new SekreterManager(new SekreterRepository());
 
        public UserRandevuAl()
        {
            InitializeComponent();
        }

        private void BtnUserRandevuEkle_Click(object sender, EventArgs e)
        {
            Randevu randevu = new Randevu();
            randevu.Hasta_tcNo = txtBoxRandevuEkleHastaTc.Text;
            randevu.Doktor_id = Convert.ToInt32(listViewDoktorlar.SelectedItems[0].Text);
            randevu.Randevu_tarihi = txtRandevuTarihi.Text;
            randevu.Randevu_saati = txtBoxRandevuEkleRndvSaat.Text;
            randevu.Brans_id = (int)ComboBoxRandevuEkleHastaSecBol.SelectedValue;
            if (sekreterManager.HastaMevcutMu(randevu.Hasta_tcNo))
            {
                sekreterManager.RandevuEkle(randevu);
                MessageBox.Show("Randevu Eklendi");
            }
            else
            {
                MessageBox.Show("Hasta tc no geçersiz,lütfen geçerli bir tc no giriniz.");
                txtBoxRandevuEkleHastaTc.Clear();
            }
            
        }

        private void UserRandevuAl_Load(object sender, EventArgs e)
        {
            BranslariGetir();
            BransaGoreDoktorGetir();



        }
        private void BransaGoreDoktorGetir()
        {
            int brans_id = (int) ComboBoxRandevuEkleHastaSecBol.SelectedValue;
            List<Doktor> doktorlar = sekreterManager.BransaGoreDoktorGetir(brans_id);
            listViewDoktorlar.Items.Clear();
            foreach (Doktor doktor in doktorlar)
            {
                ListViewItem item = new ListViewItem(doktor.Doktor_id.ToString());
                item.SubItems.Add(doktor.Doktor_adi);
                item.SubItems.Add(doktor.Doktor_soyadi);
                item.SubItems.Add((doktor.Doktor_bransid).ToString());

                listViewDoktorlar.Items.Add(item);
            }

        }
        private void BranslariGetir()
        {
            var branslar = sekreterManager.BranslariGetir(ComboBoxRandevuEkleHastaSecBol);
            ComboBoxRandevuEkleHastaSecBol = branslar;
        }

 

        private void CBoxRandevuEkleHastaSecBol_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            
        
            //var branslar = sekreterManager.BranslariGetir(CBoxRandevuEkleHastaSecBol);
            //CBoxRandevuEkleHastaSecBol = branslar;
            //int brans_id = Convert.ToInt32(CBoxRandevuEkleHastaSecBol.SelectedIndex);
            //var doktorlar = sekreterManager.BransaGoreDoktorGetir(CBoxRandevuEkleHastaSecDr, brans_id);
            //CBoxRandevuEkleHastaSecDr = doktorlar;
        }

        

        private void BtnUserRndvDrGetir_Click(object sender, EventArgs e)
        {
             BransaGoreDoktorGetir();
        }

       
    }
}
