namespace PresentationLayer.UserControlsRandevu
{
    partial class UserRandevuAl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRandevuAl));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblUserHastaBaslik = new System.Windows.Forms.Label();
            this.txtRandevuTarihi = new System.Windows.Forms.TextBox();
            this.listViewDoktorlar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSekrtrRandevuEkleRndvSaati = new System.Windows.Forms.Label();
            this.ComboBoxRandevuEkleHastaSecBol = new System.Windows.Forms.ComboBox();
            this.txtBoxRandevuEkleRndvSaat = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxRandevuEkleHastaTc = new System.Windows.Forms.TextBox();
            this.lblSekrtrRandevuEkleHastaTc = new System.Windows.Forms.Label();
            this.lblSekrtrRandevuEkleRndvGunu = new System.Windows.Forms.Label();
            this.lblSekrtrRandevuEkleSecBolum = new System.Windows.Forms.Label();
            this.BtnUserRndvDrGetir = new PresentationLayer.RoundButton();
            this.BtnUserRandevuEkle = new PresentationLayer.RoundButton();
            this.pBoxUserHastaLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUserHastaLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "calendar.png");
            this.ımageList1.Images.SetKeyName(1, "1profile.png");
            this.ımageList1.Images.SetKeyName(2, "1calendar.png");
            // 
            // lblUserHastaBaslik
            // 
            this.lblUserHastaBaslik.AutoSize = true;
            this.lblUserHastaBaslik.Font = new System.Drawing.Font("Lucida Handwriting", 22.2F, System.Drawing.FontStyle.Bold);
            this.lblUserHastaBaslik.ForeColor = System.Drawing.Color.White;
            this.lblUserHastaBaslik.Location = new System.Drawing.Point(224, 25);
            this.lblUserHastaBaslik.Name = "lblUserHastaBaslik";
            this.lblUserHastaBaslik.Size = new System.Drawing.Size(568, 96);
            this.lblUserHastaBaslik.TabIndex = 13;
            this.lblUserHastaBaslik.Text = "R A N D E V U   K A Y D I   \r\n         E K L E M E \r\n";
            // 
            // txtRandevuTarihi
            // 
            this.txtRandevuTarihi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRandevuTarihi.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtRandevuTarihi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRandevuTarihi.Location = new System.Drawing.Point(311, 272);
            this.txtRandevuTarihi.Name = "txtRandevuTarihi";
            this.txtRandevuTarihi.Size = new System.Drawing.Size(515, 31);
            this.txtRandevuTarihi.TabIndex = 45;
            this.txtRandevuTarihi.Text = "GG/AA/YYYY";
            // 
            // listViewDoktorlar
            // 
            this.listViewDoktorlar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewDoktorlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewDoktorlar.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDoktorlar.FullRowSelect = true;
            this.listViewDoktorlar.GridLines = true;
            this.listViewDoktorlar.HideSelection = false;
            this.listViewDoktorlar.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewDoktorlar.Location = new System.Drawing.Point(39, 381);
            this.listViewDoktorlar.MultiSelect = false;
            this.listViewDoktorlar.Name = "listViewDoktorlar";
            this.listViewDoktorlar.Size = new System.Drawing.Size(787, 257);
            this.listViewDoktorlar.SmallImageList = this.ımageList1;
            this.listViewDoktorlar.TabIndex = 43;
            this.listViewDoktorlar.UseCompatibleStateImageBehavior = false;
            this.listViewDoktorlar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Doktor ID";
            this.columnHeader1.Width = 126;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Doktor Adı";
            this.columnHeader2.Width = 142;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Doktor Soyadı";
            this.columnHeader3.Width = 179;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Doktor Branşı";
            this.columnHeader4.Width = 210;
            // 
            // lblSekrtrRandevuEkleRndvSaati
            // 
            this.lblSekrtrRandevuEkleRndvSaati.AutoSize = true;
            this.lblSekrtrRandevuEkleRndvSaati.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSekrtrRandevuEkleRndvSaati.ForeColor = System.Drawing.Color.White;
            this.lblSekrtrRandevuEkleRndvSaati.Location = new System.Drawing.Point(60, 329);
            this.lblSekrtrRandevuEkleRndvSaati.Name = "lblSekrtrRandevuEkleRndvSaati";
            this.lblSekrtrRandevuEkleRndvSaati.Size = new System.Drawing.Size(229, 29);
            this.lblSekrtrRandevuEkleRndvSaati.TabIndex = 42;
            this.lblSekrtrRandevuEkleRndvSaati.Text = "Randevu Saati:";
            // 
            // ComboBoxRandevuEkleHastaSecBol
            // 
            this.ComboBoxRandevuEkleHastaSecBol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ComboBoxRandevuEkleHastaSecBol.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold);
            this.ComboBoxRandevuEkleHastaSecBol.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ComboBoxRandevuEkleHastaSecBol.FormattingEnabled = true;
            this.ComboBoxRandevuEkleHastaSecBol.Location = new System.Drawing.Point(311, 215);
            this.ComboBoxRandevuEkleHastaSecBol.Name = "ComboBoxRandevuEkleHastaSecBol";
            this.ComboBoxRandevuEkleHastaSecBol.Size = new System.Drawing.Size(515, 31);
            this.ComboBoxRandevuEkleHastaSecBol.TabIndex = 37;
            // 
            // txtBoxRandevuEkleRndvSaat
            // 
            this.txtBoxRandevuEkleRndvSaat.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtBoxRandevuEkleRndvSaat.Location = new System.Drawing.Point(311, 329);
            this.txtBoxRandevuEkleRndvSaat.Mask = "00:00";
            this.txtBoxRandevuEkleRndvSaat.Name = "txtBoxRandevuEkleRndvSaat";
            this.txtBoxRandevuEkleRndvSaat.Size = new System.Drawing.Size(515, 31);
            this.txtBoxRandevuEkleRndvSaat.TabIndex = 41;
            this.txtBoxRandevuEkleRndvSaat.ValidatingType = typeof(System.DateTime);
            // 
            // txtBoxRandevuEkleHastaTc
            // 
            this.txtBoxRandevuEkleHastaTc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBoxRandevuEkleHastaTc.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtBoxRandevuEkleHastaTc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxRandevuEkleHastaTc.Location = new System.Drawing.Point(311, 158);
            this.txtBoxRandevuEkleHastaTc.Name = "txtBoxRandevuEkleHastaTc";
            this.txtBoxRandevuEkleHastaTc.Size = new System.Drawing.Size(515, 31);
            this.txtBoxRandevuEkleHastaTc.TabIndex = 40;
            // 
            // lblSekrtrRandevuEkleHastaTc
            // 
            this.lblSekrtrRandevuEkleHastaTc.AutoSize = true;
            this.lblSekrtrRandevuEkleHastaTc.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblSekrtrRandevuEkleHastaTc.ForeColor = System.Drawing.Color.White;
            this.lblSekrtrRandevuEkleHastaTc.Location = new System.Drawing.Point(60, 158);
            this.lblSekrtrRandevuEkleHastaTc.Name = "lblSekrtrRandevuEkleHastaTc";
            this.lblSekrtrRandevuEkleHastaTc.Size = new System.Drawing.Size(187, 29);
            this.lblSekrtrRandevuEkleHastaTc.TabIndex = 39;
            this.lblSekrtrRandevuEkleHastaTc.Text = "Hasta Tc No:";
            // 
            // lblSekrtrRandevuEkleRndvGunu
            // 
            this.lblSekrtrRandevuEkleRndvGunu.AutoSize = true;
            this.lblSekrtrRandevuEkleRndvGunu.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSekrtrRandevuEkleRndvGunu.ForeColor = System.Drawing.Color.White;
            this.lblSekrtrRandevuEkleRndvGunu.Location = new System.Drawing.Point(60, 272);
            this.lblSekrtrRandevuEkleRndvGunu.Name = "lblSekrtrRandevuEkleRndvGunu";
            this.lblSekrtrRandevuEkleRndvGunu.Size = new System.Drawing.Size(231, 29);
            this.lblSekrtrRandevuEkleRndvGunu.TabIndex = 38;
            this.lblSekrtrRandevuEkleRndvGunu.Text = "Randevu Günü:";
            // 
            // lblSekrtrRandevuEkleSecBolum
            // 
            this.lblSekrtrRandevuEkleSecBolum.AutoSize = true;
            this.lblSekrtrRandevuEkleSecBolum.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSekrtrRandevuEkleSecBolum.ForeColor = System.Drawing.Color.White;
            this.lblSekrtrRandevuEkleSecBolum.Location = new System.Drawing.Point(60, 215);
            this.lblSekrtrRandevuEkleSecBolum.Name = "lblSekrtrRandevuEkleSecBolum";
            this.lblSekrtrRandevuEkleSecBolum.Size = new System.Drawing.Size(217, 29);
            this.lblSekrtrRandevuEkleSecBolum.TabIndex = 36;
            this.lblSekrtrRandevuEkleSecBolum.Text = "Seçilen Bölüm:";
            // 
            // BtnUserRndvDrGetir
            // 
            this.BtnUserRndvDrGetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnUserRndvDrGetir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnUserRndvDrGetir.BorderColor = System.Drawing.Color.Empty;
            this.BtnUserRndvDrGetir.BorderRadius = 40;
            this.BtnUserRndvDrGetir.BorderSize = 0;
            this.BtnUserRndvDrGetir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUserRndvDrGetir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnUserRndvDrGetir.FlatAppearance.BorderSize = 0;
            this.BtnUserRndvDrGetir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnUserRndvDrGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUserRndvDrGetir.ForeColor = System.Drawing.Color.White;
            this.BtnUserRndvDrGetir.ImageKey = "1profile.png";
            this.BtnUserRndvDrGetir.ImageList = this.ımageList1;
            this.BtnUserRndvDrGetir.Location = new System.Drawing.Point(456, 653);
            this.BtnUserRndvDrGetir.Name = "BtnUserRndvDrGetir";
            this.BtnUserRndvDrGetir.Size = new System.Drawing.Size(273, 55);
            this.BtnUserRndvDrGetir.TabIndex = 44;
            this.BtnUserRndvDrGetir.Text = " D O K T O R L A R I  G E T İ R";
            this.BtnUserRndvDrGetir.TextColor = System.Drawing.Color.White;
            this.BtnUserRndvDrGetir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUserRndvDrGetir.UseVisualStyleBackColor = false;
            this.BtnUserRndvDrGetir.Click += new System.EventHandler(this.BtnUserRndvDrGetir_Click);
            // 
            // BtnUserRandevuEkle
            // 
            this.BtnUserRandevuEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnUserRandevuEkle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnUserRandevuEkle.BorderColor = System.Drawing.Color.Empty;
            this.BtnUserRandevuEkle.BorderRadius = 40;
            this.BtnUserRandevuEkle.BorderSize = 0;
            this.BtnUserRandevuEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUserRandevuEkle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnUserRandevuEkle.FlatAppearance.BorderSize = 0;
            this.BtnUserRandevuEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnUserRandevuEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUserRandevuEkle.ForeColor = System.Drawing.Color.White;
            this.BtnUserRandevuEkle.ImageKey = "1calendar.png";
            this.BtnUserRandevuEkle.ImageList = this.ımageList1;
            this.BtnUserRandevuEkle.Location = new System.Drawing.Point(119, 654);
            this.BtnUserRandevuEkle.Name = "BtnUserRandevuEkle";
            this.BtnUserRandevuEkle.Size = new System.Drawing.Size(252, 55);
            this.BtnUserRandevuEkle.TabIndex = 35;
            this.BtnUserRandevuEkle.Text = "  R A N D E V U  E K L E";
            this.BtnUserRandevuEkle.TextColor = System.Drawing.Color.White;
            this.BtnUserRandevuEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUserRandevuEkle.UseVisualStyleBackColor = false;
            this.BtnUserRandevuEkle.Click += new System.EventHandler(this.BtnUserRandevuEkle_Click);
            // 
            // pBoxUserHastaLogo
            // 
            this.pBoxUserHastaLogo.Image = global::PresentationLayer.Properties.Resources._2calendar;
            this.pBoxUserHastaLogo.Location = new System.Drawing.Point(55, 16);
            this.pBoxUserHastaLogo.Name = "pBoxUserHastaLogo";
            this.pBoxUserHastaLogo.Size = new System.Drawing.Size(144, 111);
            this.pBoxUserHastaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxUserHastaLogo.TabIndex = 14;
            this.pBoxUserHastaLogo.TabStop = false;
            // 
            // UserRandevuAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(90)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.txtRandevuTarihi);
            this.Controls.Add(this.BtnUserRndvDrGetir);
            this.Controls.Add(this.listViewDoktorlar);
            this.Controls.Add(this.lblSekrtrRandevuEkleRndvSaati);
            this.Controls.Add(this.ComboBoxRandevuEkleHastaSecBol);
            this.Controls.Add(this.txtBoxRandevuEkleRndvSaat);
            this.Controls.Add(this.txtBoxRandevuEkleHastaTc);
            this.Controls.Add(this.lblSekrtrRandevuEkleHastaTc);
            this.Controls.Add(this.lblSekrtrRandevuEkleRndvGunu);
            this.Controls.Add(this.lblSekrtrRandevuEkleSecBolum);
            this.Controls.Add(this.BtnUserRandevuEkle);
            this.Controls.Add(this.pBoxUserHastaLogo);
            this.Controls.Add(this.lblUserHastaBaslik);
            this.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F);
            this.Name = "UserRandevuAl";
            this.Size = new System.Drawing.Size(855, 731);
            this.Tag = "R A N D E V U  K A Y D I  E K L E M E";
            this.Load += new System.EventHandler(this.UserRandevuAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUserHastaLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pBoxUserHastaLogo;
        private System.Windows.Forms.Label lblUserHastaBaslik;
        private System.Windows.Forms.TextBox txtRandevuTarihi;
        private RoundButton BtnUserRndvDrGetir;
        private System.Windows.Forms.ListView listViewDoktorlar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblSekrtrRandevuEkleRndvSaati;
        private System.Windows.Forms.ComboBox ComboBoxRandevuEkleHastaSecBol;
        private System.Windows.Forms.MaskedTextBox txtBoxRandevuEkleRndvSaat;
        private System.Windows.Forms.TextBox txtBoxRandevuEkleHastaTc;
        private System.Windows.Forms.Label lblSekrtrRandevuEkleHastaTc;
        private System.Windows.Forms.Label lblSekrtrRandevuEkleRndvGunu;
        private System.Windows.Forms.Label lblSekrtrRandevuEkleSecBolum;
        private RoundButton BtnUserRandevuEkle;
    }
}
