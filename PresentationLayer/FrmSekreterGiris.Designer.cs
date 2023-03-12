namespace PresentationLayer
{
    partial class FrmSekreterGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterGiris));
            this.panelSolSekrtr = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSekrtrBaslik = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtBoxSekrtrGirisEmail = new System.Windows.Forms.TextBox();
            this.lblSekrtrGirisEmail = new System.Windows.Forms.Label();
            this.txtBoxSekrtrGirisSifre = new System.Windows.Forms.TextBox();
            this.lblSekrtrGirisSifre = new System.Windows.Forms.Label();
            this.AnaPanel = new System.Windows.Forms.Panel();
            this.pBoxSifreGoster = new System.Windows.Forms.PictureBox();
            this.BtnAltEkran = new System.Windows.Forms.Button();
            this.BtnKapat = new System.Windows.Forms.Button();
            this.pBoxLoginFoto = new System.Windows.Forms.PictureBox();
            this.BtnSekrtrGiris = new PresentationLayer.RoundButton();
            this.SekrtrBtnGeri = new PresentationLayer.RoundButton();
            this.panelSolSekrtr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.AnaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSifreGoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLoginFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSolSekrtr
            // 
            this.panelSolSekrtr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(33)))), ((int)(((byte)(9)))));
            this.panelSolSekrtr.Controls.Add(this.pictureBox1);
            this.panelSolSekrtr.Controls.Add(this.lblSekrtrBaslik);
            this.panelSolSekrtr.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSolSekrtr.Location = new System.Drawing.Point(0, 0);
            this.panelSolSekrtr.Name = "panelSolSekrtr";
            this.panelSolSekrtr.Size = new System.Drawing.Size(332, 810);
            this.panelSolSekrtr.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresentationLayer.Properties.Resources.secretary__1_2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // lblSekrtrBaslik
            // 
            this.lblSekrtrBaslik.AutoSize = true;
            this.lblSekrtrBaslik.Font = new System.Drawing.Font("Goudy Stout", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSekrtrBaslik.ForeColor = System.Drawing.Color.White;
            this.lblSekrtrBaslik.Location = new System.Drawing.Point(34, 393);
            this.lblSekrtrBaslik.Name = "lblSekrtrBaslik";
            this.lblSekrtrBaslik.Size = new System.Drawing.Size(323, 117);
            this.lblSekrtrBaslik.TabIndex = 2;
            this.lblSekrtrBaslik.Text = "SEKRETER \r\n      GİRİŞ \r\n  SAYFASI";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "login.png");
            this.ımageList1.Images.SetKeyName(1, "back.png");
            // 
            // txtBoxSekrtrGirisEmail
            // 
            this.txtBoxSekrtrGirisEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBoxSekrtrGirisEmail.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSekrtrGirisEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxSekrtrGirisEmail.Location = new System.Drawing.Point(528, 385);
            this.txtBoxSekrtrGirisEmail.Name = "txtBoxSekrtrGirisEmail";
            this.txtBoxSekrtrGirisEmail.Size = new System.Drawing.Size(589, 39);
            this.txtBoxSekrtrGirisEmail.TabIndex = 23;
            // 
            // lblSekrtrGirisEmail
            // 
            this.lblSekrtrGirisEmail.AutoSize = true;
            this.lblSekrtrGirisEmail.Font = new System.Drawing.Font("Lucida Handwriting", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSekrtrGirisEmail.ForeColor = System.Drawing.Color.White;
            this.lblSekrtrGirisEmail.Location = new System.Drawing.Point(351, 385);
            this.lblSekrtrGirisEmail.Name = "lblSekrtrGirisEmail";
            this.lblSekrtrGirisEmail.Size = new System.Drawing.Size(180, 48);
            this.lblSekrtrGirisEmail.TabIndex = 22;
            this.lblSekrtrGirisEmail.Text = "E-mail:";
            // 
            // txtBoxSekrtrGirisSifre
            // 
            this.txtBoxSekrtrGirisSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBoxSekrtrGirisSifre.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSekrtrGirisSifre.Location = new System.Drawing.Point(528, 462);
            this.txtBoxSekrtrGirisSifre.Name = "txtBoxSekrtrGirisSifre";
            this.txtBoxSekrtrGirisSifre.Size = new System.Drawing.Size(589, 39);
            this.txtBoxSekrtrGirisSifre.TabIndex = 25;
            this.txtBoxSekrtrGirisSifre.UseSystemPasswordChar = true;
            // 
            // lblSekrtrGirisSifre
            // 
            this.lblSekrtrGirisSifre.AutoSize = true;
            this.lblSekrtrGirisSifre.Font = new System.Drawing.Font("Lucida Handwriting", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSekrtrGirisSifre.ForeColor = System.Drawing.Color.White;
            this.lblSekrtrGirisSifre.Location = new System.Drawing.Point(396, 462);
            this.lblSekrtrGirisSifre.Name = "lblSekrtrGirisSifre";
            this.lblSekrtrGirisSifre.Size = new System.Drawing.Size(135, 48);
            this.lblSekrtrGirisSifre.TabIndex = 24;
            this.lblSekrtrGirisSifre.Text = "Şifre:";
            // 
            // AnaPanel
            // 
            this.AnaPanel.Controls.Add(this.pBoxSifreGoster);
            this.AnaPanel.Controls.Add(this.lblSekrtrGirisEmail);
            this.AnaPanel.Controls.Add(this.txtBoxSekrtrGirisEmail);
            this.AnaPanel.Controls.Add(this.lblSekrtrGirisSifre);
            this.AnaPanel.Controls.Add(this.txtBoxSekrtrGirisSifre);
            this.AnaPanel.Controls.Add(this.BtnAltEkran);
            this.AnaPanel.Controls.Add(this.BtnKapat);
            this.AnaPanel.Controls.Add(this.pBoxLoginFoto);
            this.AnaPanel.Controls.Add(this.BtnSekrtrGiris);
            this.AnaPanel.Controls.Add(this.SekrtrBtnGeri);
            this.AnaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnaPanel.Location = new System.Drawing.Point(0, 0);
            this.AnaPanel.Name = "AnaPanel";
            this.AnaPanel.Size = new System.Drawing.Size(1187, 810);
            this.AnaPanel.TabIndex = 26;
            this.AnaPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnaPanel_MouseDown);
            this.AnaPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AnaPanel_MouseMove);
            this.AnaPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AnaPanel_MouseUp);
            // 
            // pBoxSifreGoster
            // 
            this.pBoxSifreGoster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBoxSifreGoster.Image = global::PresentationLayer.Properties.Resources.padlock__2_;
            this.pBoxSifreGoster.Location = new System.Drawing.Point(1117, 456);
            this.pBoxSifreGoster.Name = "pBoxSifreGoster";
            this.pBoxSifreGoster.Size = new System.Drawing.Size(39, 39);
            this.pBoxSifreGoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxSifreGoster.TabIndex = 29;
            this.pBoxSifreGoster.TabStop = false;
            this.pBoxSifreGoster.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBoxSifreGoster_MouseDown);
            this.pBoxSifreGoster.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pBoxSifreGoster_MouseUp);
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
            this.BtnAltEkran.TabIndex = 28;
            this.BtnAltEkran.UseVisualStyleBackColor = true;
            this.BtnAltEkran.Click += new System.EventHandler(this.BtnAltEkran_Click);
            // 
            // BtnKapat
            // 
            this.BtnKapat.BackgroundImage = global::PresentationLayer.Properties.Resources.letter_x;
            this.BtnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnKapat.FlatAppearance.BorderSize = 0;
            this.BtnKapat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnKapat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKapat.Location = new System.Drawing.Point(1154, 0);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(33, 31);
            this.BtnKapat.TabIndex = 27;
            this.BtnKapat.UseVisualStyleBackColor = true;
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // pBoxLoginFoto
            // 
            this.pBoxLoginFoto.Image = global::PresentationLayer.Properties.Resources.multiple_user;
            this.pBoxLoginFoto.Location = new System.Drawing.Point(588, 30);
            this.pBoxLoginFoto.Name = "pBoxLoginFoto";
            this.pBoxLoginFoto.Size = new System.Drawing.Size(327, 292);
            this.pBoxLoginFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxLoginFoto.TabIndex = 17;
            this.pBoxLoginFoto.TabStop = false;
            // 
            // BtnSekrtrGiris
            // 
            this.BtnSekrtrGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnSekrtrGiris.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnSekrtrGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSekrtrGiris.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnSekrtrGiris.BorderRadius = 40;
            this.BtnSekrtrGiris.BorderSize = 0;
            this.BtnSekrtrGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSekrtrGiris.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnSekrtrGiris.FlatAppearance.BorderSize = 0;
            this.BtnSekrtrGiris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnSekrtrGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSekrtrGiris.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSekrtrGiris.ForeColor = System.Drawing.Color.White;
            this.BtnSekrtrGiris.ImageKey = "login.png";
            this.BtnSekrtrGiris.ImageList = this.ımageList1;
            this.BtnSekrtrGiris.Location = new System.Drawing.Point(453, 588);
            this.BtnSekrtrGiris.Name = "BtnSekrtrGiris";
            this.BtnSekrtrGiris.Size = new System.Drawing.Size(254, 61);
            this.BtnSekrtrGiris.TabIndex = 16;
            this.BtnSekrtrGiris.Text = " G İ R İ Ş";
            this.BtnSekrtrGiris.TextColor = System.Drawing.Color.White;
            this.BtnSekrtrGiris.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSekrtrGiris.UseVisualStyleBackColor = false;
            this.BtnSekrtrGiris.Click += new System.EventHandler(this.BtnSekrtrGiris_Click);
            // 
            // SekrtrBtnGeri
            // 
            this.SekrtrBtnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.SekrtrBtnGeri.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.SekrtrBtnGeri.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(33)))), ((int)(((byte)(9)))));
            this.SekrtrBtnGeri.BorderRadius = 40;
            this.SekrtrBtnGeri.BorderSize = 0;
            this.SekrtrBtnGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SekrtrBtnGeri.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.SekrtrBtnGeri.FlatAppearance.BorderSize = 0;
            this.SekrtrBtnGeri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.SekrtrBtnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SekrtrBtnGeri.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold);
            this.SekrtrBtnGeri.ForeColor = System.Drawing.Color.White;
            this.SekrtrBtnGeri.ImageKey = "back.png";
            this.SekrtrBtnGeri.ImageList = this.ımageList1;
            this.SekrtrBtnGeri.Location = new System.Drawing.Point(803, 588);
            this.SekrtrBtnGeri.Name = "SekrtrBtnGeri";
            this.SekrtrBtnGeri.Size = new System.Drawing.Size(254, 61);
            this.SekrtrBtnGeri.TabIndex = 10;
            this.SekrtrBtnGeri.Text = " G E R İ";
            this.SekrtrBtnGeri.TextColor = System.Drawing.Color.White;
            this.SekrtrBtnGeri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SekrtrBtnGeri.UseVisualStyleBackColor = false;
            this.SekrtrBtnGeri.Click += new System.EventHandler(this.SekrtrBtnGeri_Click);
            // 
            // FrmSekreterGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(90)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1187, 810);
            this.Controls.Add(this.panelSolSekrtr);
            this.Controls.Add(this.AnaPanel);
            this.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSekreterGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSekreterGiris_FormClosing);
            this.panelSolSekrtr.ResumeLayout(false);
            this.panelSolSekrtr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.AnaPanel.ResumeLayout(false);
            this.AnaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSifreGoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLoginFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSolSekrtr;
        private RoundButton BtnSekrtrGiris;
        private RoundButton SekrtrBtnGeri;
        private System.Windows.Forms.Label lblSekrtrBaslik;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pBoxLoginFoto;
        private System.Windows.Forms.TextBox txtBoxSekrtrGirisEmail;
        private System.Windows.Forms.Label lblSekrtrGirisEmail;
        private System.Windows.Forms.TextBox txtBoxSekrtrGirisSifre;
        private System.Windows.Forms.Label lblSekrtrGirisSifre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel AnaPanel;
        private System.Windows.Forms.Button BtnAltEkran;
        private System.Windows.Forms.Button BtnKapat;
        private System.Windows.Forms.PictureBox pBoxSifreGoster;
    }
}