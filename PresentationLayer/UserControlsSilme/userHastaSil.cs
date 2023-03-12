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

namespace PresentationLayer.UserControlsSilme
{
    public partial class userHastaSil : UserControl
    {
        public userHastaSil()
        {
            InitializeComponent();
        }
        SekreterManager sekreterManager = new SekreterManager(new SekreterRepository());
        private void BtnUserHastaSil_Click(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta 
            {
                Hasta_tcno= txtHastaKaydiSilmeHastaTcNo.Text
            };
            sekreterManager.Hastasil(hasta);
            MessageBox.Show(hasta.Hasta_tcno + " tc nolu hasta silindi");

        }

        //private void BtnUserHastaSilKayitGetir_Click(object sender, EventArgs e)
        //{
        //    //string hastaTcno = txtHastaKaydiSilmeHastaTcNo.Text;
        //    //var hasta = sekreterManager.DoktorGetir(hastaTcno);

        //    //listViewHastaSilKayitlar.Items.Clear();


        //    //ListViewItem item = new ListViewItem(hasta..ToString());
        //    //item.SubItems.Add(doktor.Doktor_adi);
        //    //item.SubItems.Add(doktor.Doktor_soyadi);
        //    //item.SubItems.Add(doktor.Doktor_bransid.ToString());
        //    //item.SubItems.Add(doktor.Doktor_cinsiyeti);


        //    //listViewDrSilKayitlar.Items.Add(item);
        //}
    }
}
