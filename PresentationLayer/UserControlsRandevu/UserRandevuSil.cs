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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PresentationLayer.UserControlsRandevu
{
    public partial class UserRandevuSil : UserControl
    {
        public UserRandevuSil()
        {
            InitializeComponent();
            
        }
        SekreterManager sekreterManager = new SekreterManager(new SekreterRepository());
        
        private void BtnUserRandevuSil_Click(object sender, EventArgs e)
        {
            int randevu_id =  Convert.ToInt32(ListViewRandevular.SelectedItems[0].Text);
            sekreterManager.RandevuSil(randevu_id);
            MessageBox.Show("Randevu silindi.");
        }
   
        private void BtnUserRandevuGetir_Click(object sender, EventArgs e)
        {
            //Randevu randevu = new Randevu 
            //{
            //    Brans_adi = txtBoxRandevuSilBrans.Text,
              
            //    Randevu_saati = txtBoxRandevuSilRndvSaat.Text,
            //    Randevu_tarihi = txtBoxRandevuSilRandevuGunu.Text,
               
            //};
            string Hasta_tcNo = txtBoxRandevuSilHastaTc.Text;

            //sekreterRepository.HastayaGoreRandevuGetir(Hasta_tcNo);

           var randevular = sekreterManager.HastayaGoreRandevulariGetir(Hasta_tcNo);
            ListViewRandevular.Items.Clear();
            foreach (Randevu r in randevular)
            {
                ListViewItem item = new ListViewItem(r.Randevu_id.ToString());
                item.SubItems.Add(r.Hasta_tcNo);
                item.SubItems.Add(r.Doktor_id.ToString());
                item.SubItems.Add(r.Randevu_tarihi.ToString());
                item.SubItems.Add(r.Randevu_saati.ToString());
                item.SubItems.Add(r.Brans_adi.ToString());
               
                ListViewRandevular.Items.Add(item);
            }

        }
    }
}
