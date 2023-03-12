using PresentationLayer.UserControls;
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
    public partial class FrmDoktor : Form
    {

        //Alanlar
        private RoundButton currentBtn;
        private Panel leftBorderBtn;
        public UserControl currentChildUser;

        public FrmDoktor()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 72);
            panelDrSolMenu.Controls.Add(leftBorderBtn);
        }


        private void FrmDoktor_Load(object sender, EventArgs e)
        {
            userDrAnaSayfa userDrAnaSayfa = new userDrAnaSayfa();
            AnaPanelDr.Controls.Add(userDrAnaSayfa);
        }

        private void ActivateButton(object senderBtn)
        {
            DisableButton();
            if (senderBtn != null)
            {
                //button
                currentBtn = (RoundButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(19, 53, 24);


                //left border  button
                leftBorderBtn.BackColor = Color.FromArgb(74, 107, 73);
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //icon current child form
                pBoxDrHome.Image = currentBtn.Image;

            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(19, 53, 24);
                currentBtn.ForeColor = Color.Transparent;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                //currentBtn.Iconcolor = Color.Transparent;

            }
        }

        private void OpenChildUser(UserControl childUser)
        {

            if (currentChildUser != null)
            {
                //open only form
                currentChildUser.Controls.Clear();

            }
            childUser.Dock = DockStyle.Fill;
            AnaPanelDr.Controls.Add(childUser);
            AnaPanelDr.Tag = childUser;
            childUser.BringToFront();
            childUser.Show();
            lblDrAnaSayfa.Text = childUser.Tag.ToString();


        }


        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            pBoxDrHome.Image = global::PresentationLayer.Properties.Resources.home1;
            lblDrAnaSayfa.Text = "ANA SAYFA";
        }


        private void BtnDrGorusmeKayit_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            userDrRandevuKayitlari userDrGorusmeKayitlari = new userDrRandevuKayitlari();
            OpenChildUser(userDrGorusmeKayitlari);
        }

        private void BtnDrEskiKayit_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            userDrEskiKayitlar userDrEskiKayitlar = new userDrEskiKayitlar();
            OpenChildUser(userDrEskiKayitlar);
        }

        private void BtnDrGeri_Click(object sender, EventArgs e)
        {
            userDrAnaSayfa userDrAnaSayfa = new userDrAnaSayfa();
            OpenChildUser(userDrAnaSayfa);
        }

        private void BtnDrCıkısYap_Click(object sender, EventArgs e)
        {
            FrmRolSecimi frmRolSecimi = new FrmRolSecimi();
            frmRolSecimi.Show();
            this.Hide();
        }

        bool tutus;
        int FareX, FareY;
        private void panelDrTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            tutus = false;
            FareX = 0;
            FareY = 0;
        }

        private void panelDrTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (tutus)
            {
                this.Left = Cursor.Position.X - FareX;
                this.Top = Cursor.Position.Y - FareY;
            }
        }


        private void panelDrTitleBar_MouseDown(object sender, MouseEventArgs e)
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
