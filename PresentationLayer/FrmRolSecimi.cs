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
    public partial class FrmRolSecimi : Form
    {
        public FrmRolSecimi()
        {
            InitializeComponent();
        }

        private void BtnSekreter_Click(object sender, EventArgs e)
        {

            FrmSekreterGiris frmSekreterGiris = new FrmSekreterGiris();
            frmSekreterGiris.Show();
            this.Hide();
        }

        private void FrmRolSecimi_FormClosing(object sender, FormClosingEventArgs e)
        {
            //formun çarpı tuşuna basınca program kapansın
            Application.Exit();
        }

        private void BtnDoktor_Click(object sender, EventArgs e)
        { 
            

            FrmDoktorGiris frmDoktor = new FrmDoktorGiris();
            frmDoktor.Show();
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
