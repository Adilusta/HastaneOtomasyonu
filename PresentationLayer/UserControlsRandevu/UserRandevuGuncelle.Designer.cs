namespace PresentationLayer.UserControlsRandevu
{
    partial class UserRandevuGuncelle
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRandevuGuncelle));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblUserHastaBaslik = new System.Windows.Forms.Label();
            this.listViewRandevuGuncelleRandevular = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBoxRndvGuncelleRandvGunu = new System.Windows.Forms.TextBox();
            this.lblSekrtrRndvGuncelleRndvSaati = new System.Windows.Forms.Label();
            this.txtBoxRndvGuncelleRndvSaat = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxRndvGuncelleHastaTc = new System.Windows.Forms.TextBox();
            this.lblSekrtrRndvGuncelleHastaTc = new System.Windows.Forms.Label();
            this.lblSekrtrRndvGuncelleRndvGunu = new System.Windows.Forms.Label();
            this.BtnUserRandevuKaydiGetir = new PresentationLayer.RoundButton();
            this.BtnUserRandevuGuncelle = new PresentationLayer.RoundButton();
            this.pBoxUserHastaLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUserHastaLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "calendar.png");
            this.ımageList1.Images.SetKeyName(1, "calendar (1).png");
            this.ımageList1.Images.SetKeyName(2, "3calendar.png");
            this.ımageList1.Images.SetKeyName(3, "folder.png");
            // 
            // lblUserHastaBaslik
            // 
            this.lblUserHastaBaslik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserHastaBaslik.AutoSize = true;
            this.lblUserHastaBaslik.Font = new System.Drawing.Font("Lucida Handwriting", 22.2F, System.Drawing.FontStyle.Bold);
            this.lblUserHastaBaslik.ForeColor = System.Drawing.Color.White;
            this.lblUserHastaBaslik.Location = new System.Drawing.Point(224, 25);
            this.lblUserHastaBaslik.Name = "lblUserHastaBaslik";
            this.lblUserHastaBaslik.Size = new System.Drawing.Size(542, 96);
            this.lblUserHastaBaslik.TabIndex = 16;
            this.lblUserHastaBaslik.Text = "R A N D E V U   K A Y D I \r\n     G Ü N C E L L E M E";
            // 
            // listViewRandevuGuncelleRandevular
            // 
            this.listViewRandevuGuncelleRandevular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewRandevuGuncelleRandevular.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewRandevuGuncelleRandevular.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewRandevuGuncelleRandevular.FullRowSelect = true;
            this.listViewRandevuGuncelleRandevular.GridLines = true;
            this.listViewRandevuGuncelleRandevular.HideSelection = false;
            this.listViewRandevuGuncelleRandevular.Location = new System.Drawing.Point(38, 350);
            this.listViewRandevuGuncelleRandevular.MultiSelect = false;
            this.listViewRandevuGuncelleRandevular.Name = "listViewRandevuGuncelleRandevular";
            this.listViewRandevuGuncelleRandevular.Size = new System.Drawing.Size(782, 308);
            this.listViewRandevuGuncelleRandevular.TabIndex = 43;
            this.listViewRandevuGuncelleRandevular.UseCompatibleStateImageBehavior = false;
            this.listViewRandevuGuncelleRandevular.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Randevu ID";
            this.columnHeader1.Width = 126;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Doktor ID";
            this.columnHeader2.Width = 107;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hasta TC No";
            this.columnHeader3.Width = 128;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Randevu Saati";
            this.columnHeader4.Width = 156;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Randevu Tarihi";
            this.columnHeader5.Width = 164;
            // 
            // txtBoxRndvGuncelleRandvGunu
            // 
            this.txtBoxRndvGuncelleRandvGunu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxRndvGuncelleRandvGunu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBoxRndvGuncelleRandvGunu.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtBoxRndvGuncelleRandvGunu.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxRndvGuncelleRandvGunu.Location = new System.Drawing.Point(305, 233);
            this.txtBoxRndvGuncelleRandvGunu.Name = "txtBoxRndvGuncelleRandvGunu";
            this.txtBoxRndvGuncelleRandvGunu.Size = new System.Drawing.Size(515, 31);
            this.txtBoxRndvGuncelleRandvGunu.TabIndex = 42;
            this.txtBoxRndvGuncelleRandvGunu.Text = "GG/AA/YYYY";
            // 
            // lblSekrtrRndvGuncelleRndvSaati
            // 
            this.lblSekrtrRndvGuncelleRndvSaati.AutoSize = true;
            this.lblSekrtrRndvGuncelleRndvSaati.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSekrtrRndvGuncelleRndvSaati.ForeColor = System.Drawing.Color.White;
            this.lblSekrtrRndvGuncelleRndvSaati.Location = new System.Drawing.Point(44, 291);
            this.lblSekrtrRndvGuncelleRndvSaati.Name = "lblSekrtrRndvGuncelleRndvSaati";
            this.lblSekrtrRndvGuncelleRndvSaati.Size = new System.Drawing.Size(229, 29);
            this.lblSekrtrRndvGuncelleRndvSaati.TabIndex = 40;
            this.lblSekrtrRndvGuncelleRndvSaati.Text = "Randevu Saati:";
            // 
            // txtBoxRndvGuncelleRndvSaat
            // 
            this.txtBoxRndvGuncelleRndvSaat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxRndvGuncelleRndvSaat.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtBoxRndvGuncelleRndvSaat.Location = new System.Drawing.Point(305, 291);
            this.txtBoxRndvGuncelleRndvSaat.Mask = "00:00";
            this.txtBoxRndvGuncelleRndvSaat.Name = "txtBoxRndvGuncelleRndvSaat";
            this.txtBoxRndvGuncelleRndvSaat.Size = new System.Drawing.Size(515, 31);
            this.txtBoxRndvGuncelleRndvSaat.TabIndex = 39;
            this.txtBoxRndvGuncelleRndvSaat.ValidatingType = typeof(System.DateTime);
            // 
            // txtBoxRndvGuncelleHastaTc
            // 
            this.txtBoxRndvGuncelleHastaTc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxRndvGuncelleHastaTc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBoxRndvGuncelleHastaTc.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtBoxRndvGuncelleHastaTc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxRndvGuncelleHastaTc.Location = new System.Drawing.Point(305, 175);
            this.txtBoxRndvGuncelleHastaTc.Name = "txtBoxRndvGuncelleHastaTc";
            this.txtBoxRndvGuncelleHastaTc.Size = new System.Drawing.Size(515, 31);
            this.txtBoxRndvGuncelleHastaTc.TabIndex = 38;
            // 
            // lblSekrtrRndvGuncelleHastaTc
            // 
            this.lblSekrtrRndvGuncelleHastaTc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSekrtrRndvGuncelleHastaTc.AutoSize = true;
            this.lblSekrtrRndvGuncelleHastaTc.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblSekrtrRndvGuncelleHastaTc.ForeColor = System.Drawing.Color.White;
            this.lblSekrtrRndvGuncelleHastaTc.Location = new System.Drawing.Point(44, 175);
            this.lblSekrtrRndvGuncelleHastaTc.Name = "lblSekrtrRndvGuncelleHastaTc";
            this.lblSekrtrRndvGuncelleHastaTc.Size = new System.Drawing.Size(187, 29);
            this.lblSekrtrRndvGuncelleHastaTc.TabIndex = 37;
            this.lblSekrtrRndvGuncelleHastaTc.Text = "Hasta Tc No:";
            // 
            // lblSekrtrRndvGuncelleRndvGunu
            // 
            this.lblSekrtrRndvGuncelleRndvGunu.AutoSize = true;
            this.lblSekrtrRndvGuncelleRndvGunu.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSekrtrRndvGuncelleRndvGunu.ForeColor = System.Drawing.Color.White;
            this.lblSekrtrRndvGuncelleRndvGunu.Location = new System.Drawing.Point(44, 233);
            this.lblSekrtrRndvGuncelleRndvGunu.Name = "lblSekrtrRndvGuncelleRndvGunu";
            this.lblSekrtrRndvGuncelleRndvGunu.Size = new System.Drawing.Size(231, 29);
            this.lblSekrtrRndvGuncelleRndvGunu.TabIndex = 36;
            this.lblSekrtrRndvGuncelleRndvGunu.Text = "Randevu Günü:";
            // 
            // BtnUserRandevuKaydiGetir
            // 
            this.BtnUserRandevuKaydiGetir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUserRandevuKaydiGetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnUserRandevuKaydiGetir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnUserRandevuKaydiGetir.BorderColor = System.Drawing.Color.Empty;
            this.BtnUserRandevuKaydiGetir.BorderRadius = 40;
            this.BtnUserRandevuKaydiGetir.BorderSize = 0;
            this.BtnUserRandevuKaydiGetir.FlatAppearance.BorderSize = 0;
            this.BtnUserRandevuKaydiGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUserRandevuKaydiGetir.ForeColor = System.Drawing.Color.White;
            this.BtnUserRandevuKaydiGetir.ImageKey = "folder.png";
            this.BtnUserRandevuKaydiGetir.ImageList = this.ımageList1;
            this.BtnUserRandevuKaydiGetir.Location = new System.Drawing.Point(452, 664);
            this.BtnUserRandevuKaydiGetir.Name = "BtnUserRandevuKaydiGetir";
            this.BtnUserRandevuKaydiGetir.Size = new System.Drawing.Size(292, 52);
            this.BtnUserRandevuKaydiGetir.TabIndex = 41;
            this.BtnUserRandevuKaydiGetir.Text = "  K A Y I T  G E T İ R";
            this.BtnUserRandevuKaydiGetir.TextColor = System.Drawing.Color.White;
            this.BtnUserRandevuKaydiGetir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUserRandevuKaydiGetir.UseVisualStyleBackColor = false;
            this.BtnUserRandevuKaydiGetir.Click += new System.EventHandler(this.BtnUserRandevuKaydiGetir_Click);
            // 
            // BtnUserRandevuGuncelle
            // 
            this.BtnUserRandevuGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUserRandevuGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnUserRandevuGuncelle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnUserRandevuGuncelle.BorderColor = System.Drawing.Color.Empty;
            this.BtnUserRandevuGuncelle.BorderRadius = 40;
            this.BtnUserRandevuGuncelle.BorderSize = 0;
            this.BtnUserRandevuGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUserRandevuGuncelle.FlatAppearance.BorderSize = 0;
            this.BtnUserRandevuGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUserRandevuGuncelle.ForeColor = System.Drawing.Color.White;
            this.BtnUserRandevuGuncelle.ImageKey = "3calendar.png";
            this.BtnUserRandevuGuncelle.ImageList = this.ımageList1;
            this.BtnUserRandevuGuncelle.Location = new System.Drawing.Point(117, 664);
            this.BtnUserRandevuGuncelle.Name = "BtnUserRandevuGuncelle";
            this.BtnUserRandevuGuncelle.Size = new System.Drawing.Size(292, 52);
            this.BtnUserRandevuGuncelle.TabIndex = 35;
            this.BtnUserRandevuGuncelle.Text = " R A N D E V U  G Ü N C E L L E ";
            this.BtnUserRandevuGuncelle.TextColor = System.Drawing.Color.White;
            this.BtnUserRandevuGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUserRandevuGuncelle.UseVisualStyleBackColor = false;
            this.BtnUserRandevuGuncelle.Click += new System.EventHandler(this.BtnUserRandevuGuncelle_Click);
            // 
            // pBoxUserHastaLogo
            // 
            this.pBoxUserHastaLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pBoxUserHastaLogo.Image = global::PresentationLayer.Properties.Resources.calendar__1_1;
            this.pBoxUserHastaLogo.Location = new System.Drawing.Point(55, 16);
            this.pBoxUserHastaLogo.Name = "pBoxUserHastaLogo";
            this.pBoxUserHastaLogo.Size = new System.Drawing.Size(144, 111);
            this.pBoxUserHastaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxUserHastaLogo.TabIndex = 17;
            this.pBoxUserHastaLogo.TabStop = false;
            // 
            // UserRandevuGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(90)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.listViewRandevuGuncelleRandevular);
            this.Controls.Add(this.txtBoxRndvGuncelleRandvGunu);
            this.Controls.Add(this.BtnUserRandevuKaydiGetir);
            this.Controls.Add(this.lblSekrtrRndvGuncelleRndvSaati);
            this.Controls.Add(this.txtBoxRndvGuncelleRndvSaat);
            this.Controls.Add(this.txtBoxRndvGuncelleHastaTc);
            this.Controls.Add(this.lblSekrtrRndvGuncelleHastaTc);
            this.Controls.Add(this.lblSekrtrRndvGuncelleRndvGunu);
            this.Controls.Add(this.BtnUserRandevuGuncelle);
            this.Controls.Add(this.pBoxUserHastaLogo);
            this.Controls.Add(this.lblUserHastaBaslik);
            this.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F);
            this.Name = "UserRandevuGuncelle";
            this.Size = new System.Drawing.Size(855, 731);
            this.Tag = "R A N D E V U  K A Y D I  G Ü N C E L L E M E";
            this.Load += new System.EventHandler(this.UserRandevuGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUserHastaLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pBoxUserHastaLogo;
        private System.Windows.Forms.Label lblUserHastaBaslik;
        private System.Windows.Forms.ListView listViewRandevuGuncelleRandevular;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtBoxRndvGuncelleRandvGunu;
        private RoundButton BtnUserRandevuKaydiGetir;
        private System.Windows.Forms.Label lblSekrtrRndvGuncelleRndvSaati;
        private System.Windows.Forms.MaskedTextBox txtBoxRndvGuncelleRndvSaat;
        private System.Windows.Forms.TextBox txtBoxRndvGuncelleHastaTc;
        private System.Windows.Forms.Label lblSekrtrRndvGuncelleHastaTc;
        private System.Windows.Forms.Label lblSekrtrRndvGuncelleRndvGunu;
        private RoundButton BtnUserRandevuGuncelle;
    }
}
