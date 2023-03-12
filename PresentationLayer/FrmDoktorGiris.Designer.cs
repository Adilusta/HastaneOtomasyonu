namespace PresentationLayer
{
    partial class FrmDoktorGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorGiris));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelSolDr = new System.Windows.Forms.Panel();
            this.pBoxDr = new System.Windows.Forms.PictureBox();
            this.lblDrGirisBaslik = new System.Windows.Forms.Label();
            this.txtBoxDrGirisSifre = new System.Windows.Forms.TextBox();
            this.txtBoxDrGirisEmail = new System.Windows.Forms.TextBox();
            this.lblDrGirisSifre = new System.Windows.Forms.Label();
            this.lblDrGirisEmail = new System.Windows.Forms.Label();
            this.pBoxLoginFoto = new System.Windows.Forms.PictureBox();
            this.AnaPanel = new System.Windows.Forms.Panel();
            this.BtnAltEkran = new System.Windows.Forms.Button();
            this.BtnKapat = new System.Windows.Forms.Button();
            this.pBoxSifreGoster = new System.Windows.Forms.PictureBox();
            this.DrBtnGiris = new PresentationLayer.RoundButton();
            this.DrBtnGeri = new PresentationLayer.RoundButton();
            this.panelSolDr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLoginFoto)).BeginInit();
            this.AnaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSifreGoster)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "login.png");
            this.ımageList1.Images.SetKeyName(1, "back.png");
            // 
            // panelSolDr
            // 
            this.panelSolDr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(33)))), ((int)(((byte)(9)))));
            this.panelSolDr.Controls.Add(this.pBoxDr);
            this.panelSolDr.Controls.Add(this.lblDrGirisBaslik);
            this.panelSolDr.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSolDr.Location = new System.Drawing.Point(0, 0);
            this.panelSolDr.Name = "panelSolDr";
            this.panelSolDr.Size = new System.Drawing.Size(332, 810);
            this.panelSolDr.TabIndex = 3;
            // 
            // pBoxDr
            // 
            this.pBoxDr.Image = global::PresentationLayer.Properties.Resources.doctor2;
            this.pBoxDr.Location = new System.Drawing.Point(12, 21);
            this.pBoxDr.Name = "pBoxDr";
            this.pBoxDr.Size = new System.Drawing.Size(320, 346);
            this.pBoxDr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxDr.TabIndex = 24;
            this.pBoxDr.TabStop = false;
            // 
            // lblDrGirisBaslik
            // 
            this.lblDrGirisBaslik.AutoSize = true;
            this.lblDrGirisBaslik.Font = new System.Drawing.Font("Goudy Stout", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrGirisBaslik.ForeColor = System.Drawing.Color.White;
            this.lblDrGirisBaslik.Location = new System.Drawing.Point(34, 393);
            this.lblDrGirisBaslik.Name = "lblDrGirisBaslik";
            this.lblDrGirisBaslik.Size = new System.Drawing.Size(303, 117);
            this.lblDrGirisBaslik.TabIndex = 3;
            this.lblDrGirisBaslik.Text = "   DOKTOR \r\n      GİRİŞ \r\n  SAYFASI";
            // 
            // txtBoxDrGirisSifre
            // 
            this.txtBoxDrGirisSifre.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDrGirisSifre.Location = new System.Drawing.Point(528, 462);
            this.txtBoxDrGirisSifre.Name = "txtBoxDrGirisSifre";
            this.txtBoxDrGirisSifre.Size = new System.Drawing.Size(589, 39);
            this.txtBoxDrGirisSifre.TabIndex = 22;
            this.txtBoxDrGirisSifre.UseSystemPasswordChar = true;
            // 
            // txtBoxDrGirisEmail
            // 
            this.txtBoxDrGirisEmail.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDrGirisEmail.Location = new System.Drawing.Point(528, 385);
            this.txtBoxDrGirisEmail.Name = "txtBoxDrGirisEmail";
            this.txtBoxDrGirisEmail.Size = new System.Drawing.Size(589, 39);
            this.txtBoxDrGirisEmail.TabIndex = 21;
            // 
            // lblDrGirisSifre
            // 
            this.lblDrGirisSifre.AutoSize = true;
            this.lblDrGirisSifre.Font = new System.Drawing.Font("Lucida Handwriting", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrGirisSifre.ForeColor = System.Drawing.Color.White;
            this.lblDrGirisSifre.Location = new System.Drawing.Point(396, 462);
            this.lblDrGirisSifre.Name = "lblDrGirisSifre";
            this.lblDrGirisSifre.Size = new System.Drawing.Size(135, 48);
            this.lblDrGirisSifre.TabIndex = 20;
            this.lblDrGirisSifre.Text = "Şifre:";
            // 
            // lblDrGirisEmail
            // 
            this.lblDrGirisEmail.AutoSize = true;
            this.lblDrGirisEmail.Font = new System.Drawing.Font("Lucida Handwriting", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrGirisEmail.ForeColor = System.Drawing.Color.White;
            this.lblDrGirisEmail.Location = new System.Drawing.Point(351, 385);
            this.lblDrGirisEmail.Name = "lblDrGirisEmail";
            this.lblDrGirisEmail.Size = new System.Drawing.Size(180, 48);
            this.lblDrGirisEmail.TabIndex = 18;
            this.lblDrGirisEmail.Text = "E-mail:";
            // 
            // pBoxLoginFoto
            // 
            this.pBoxLoginFoto.Image = global::PresentationLayer.Properties.Resources.multiple_user;
            this.pBoxLoginFoto.Location = new System.Drawing.Point(588, 30);
            this.pBoxLoginFoto.Name = "pBoxLoginFoto";
            this.pBoxLoginFoto.Size = new System.Drawing.Size(327, 292);
            this.pBoxLoginFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxLoginFoto.TabIndex = 0;
            this.pBoxLoginFoto.TabStop = false;
            // 
            // AnaPanel
            // 
            this.AnaPanel.Controls.Add(this.BtnAltEkran);
            this.AnaPanel.Controls.Add(this.BtnKapat);
            this.AnaPanel.Controls.Add(this.pBoxSifreGoster);
            this.AnaPanel.Controls.Add(this.txtBoxDrGirisEmail);
            this.AnaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnaPanel.Location = new System.Drawing.Point(0, 0);
            this.AnaPanel.Name = "AnaPanel";
            this.AnaPanel.Size = new System.Drawing.Size(1187, 810);
            this.AnaPanel.TabIndex = 24;
            this.AnaPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnaPanel_MouseDown);
            this.AnaPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AnaPanel_MouseMove);
            this.AnaPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AnaPanel_MouseUp);
            // 
            // BtnAltEkran
            // 
            this.BtnAltEkran.BackgroundImage = global::PresentationLayer.Properties.Resources.minus;
            this.BtnAltEkran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAltEkran.FlatAppearance.BorderSize = 0;
            this.BtnAltEkran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAltEkran.ImageKey = "(none)";
            this.BtnAltEkran.Location = new System.Drawing.Point(1126, 0);
            this.BtnAltEkran.Name = "BtnAltEkran";
            this.BtnAltEkran.Size = new System.Drawing.Size(33, 31);
            this.BtnAltEkran.TabIndex = 32;
            this.BtnAltEkran.UseVisualStyleBackColor = true;
            this.BtnAltEkran.Click += new System.EventHandler(this.BtnAltEkran_Click);
            // 
            // BtnKapat
            // 
            this.BtnKapat.BackgroundImage = global::PresentationLayer.Properties.Resources.letter_x;
            this.BtnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKapat.FlatAppearance.BorderSize = 0;
            this.BtnKapat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnKapat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKapat.Location = new System.Drawing.Point(1154, 0);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(33, 31);
            this.BtnKapat.TabIndex = 31;
            this.BtnKapat.UseVisualStyleBackColor = true;
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // pBoxSifreGoster
            // 
            this.pBoxSifreGoster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBoxSifreGoster.Image = global::PresentationLayer.Properties.Resources.padlock__2_;
            this.pBoxSifreGoster.Location = new System.Drawing.Point(1117, 456);
            this.pBoxSifreGoster.Name = "pBoxSifreGoster";
            this.pBoxSifreGoster.Size = new System.Drawing.Size(39, 39);
            this.pBoxSifreGoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxSifreGoster.TabIndex = 30;
            this.pBoxSifreGoster.TabStop = false;
            this.pBoxSifreGoster.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBoxSifreGoster_MouseDown);
            this.pBoxSifreGoster.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pBoxSifreGoster_MouseUp);
            // 
            // DrBtnGiris
            // 
            this.DrBtnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.DrBtnGiris.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.DrBtnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DrBtnGiris.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.DrBtnGiris.BorderRadius = 40;
            this.DrBtnGiris.BorderSize = 0;
            this.DrBtnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrBtnGiris.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.DrBtnGiris.FlatAppearance.BorderSize = 0;
            this.DrBtnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrBtnGiris.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrBtnGiris.ForeColor = System.Drawing.Color.White;
            this.DrBtnGiris.ImageKey = "login.png";
            this.DrBtnGiris.ImageList = this.ımageList1;
            this.DrBtnGiris.Location = new System.Drawing.Point(453, 588);
            this.DrBtnGiris.Name = "DrBtnGiris";
            this.DrBtnGiris.Size = new System.Drawing.Size(254, 61);
            this.DrBtnGiris.TabIndex = 23;
            this.DrBtnGiris.Text = " G İ R İ Ş";
            this.DrBtnGiris.TextColor = System.Drawing.Color.White;
            this.DrBtnGiris.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DrBtnGiris.UseVisualStyleBackColor = false;
            this.DrBtnGiris.Click += new System.EventHandler(this.DrBtnGiris_Click);
            // 
            // DrBtnGeri
            // 
            this.DrBtnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.DrBtnGeri.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.DrBtnGeri.BorderColor = System.Drawing.Color.Empty;
            this.DrBtnGeri.BorderRadius = 40;
            this.DrBtnGeri.BorderSize = 0;
            this.DrBtnGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrBtnGeri.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.DrBtnGeri.FlatAppearance.BorderSize = 0;
            this.DrBtnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrBtnGeri.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold);
            this.DrBtnGeri.ForeColor = System.Drawing.Color.White;
            this.DrBtnGeri.ImageKey = "back.png";
            this.DrBtnGeri.ImageList = this.ımageList1;
            this.DrBtnGeri.Location = new System.Drawing.Point(803, 588);
            this.DrBtnGeri.Name = "DrBtnGeri";
            this.DrBtnGeri.Size = new System.Drawing.Size(254, 61);
            this.DrBtnGeri.TabIndex = 17;
            this.DrBtnGeri.Text = " G E R İ";
            this.DrBtnGeri.TextColor = System.Drawing.Color.White;
            this.DrBtnGeri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DrBtnGeri.UseVisualStyleBackColor = false;
            this.DrBtnGeri.Click += new System.EventHandler(this.DrBtnGeri_Click);
            // 
            // FrmDoktorGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(90)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1187, 810);
            this.Controls.Add(this.DrBtnGiris);
            this.Controls.Add(this.pBoxLoginFoto);
            this.Controls.Add(this.panelSolDr);
            this.Controls.Add(this.txtBoxDrGirisSifre);
            this.Controls.Add(this.DrBtnGeri);
            this.Controls.Add(this.lblDrGirisSifre);
            this.Controls.Add(this.lblDrGirisEmail);
            this.Controls.Add(this.AnaPanel);
            this.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDoktorGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDoktor_FormClosing);
            this.panelSolDr.ResumeLayout(false);
            this.panelSolDr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLoginFoto)).EndInit();
            this.AnaPanel.ResumeLayout(false);
            this.AnaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSifreGoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Panel panelSolDr;
        private System.Windows.Forms.Label lblDrGirisBaslik;
        private System.Windows.Forms.TextBox txtBoxDrGirisSifre;
        private System.Windows.Forms.TextBox txtBoxDrGirisEmail;
        private System.Windows.Forms.Label lblDrGirisSifre;
        private System.Windows.Forms.Label lblDrGirisEmail;
        private RoundButton DrBtnGeri;
        private System.Windows.Forms.PictureBox pBoxDr;
        private System.Windows.Forms.PictureBox pBoxLoginFoto;
        private RoundButton DrBtnGiris;
        private System.Windows.Forms.Panel AnaPanel;
        private System.Windows.Forms.PictureBox pBoxSifreGoster;
        private System.Windows.Forms.Button BtnAltEkran;
        private System.Windows.Forms.Button BtnKapat;
    }
}