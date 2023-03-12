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

namespace PresentationLayer
{
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }

        DoktorManager doktorManager = new DoktorManager(new DoktorRepository());

        private void FrmDoktor_FormClosing(object sender, FormClosingEventArgs e)
        {
            //çarpıya basınca program kapansın
            Application.Exit();
        }

        private void DrBtnGiris_Click(object sender, EventArgs e)
        {
            //Doktor Giriş İşlemi
            Doktor doktor = new Doktor
            {
                Doktor_email = txtBoxDrGirisEmail.Text,
                Doktor_sifre = txtBoxDrGirisSifre.Text
            };

            bool girisBasariliMi = doktorManager.GirisBasariliMi(doktor);
            if (girisBasariliMi)
                
            { //Yeni forma yönlendirme
                FrmDoktor frmDoktor = new FrmDoktor();
                frmDoktor.Show();
                this.Hide();
            }
            else
            {
                //kullanıcıyı bilgilendirme
                MessageBox.Show("Hatalı bilgi girişi yaptınız.");
            }

        }

        private void DrBtnGeri_Click(object sender, EventArgs e)
        {
            //geri butonuna basınca rol seçimine dönsün
            FrmRolSecimi frmRolSecimi = new FrmRolSecimi();
            frmRolSecimi.Show();
            this.Hide();
            
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
            txtBoxDrGirisSifre.UseSystemPasswordChar = false;
        }

        private void pBoxSifreGoster_MouseUp(object sender, MouseEventArgs e)
        {
            txtBoxDrGirisSifre.UseSystemPasswordChar = true;
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
