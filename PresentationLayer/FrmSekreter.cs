using PresentationLayer.UserControls;
using PresentationLayer.UserControlsEkleme;
using PresentationLayer.UserControlsGuncelleme;
using PresentationLayer.UserControlsRandevu;
using PresentationLayer.UserControlsSilme;
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
    public partial class FrmSekreter : Form
    {
        //Alanlar
        private RoundButton currentBtn;
        private Panel leftBorderBtn;
        public UserControl currentChildUser;

        //DROPDOWN LIST İÇİN ALANLAR
        private bool isCollopsed1 = true;
        private bool isCollopsed2 = true;
        private bool isCollopsed3 = true;
        private bool isCollopsed4 = true;



        public FrmSekreter()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            panelSekrtrSolMenu.Controls.Add(leftBorderBtn);
        }

        private void FrmSekreter_Load(object sender, EventArgs e)
        {
            userSekrtrAnaSayfa userSekrtrAnaSayfa = new userSekrtrAnaSayfa();
            AnapanelSekrtr.Controls.Add(userSekrtrAnaSayfa);
            panelSekrtrEkleme.Size = panelSekrtrEkleme.MinimumSize;
            panelSekrtrSilme.Size = panelSekrtrSilme.MinimumSize;
            panelSekrtrGuncelleme.Size = panelSekrtrGuncelleme.MinimumSize;
            panelSekrtrRandevu.Size = panelSekrtrRandevu.MinimumSize;
        }

        //Metotlar
        private void ActivateButton(object senderBtn)
        {
            DisableButton();

            if (senderBtn != null)
            {
                //DisableButton();
                //button
                currentBtn = (RoundButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(19, 53, 24);


                //left border  button
                leftBorderBtn.BackColor = Color.FromArgb(74, 107, 73);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //icon current child form
                pBoxSekrtrHome.Image = currentBtn.Image;

            }
        }


        //FrmSekreter FORMUNDA AnaPanelSekrtr PANELİ İÇİNDE USERCONTROLLERİ AÇMAK İÇİN METOT
        private void OpenChildUser(UserControl childUser)
        {
            //EĞER PANEL İÇİNDE BİR USERCONTROL VARSA ONU TEMİZLE DEMEK
            if (currentChildUser != null)
            {
                //open only form
                currentChildUser.Controls.Clear();

            }
            //currentChildUser = childUser;
            childUser.Dock = DockStyle.Fill;
            AnapanelSekrtr.Controls.Add(childUser);
            AnapanelSekrtr.Tag = childUser;
            childUser.BringToFront();
            childUser.Show();
            lblSekrtrAnaSayfa.Text = childUser.Tag.ToString();
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(19, 53, 24);
                currentBtn.ForeColor = Color.Transparent;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            pBoxSekrtrHome.Image = global::PresentationLayer.Properties.Resources.home1;
            lblSekrtrAnaSayfa.Text = "ANA SAYFA";
        }


        private void FrmSekreter_FormClosing(object sender, FormClosingEventArgs e)
        {
            //formun çarpı tuşuna basınca program kapansın
            Application.Exit();
        }

        //TIMERLAR START
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollopsed1)
            {
                panelSekrtrEkleme.Height += 10;
                if (panelSekrtrEkleme.Size == panelSekrtrEkleme.MaximumSize)
                {
                    timer1.Stop();
                    isCollopsed1 = false;
                }
            }
            else
            {
                panelSekrtrEkleme.Height -= 10;
                if (panelSekrtrEkleme.Size == panelSekrtrEkleme.MinimumSize)
                {
                    timer1.Stop();
                    isCollopsed1 = true;
                }
            }
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollopsed2)
            {
                panelSekrtrSilme.Height += 10;
                if (panelSekrtrSilme.Size == panelSekrtrSilme.MaximumSize)
                {
                    timer2.Stop();
                    isCollopsed2 = false;
                }
            }
            else
            {
                panelSekrtrSilme.Height -= 10;
                if (panelSekrtrSilme.Size == panelSekrtrSilme.MinimumSize)
                {
                    timer2.Stop();
                    isCollopsed2 = true;
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isCollopsed3)
            {
                panelSekrtrGuncelleme.Height += 10;
                if (panelSekrtrGuncelleme.Size == panelSekrtrGuncelleme.MaximumSize)
                {
                    timer3.Stop();
                    isCollopsed3 = false;
                }
            }
            else
            {
                panelSekrtrGuncelleme.Height -= 10;
                if (panelSekrtrGuncelleme.Size == panelSekrtrGuncelleme.MinimumSize)
                {
                    timer3.Stop();
                    isCollopsed3 = true;
                }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (isCollopsed4)
            {
                panelSekrtrRandevu.Height += 10;
                if (panelSekrtrRandevu.Size == panelSekrtrRandevu.MaximumSize)
                {
                    timer4.Stop();
                    isCollopsed4 = false;
                }
            }
            else
            {
                panelSekrtrRandevu.Height -= 10;
                if (panelSekrtrRandevu.Size == panelSekrtrRandevu.MinimumSize)
                {
                    timer4.Stop();
                    isCollopsed4 = true;
                }
            }
        }

        //TIMERLAR END




        //EKLEME İŞLEMLERİ
        private void BtnSekrtrEkleme_Click(object sender, EventArgs e)
        {

            isCollopsed2 = false;
            isCollopsed3 = false;
            isCollopsed4 = false;

            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();

            DisableButton();
            leftBorderBtn.Visible = false;
            
        }

        private void BtnSekrtrHastaEkle_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            leftBorderBtn.Size = new Size(7, 46);
            leftBorderBtn.Location = new Point(0, 269);
            userHastaEkle userHastaEkle = new userHastaEkle();
            OpenChildUser(userHastaEkle);
            
        }

        private void BtnSekrtrDrEkle_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            leftBorderBtn.Size = new Size(7, 46);
            leftBorderBtn.Location = new Point(0, 315);
            userDrEkle userDrEkle = new userDrEkle();
            OpenChildUser(userDrEkle);
            

        }

        private void BtnSekrtrSekrtrEkle_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            leftBorderBtn.Size = new Size(7, 46);
            leftBorderBtn.Location = new Point(0, 361);
            userSekrtrEkle userSekrtrEkle = new userSekrtrEkle();
            OpenChildUser(userSekrtrEkle);
            
        }

        //EKLEME İŞLEMLERİ BİTTİ

        //SİLME İŞLEMLERİ
        private void BtnSekrtrSilme_Click(object sender, EventArgs e)
        {

            isCollopsed1 = false;
            isCollopsed3 = false;
            isCollopsed4 = false;

            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();

            DisableButton();
            leftBorderBtn.Visible = false;
        }

        private void BtnSekrtrHastaSil_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            leftBorderBtn.Size = new Size(7, 46);
            leftBorderBtn.Location = new Point(0, 327);
            userHastaSil userHastaSil = new userHastaSil();
            OpenChildUser(userHastaSil);
            
        }


        private void BtnSekrtrDrSil_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            leftBorderBtn.Size = new Size(7, 46);
            leftBorderBtn.Location = new Point(0, 373);
            userDrSil userDrSil = new userDrSil();
            OpenChildUser(userDrSil);

        }


        private void BtnSekrtrSekrtrSil_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            leftBorderBtn.Size = new Size(7, 46);
            leftBorderBtn.Location = new Point(0, 419);
            userSekrtrSil userSekrtrSil = new userSekrtrSil();
            OpenChildUser(userSekrtrSil);
            

        }

        //SİLME İŞLEMLERİ BİTTİ

        //GÜNCELLEME İŞLEMLERİ
        private void BtnSekrtrGuncelleme_Click(object sender, EventArgs e)
        {

            isCollopsed1 = false;
            isCollopsed2 = false;
            isCollopsed4 = false;

            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();

            DisableButton();
            leftBorderBtn.Visible = false;
        }

        private void BtnSekrtrHastaGuncelle_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            leftBorderBtn.Size = new Size(7, 46);
            leftBorderBtn.Location = new Point(0, 385);
            userHastaGuncelle userHastaGuncelle = new userHastaGuncelle();
            OpenChildUser(userHastaGuncelle);
            
        }


        private void BtnSekrtrDrGuncelle_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            leftBorderBtn.Size = new Size(7, 46);
            leftBorderBtn.Location = new Point(0, 431);
            userDrGuncelle userDrGuncelle = new userDrGuncelle();
            OpenChildUser(userDrGuncelle);
            
        }



        private void BtnSekrtrSekrtrGuncelle_Click(object sender, EventArgs e)
        {
            //hangi butona basılı olduğunu görmek için bu fonksiyonu çağırıyoruz
            ActivateButton(sender);
            //soldaki yeşil renk çizgi için büyüklüğü ve yerini belirliyoruz
            leftBorderBtn.Size = new Size(7, 46);
            leftBorderBtn.Location = new Point(0, 477);
            //anapaneli temizler ve usersekrtrguncelle formunu getirir gösterir
            userSekrtrGuncelle userSekrtrGuncelle = new userSekrtrGuncelle();
            OpenChildUser(userSekrtrGuncelle);
            
        }

        //GÜNCELLEME İŞLEMİ BİTTİ

        //RANDEVU İŞLEMİ BAŞLANGIÇ

        private void BtnSekrtrRandevu_Click(object sender, EventArgs e)
        {

            isCollopsed1 = false;
            isCollopsed2 = false;
            isCollopsed3 = false;

            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();

            DisableButton();
            leftBorderBtn.Visible = false;
        }

        private void BtnSekrtrRandevuAl_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            leftBorderBtn.Size = new Size(7, 46);
            leftBorderBtn.Location = new Point(0, 443);
            UserRandevuAl userRandevuAl = new UserRandevuAl();
            OpenChildUser(userRandevuAl);
        }

        private void BtnSekrtrRandevuSil_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            leftBorderBtn.Size = new Size(7, 46);
            leftBorderBtn.Location = new Point(0, 489);
            UserRandevuSil userRandevuSil = new UserRandevuSil();
            OpenChildUser(userRandevuSil);
        }

        private void BtnSekrtrRandevuGuncelle_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            leftBorderBtn.Size = new Size(7, 46);
            leftBorderBtn.Location = new Point(0, 535);
            UserRandevuGuncelle userRandevuGuncelle = new UserRandevuGuncelle();
            OpenChildUser(userRandevuGuncelle);
        }

        //RANDEVU İŞLEMİ BİTTİ

        //ANA SAYFAYA GERİ DÖN BUTONU
        private void BtnSekrtrGeri_Click(object sender, EventArgs e)
        {
            //eğer logoya basarsak ve dropdow listlerden herhangi biri açık olursa logaya bastıktan sonra hepsi kapanıcak
            if (isCollopsed1 == true || isCollopsed2 == true || isCollopsed3 == true)
            {
                isCollopsed1 = false;
                isCollopsed2 = false;
                isCollopsed3 = false;

                timer1.Start();
                timer2.Start();
                timer3.Start();
            }

            //logoya basınca anapanelde bir şey varsa onu temizliyor ve ana sayfayı getiriyor
            AnapanelSekrtr.Controls.Clear();
            userSekrtrAnaSayfa userSekrtrAnaSayfa = new userSekrtrAnaSayfa();
            AnapanelSekrtr.Controls.Add(userSekrtrAnaSayfa);
            Reset();
        }


        //ÇIKIŞ YAP BUTONU
        private void BtnSekrtrCıkısYap_Click(object sender, EventArgs e)
        {
            FrmRolSecimi frmRolSecimi = new FrmRolSecimi();
            frmRolSecimi.Show();
            this.Hide();
        }

        

        bool tutus;
        int FareX, FareY;
        private void panelTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            tutus = false;
            FareX = 0;
            FareY = 0;
        }

        private void panelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (tutus)
            {
                this.Left = Cursor.Position.X - FareX;
                this.Top = Cursor.Position.Y - FareY;
            }
        }


        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
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
