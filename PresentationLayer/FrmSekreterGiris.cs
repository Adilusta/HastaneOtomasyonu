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
using System.Drawing;

namespace PresentationLayer
{
    public partial class FrmSekreterGiris : Form
    {
        SekreterManager sekreterManager = new SekreterManager(new SekreterRepository());
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }

        private void BtnSekrtrGiris_Click(object sender, EventArgs e)
        {
            //Sekreter giriş işlemleri
            Sekreter sekreter = new Sekreter
            {
                Sekreter_email = txtBoxSekrtrGirisEmail.Text,
                Sekreter_sifre = txtBoxSekrtrGirisSifre.Text
            };

            bool girisBasariliMi = sekreterManager.GirisBasariliMi(sekreter);
            if (girisBasariliMi)

            {  //Yeni forma yönlendirme
                
                FrmSekreter frmSekreter = new FrmSekreter();
                frmSekreter.Show();
                this.Hide();
            }
            else
            {
                //kullanıcıyı bilgilendirme
                MessageBox.Show("Hatalı bilgi girişi yaptınız.");
            }

            
           
            //FrmSekreterr frmSekreterr = new FrmSekreterr();
            //frmSekreterr.Show();
            //this.Hide();

        }

        private void FrmSekreterGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SekrtrBtnGeri_Click(object sender, EventArgs e)
        {
            FrmRolSecimi frmRolSecimi = new FrmRolSecimi();
            frmRolSecimi.Show();
            this.Hide();
        }

        private void txtBoxSekrtrGirisEmail_Click(object sender, EventArgs e)
        {
            txtBoxSekrtrGirisEmail.BackColor = SystemColors.Control;
        }


        bool tutus;
        int FareX, FareY;
        private void AnaPanel_MouseUp(object sender, MouseEventArgs e)
        {
            tutus = false;
            FareX = 0;
            FareY = 0;
        }

        private void AnaPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (tutus)
            {
                this.Left = Cursor.Position.X - FareX;
                this.Top = Cursor.Position.Y - FareY;
            }
        }


        private void AnaPanel_MouseDown(object sender, MouseEventArgs e)
        {
            tutus = true;
            FareX = Cursor.Position.X - this.Left;
            FareY = Cursor.Position.Y - this.Top;
        }


        private void pBoxSifreGoster_MouseDown(object sender, MouseEventArgs e)
        {
            txtBoxSekrtrGirisSifre.UseSystemPasswordChar = false;
        }

        private void pBoxSifreGoster_MouseUp(object sender, MouseEventArgs e)
        {
            txtBoxSekrtrGirisSifre.UseSystemPasswordChar = true;
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAltEkran_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
