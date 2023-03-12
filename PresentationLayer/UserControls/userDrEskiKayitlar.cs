using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.AccessDb;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.UserControls
{
    public partial class userDrEskiKayitlar : UserControl
    {
        public userDrEskiKayitlar()
        {
            InitializeComponent();
        }
        SekreterManager sekreterManager = new SekreterManager(new SekreterRepository());
      
        private void userDrEskiKayitlar_Load(object sender, EventArgs e)
        {
            CBoxEskiKayitDoktor = sekreterManager.DoktorlariGetir(CBoxEskiKayitDoktor);
        }
        private void BtnDrKayitGetir_Click(object sender, EventArgs e)
        {
            Randevu randevu = new Randevu()
            {
                Doktor_id = (int)CBoxEskiKayitDoktor.SelectedValue,
                Hasta_tcNo=textBoxEskiKayıtHastaTc.Text,
                Randevu_tarihi = textBoxEskiKayitTarih.Text,
                Randevu_saati = textBoxEskiKayitSaat.Text
                
            };
            string randevuNotu= sekreterManager.EskiRandevuKayitlariniGetir(randevu);
            DrTxtBoxEskiRandevuNotu.Text = randevuNotu;
        }

      
    }
}
