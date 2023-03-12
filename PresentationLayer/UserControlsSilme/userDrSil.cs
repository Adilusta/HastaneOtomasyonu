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

namespace PresentationLayer.UserControlsSilme
{
    public partial class userDrSil : UserControl
    {
        public userDrSil()
        {
            InitializeComponent();
        }
        SekreterManager sekreterManager = new SekreterManager(new SekreterRepository());

        //Doktor silme
        private void BtnUserDrSil_Click(object sender, EventArgs e)
        {
            Doktor doktor = new Doktor
            {
                Doktor_tcNo = txtBoxDrSilTcNo.Text
            };
            sekreterManager.DoktorSil(doktor);
            MessageBox.Show(doktor.Doktor_tcNo + " tc nolu doktor silindi");
            txtBoxDrSilTcNo.Text = "";
        }

        //private void BtnUserDrSilKayitGetir_Click(object sender, EventArgs e)
        //{
        //    string doktorTcno = txtBoxDrSilTcNo.Text;
        //    var doktor = sekreterManager.DoktorGetir(doktorTcno);

        //    listViewDrSilKayitlar.Items.Clear();


        //    ListViewItem item = new ListViewItem(doktor.Doktor_id.ToString());
        //    item.SubItems.Add(doktor.Doktor_adi);
        //    item.SubItems.Add(doktor.Doktor_soyadi);
        //    item.SubItems.Add(doktor.Doktor_bransid.ToString());
        //    item.SubItems.Add(doktor.Doktor_cinsiyeti);


        //    listViewDrSilKayitlar.Items.Add(item);

        //}
    }
}
