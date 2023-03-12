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
    public partial class userSekrtrSil : UserControl
    {
        public userSekrtrSil()
        {
            InitializeComponent();
        }
        SekreterManager sekreterManager = new SekreterManager(new SekreterRepository());

        //Sekreter silme
        private void BtnUserSekrtrSil_Click(object sender, EventArgs e)
        {
            Sekreter sekreter= new Sekreter
            {
                Sekreter_tcno = txtBoxSekrtrSilTcNo.Text
            };
            sekreterManager.SekreterSil(sekreter);
            MessageBox.Show(sekreter.Sekreter_tcno+ " tc nolu sekreter silindi");
        }

       
    }
}
