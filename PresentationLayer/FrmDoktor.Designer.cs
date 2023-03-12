namespace PresentationLayer
{
    partial class FrmDoktor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktor));
            this.panelDrSolMenu = new System.Windows.Forms.Panel();
            this.BtnDrEskiKayit = new PresentationLayer.RoundButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnDrGorusmeKayit = new PresentationLayer.RoundButton();
            this.BtnDrGeri = new PresentationLayer.RoundButton();
            this.BtnDrCıkısYap = new PresentationLayer.RoundButton();
            this.panelDrFoto = new System.Windows.Forms.Panel();
            this.pBoxDrFoto = new System.Windows.Forms.PictureBox();
            this.panelDrTitleBar = new System.Windows.Forms.Panel();
            this.BtnAltEkran = new System.Windows.Forms.Button();
            this.lblDrAnaSayfa = new System.Windows.Forms.Label();
            this.BtnKapat = new System.Windows.Forms.Button();
            this.pBoxDrHome = new System.Windows.Forms.PictureBox();
            this.AnaPanelDr = new System.Windows.Forms.Panel();
            this.panelDrSolMenu.SuspendLayout();
            this.panelDrFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDrFoto)).BeginInit();
            this.panelDrTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDrHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDrSolMenu
            // 
            this.panelDrSolMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(33)))), ((int)(((byte)(9)))));
            this.panelDrSolMenu.Controls.Add(this.BtnDrEskiKayit);
            this.panelDrSolMenu.Controls.Add(this.BtnDrGorusmeKayit);
            this.panelDrSolMenu.Controls.Add(this.BtnDrGeri);
            this.panelDrSolMenu.Controls.Add(this.BtnDrCıkısYap);
            this.panelDrSolMenu.Controls.Add(this.panelDrFoto);
            this.panelDrSolMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDrSolMenu.ForeColor = System.Drawing.Color.White;
            this.panelDrSolMenu.Location = new System.Drawing.Point(0, 0);
            this.panelDrSolMenu.Name = "panelDrSolMenu";
            this.panelDrSolMenu.Size = new System.Drawing.Size(332, 810);
            this.panelDrSolMenu.TabIndex = 0;
            // 
            // BtnDrEskiKayit
            // 
            this.BtnDrEskiKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnDrEskiKayit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnDrEskiKayit.BorderColor = System.Drawing.Color.Empty;
            this.BtnDrEskiKayit.BorderRadius = 0;
            this.BtnDrEskiKayit.BorderSize = 0;
            this.BtnDrEskiKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDrEskiKayit.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDrEskiKayit.FlatAppearance.BorderSize = 0;
            this.BtnDrEskiKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDrEskiKayit.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDrEskiKayit.ForeColor = System.Drawing.Color.White;
            this.BtnDrEskiKayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDrEskiKayit.ImageKey = "notes.png";
            this.BtnDrEskiKayit.ImageList = this.ımageList1;
            this.BtnDrEskiKayit.Location = new System.Drawing.Point(0, 283);
            this.BtnDrEskiKayit.Name = "BtnDrEskiKayit";
            this.BtnDrEskiKayit.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.BtnDrEskiKayit.Size = new System.Drawing.Size(332, 72);
            this.BtnDrEskiKayit.TabIndex = 17;
            this.BtnDrEskiKayit.Text = "  ESKİ KAYITLAR";
            this.BtnDrEskiKayit.TextColor = System.Drawing.Color.White;
            this.BtnDrEskiKayit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDrEskiKayit.UseVisualStyleBackColor = false;
            this.BtnDrEskiKayit.Click += new System.EventHandler(this.BtnDrEskiKayit_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "notes.png");
            this.ımageList1.Images.SetKeyName(1, "document.png");
            this.ımageList1.Images.SetKeyName(2, "back.png");
            this.ımageList1.Images.SetKeyName(3, "cancel.png");
            // 
            // BtnDrGorusmeKayit
            // 
            this.BtnDrGorusmeKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnDrGorusmeKayit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnDrGorusmeKayit.BorderColor = System.Drawing.Color.Empty;
            this.BtnDrGorusmeKayit.BorderRadius = 0;
            this.BtnDrGorusmeKayit.BorderSize = 0;
            this.BtnDrGorusmeKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDrGorusmeKayit.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDrGorusmeKayit.FlatAppearance.BorderSize = 0;
            this.BtnDrGorusmeKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDrGorusmeKayit.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDrGorusmeKayit.ForeColor = System.Drawing.Color.White;
            this.BtnDrGorusmeKayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDrGorusmeKayit.ImageKey = "document.png";
            this.BtnDrGorusmeKayit.ImageList = this.ımageList1;
            this.BtnDrGorusmeKayit.Location = new System.Drawing.Point(0, 211);
            this.BtnDrGorusmeKayit.Name = "BtnDrGorusmeKayit";
            this.BtnDrGorusmeKayit.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.BtnDrGorusmeKayit.Size = new System.Drawing.Size(332, 72);
            this.BtnDrGorusmeKayit.TabIndex = 16;
            this.BtnDrGorusmeKayit.Text = "  HASTA GÖRÜŞMESİ KAYDET";
            this.BtnDrGorusmeKayit.TextColor = System.Drawing.Color.White;
            this.BtnDrGorusmeKayit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDrGorusmeKayit.UseVisualStyleBackColor = false;
            this.BtnDrGorusmeKayit.Click += new System.EventHandler(this.BtnDrGorusmeKayit_Click);
            // 
            // BtnDrGeri
            // 
            this.BtnDrGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnDrGeri.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnDrGeri.BorderColor = System.Drawing.Color.Empty;
            this.BtnDrGeri.BorderRadius = 0;
            this.BtnDrGeri.BorderSize = 0;
            this.BtnDrGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDrGeri.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnDrGeri.FlatAppearance.BorderSize = 0;
            this.BtnDrGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDrGeri.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDrGeri.ForeColor = System.Drawing.Color.White;
            this.BtnDrGeri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDrGeri.ImageKey = "back.png";
            this.BtnDrGeri.ImageList = this.ımageList1;
            this.BtnDrGeri.Location = new System.Drawing.Point(0, 666);
            this.BtnDrGeri.Name = "BtnDrGeri";
            this.BtnDrGeri.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.BtnDrGeri.Size = new System.Drawing.Size(332, 72);
            this.BtnDrGeri.TabIndex = 15;
            this.BtnDrGeri.Text = "  ANA SAYFAYA GERİ DÖN";
            this.BtnDrGeri.TextColor = System.Drawing.Color.White;
            this.BtnDrGeri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDrGeri.UseVisualStyleBackColor = false;
            this.BtnDrGeri.Click += new System.EventHandler(this.BtnDrGeri_Click);
            // 
            // BtnDrCıkısYap
            // 
            this.BtnDrCıkısYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnDrCıkısYap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnDrCıkısYap.BorderColor = System.Drawing.Color.Green;
            this.BtnDrCıkısYap.BorderRadius = 0;
            this.BtnDrCıkısYap.BorderSize = 0;
            this.BtnDrCıkısYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDrCıkısYap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnDrCıkısYap.FlatAppearance.BorderSize = 0;
            this.BtnDrCıkısYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDrCıkısYap.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDrCıkısYap.ForeColor = System.Drawing.Color.White;
            this.BtnDrCıkısYap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDrCıkısYap.ImageKey = "cancel.png";
            this.BtnDrCıkısYap.ImageList = this.ımageList1;
            this.BtnDrCıkısYap.Location = new System.Drawing.Point(0, 738);
            this.BtnDrCıkısYap.Name = "BtnDrCıkısYap";
            this.BtnDrCıkısYap.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.BtnDrCıkısYap.Size = new System.Drawing.Size(332, 72);
            this.BtnDrCıkısYap.TabIndex = 14;
            this.BtnDrCıkısYap.Text = "  ÇIKIŞ YAP";
            this.BtnDrCıkısYap.TextColor = System.Drawing.Color.White;
            this.BtnDrCıkısYap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDrCıkısYap.UseVisualStyleBackColor = false;
            this.BtnDrCıkısYap.Click += new System.EventHandler(this.BtnDrCıkısYap_Click);
            // 
            // panelDrFoto
            // 
            this.panelDrFoto.Controls.Add(this.pBoxDrFoto);
            this.panelDrFoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDrFoto.Location = new System.Drawing.Point(0, 0);
            this.panelDrFoto.Name = "panelDrFoto";
            this.panelDrFoto.Size = new System.Drawing.Size(332, 211);
            this.panelDrFoto.TabIndex = 0;
            // 
            // pBoxDrFoto
            // 
            this.pBoxDrFoto.Image = global::PresentationLayer.Properties.Resources._1doctor;
            this.pBoxDrFoto.Location = new System.Drawing.Point(36, 12);
            this.pBoxDrFoto.Name = "pBoxDrFoto";
            this.pBoxDrFoto.Size = new System.Drawing.Size(250, 184);
            this.pBoxDrFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxDrFoto.TabIndex = 1;
            this.pBoxDrFoto.TabStop = false;
            // 
            // panelDrTitleBar
            // 
            this.panelDrTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(33)))), ((int)(((byte)(9)))));
            this.panelDrTitleBar.Controls.Add(this.BtnAltEkran);
            this.panelDrTitleBar.Controls.Add(this.lblDrAnaSayfa);
            this.panelDrTitleBar.Controls.Add(this.BtnKapat);
            this.panelDrTitleBar.Controls.Add(this.pBoxDrHome);
            this.panelDrTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDrTitleBar.ForeColor = System.Drawing.Color.White;
            this.panelDrTitleBar.Location = new System.Drawing.Point(332, 0);
            this.panelDrTitleBar.Name = "panelDrTitleBar";
            this.panelDrTitleBar.Size = new System.Drawing.Size(855, 79);
            this.panelDrTitleBar.TabIndex = 8;
            this.panelDrTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDrTitleBar_MouseDown);
            this.panelDrTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDrTitleBar_MouseMove);
            this.panelDrTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelDrTitleBar_MouseUp);
            // 
            // BtnAltEkran
            // 
            this.BtnAltEkran.BackgroundImage = global::PresentationLayer.Properties.Resources.minus;
            this.BtnAltEkran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAltEkran.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAltEkran.FlatAppearance.BorderSize = 0;
            this.BtnAltEkran.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(33)))), ((int)(((byte)(9)))));
            this.BtnAltEkran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAltEkran.ImageKey = "(none)";
            this.BtnAltEkran.Location = new System.Drawing.Point(781, 3);
            this.BtnAltEkran.Name = "BtnAltEkran";
            this.BtnAltEkran.Size = new System.Drawing.Size(33, 31);
            this.BtnAltEkran.TabIndex = 30;
            this.BtnAltEkran.UseVisualStyleBackColor = true;
            this.BtnAltEkran.Click += new System.EventHandler(this.BtnAltEkran_Click);
            // 
            // lblDrAnaSayfa
            // 
            this.lblDrAnaSayfa.AutoSize = true;
            this.lblDrAnaSayfa.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrAnaSayfa.ForeColor = System.Drawing.Color.White;
            this.lblDrAnaSayfa.Location = new System.Drawing.Point(107, 28);
            this.lblDrAnaSayfa.Name = "lblDrAnaSayfa";
            this.lblDrAnaSayfa.Size = new System.Drawing.Size(224, 29);
            this.lblDrAnaSayfa.TabIndex = 3;
            this.lblDrAnaSayfa.Text = "A N A  S A Y F A";
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
            this.BtnKapat.Location = new System.Drawing.Point(820, 3);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(33, 31);
            this.BtnKapat.TabIndex = 29;
            this.BtnKapat.UseVisualStyleBackColor = true;
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // pBoxDrHome
            // 
            this.pBoxDrHome.Image = global::PresentationLayer.Properties.Resources.home1;
            this.pBoxDrHome.Location = new System.Drawing.Point(22, 11);
            this.pBoxDrHome.Name = "pBoxDrHome";
            this.pBoxDrHome.Size = new System.Drawing.Size(79, 57);
            this.pBoxDrHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxDrHome.TabIndex = 2;
            this.pBoxDrHome.TabStop = false;
            // 
            // AnaPanelDr
            // 
            this.AnaPanelDr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(90)))), ((int)(((byte)(68)))));
            this.AnaPanelDr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnaPanelDr.Location = new System.Drawing.Point(332, 79);
            this.AnaPanelDr.Name = "AnaPanelDr";
            this.AnaPanelDr.Size = new System.Drawing.Size(855, 731);
            this.AnaPanelDr.TabIndex = 9;
            // 
            // FrmDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(90)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1187, 810);
            this.Controls.Add(this.AnaPanelDr);
            this.Controls.Add(this.panelDrTitleBar);
            this.Controls.Add(this.panelDrSolMenu);
            this.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDoktor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmDoktor_Load);
            this.panelDrSolMenu.ResumeLayout(false);
            this.panelDrFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDrFoto)).EndInit();
            this.panelDrTitleBar.ResumeLayout(false);
            this.panelDrTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDrHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDrSolMenu;
        private System.Windows.Forms.PictureBox pBoxDrFoto;
        private System.Windows.Forms.Panel panelDrFoto;
        private RoundButton BtnDrGeri;
        private System.Windows.Forms.ImageList ımageList1;
        private RoundButton BtnDrCıkısYap;
        private RoundButton BtnDrGorusmeKayit;
        private RoundButton BtnDrEskiKayit;
        private System.Windows.Forms.Panel panelDrTitleBar;
        private System.Windows.Forms.Label lblDrAnaSayfa;
        private System.Windows.Forms.PictureBox pBoxDrHome;
        private System.Windows.Forms.Panel AnaPanelDr;
        private System.Windows.Forms.Button BtnAltEkran;
        private System.Windows.Forms.Button BtnKapat;
    }
}