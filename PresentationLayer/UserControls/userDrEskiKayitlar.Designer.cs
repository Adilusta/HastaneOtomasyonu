namespace PresentationLayer.UserControls
{
    partial class userDrEskiKayitlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userDrEskiKayitlar));
            this.lblEskiKayitTarih = new System.Windows.Forms.Label();
            this.lblEskiKayitRandevuNot = new System.Windows.Forms.Label();
            this.lblEskiKayitHastaTc = new System.Windows.Forms.Label();
            this.lblEskiKayitBaslik = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.DrTxtBoxEskiRandevuNotu = new System.Windows.Forms.TextBox();
            this.CBoxEskiKayitDoktor = new System.Windows.Forms.ComboBox();
            this.lblEskiKayitDoktor = new System.Windows.Forms.Label();
            this.textBoxEskiKayıtHastaTc = new System.Windows.Forms.TextBox();
            this.textBoxEskiKayitTarih = new System.Windows.Forms.TextBox();
            this.lblEskiKayitSaat = new System.Windows.Forms.Label();
            this.pBoxEskiKayitLogo = new System.Windows.Forms.PictureBox();
            this.textBoxEskiKayitSaat = new System.Windows.Forms.MaskedTextBox();
            this.BtnDrKayitGetir = new PresentationLayer.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxEskiKayitLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEskiKayitTarih
            // 
            this.lblEskiKayitTarih.AutoSize = true;
            this.lblEskiKayitTarih.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblEskiKayitTarih.ForeColor = System.Drawing.Color.White;
            this.lblEskiKayitTarih.Location = new System.Drawing.Point(113, 277);
            this.lblEskiKayitTarih.Name = "lblEskiKayitTarih";
            this.lblEskiKayitTarih.Size = new System.Drawing.Size(99, 29);
            this.lblEskiKayitTarih.TabIndex = 19;
            this.lblEskiKayitTarih.Text = "Tarih:";
            // 
            // lblEskiKayitRandevuNot
            // 
            this.lblEskiKayitRandevuNot.AutoSize = true;
            this.lblEskiKayitRandevuNot.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblEskiKayitRandevuNot.ForeColor = System.Drawing.Color.White;
            this.lblEskiKayitRandevuNot.Location = new System.Drawing.Point(62, 381);
            this.lblEskiKayitRandevuNot.Name = "lblEskiKayitRandevuNot";
            this.lblEskiKayitRandevuNot.Size = new System.Drawing.Size(255, 29);
            this.lblEskiKayitRandevuNot.TabIndex = 15;
            this.lblEskiKayitRandevuNot.Text = "Randevu Notları:";
            // 
            // lblEskiKayitHastaTc
            // 
            this.lblEskiKayitHastaTc.AutoSize = true;
            this.lblEskiKayitHastaTc.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblEskiKayitHastaTc.ForeColor = System.Drawing.Color.White;
            this.lblEskiKayitHastaTc.Location = new System.Drawing.Point(70, 226);
            this.lblEskiKayitHastaTc.Name = "lblEskiKayitHastaTc";
            this.lblEskiKayitHastaTc.Size = new System.Drawing.Size(145, 29);
            this.lblEskiKayitHastaTc.TabIndex = 13;
            this.lblEskiKayitHastaTc.Text = "Hasta TC:";
            // 
            // lblEskiKayitBaslik
            // 
            this.lblEskiKayitBaslik.AutoSize = true;
            this.lblEskiKayitBaslik.Font = new System.Drawing.Font("Lucida Handwriting", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEskiKayitBaslik.ForeColor = System.Drawing.Color.White;
            this.lblEskiKayitBaslik.Location = new System.Drawing.Point(201, 34);
            this.lblEskiKayitBaslik.Name = "lblEskiKayitBaslik";
            this.lblEskiKayitBaslik.Size = new System.Drawing.Size(467, 96);
            this.lblEskiKayitBaslik.TabIndex = 10;
            this.lblEskiKayitBaslik.Text = "E S K İ  R A N D E V U \r\n    K A Y I T L A R I";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "1medical-record.png");
            // 
            // DrTxtBoxEskiRandevuNotu
            // 
            this.DrTxtBoxEskiRandevuNotu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DrTxtBoxEskiRandevuNotu.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold);
            this.DrTxtBoxEskiRandevuNotu.Location = new System.Drawing.Point(67, 413);
            this.DrTxtBoxEskiRandevuNotu.Multiline = true;
            this.DrTxtBoxEskiRandevuNotu.Name = "DrTxtBoxEskiRandevuNotu";
            this.DrTxtBoxEskiRandevuNotu.Size = new System.Drawing.Size(688, 249);
            this.DrTxtBoxEskiRandevuNotu.TabIndex = 22;
            // 
            // CBoxEskiKayitDoktor
            // 
            this.CBoxEskiKayitDoktor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CBoxEskiKayitDoktor.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold);
            this.CBoxEskiKayitDoktor.FormattingEnabled = true;
            this.CBoxEskiKayitDoktor.Location = new System.Drawing.Point(228, 177);
            this.CBoxEskiKayitDoktor.Name = "CBoxEskiKayitDoktor";
            this.CBoxEskiKayitDoktor.Size = new System.Drawing.Size(527, 31);
            this.CBoxEskiKayitDoktor.TabIndex = 23;
            // 
            // lblEskiKayitDoktor
            // 
            this.lblEskiKayitDoktor.AutoSize = true;
            this.lblEskiKayitDoktor.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblEskiKayitDoktor.ForeColor = System.Drawing.Color.White;
            this.lblEskiKayitDoktor.Location = new System.Drawing.Point(98, 175);
            this.lblEskiKayitDoktor.Name = "lblEskiKayitDoktor";
            this.lblEskiKayitDoktor.Size = new System.Drawing.Size(115, 29);
            this.lblEskiKayitDoktor.TabIndex = 24;
            this.lblEskiKayitDoktor.Text = "Doktor:";
            // 
            // textBoxEskiKayıtHastaTc
            // 
            this.textBoxEskiKayıtHastaTc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxEskiKayıtHastaTc.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold);
            this.textBoxEskiKayıtHastaTc.Location = new System.Drawing.Point(228, 226);
            this.textBoxEskiKayıtHastaTc.Name = "textBoxEskiKayıtHastaTc";
            this.textBoxEskiKayıtHastaTc.Size = new System.Drawing.Size(527, 31);
            this.textBoxEskiKayıtHastaTc.TabIndex = 25;
            // 
            // textBoxEskiKayitTarih
            // 
            this.textBoxEskiKayitTarih.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxEskiKayitTarih.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold);
            this.textBoxEskiKayitTarih.Location = new System.Drawing.Point(228, 275);
            this.textBoxEskiKayitTarih.Name = "textBoxEskiKayitTarih";
            this.textBoxEskiKayitTarih.Size = new System.Drawing.Size(527, 31);
            this.textBoxEskiKayitTarih.TabIndex = 26;
            this.textBoxEskiKayitTarih.Text = "GG/AA/YYYY";
            // 
            // lblEskiKayitSaat
            // 
            this.lblEskiKayitSaat.AutoSize = true;
            this.lblEskiKayitSaat.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblEskiKayitSaat.ForeColor = System.Drawing.Color.White;
            this.lblEskiKayitSaat.Location = new System.Drawing.Point(126, 326);
            this.lblEskiKayitSaat.Name = "lblEskiKayitSaat";
            this.lblEskiKayitSaat.Size = new System.Drawing.Size(85, 29);
            this.lblEskiKayitSaat.TabIndex = 27;
            this.lblEskiKayitSaat.Text = "Saat:";
            // 
            // pBoxEskiKayitLogo
            // 
            this.pBoxEskiKayitLogo.Image = global::PresentationLayer.Properties.Resources.notes;
            this.pBoxEskiKayitLogo.Location = new System.Drawing.Point(51, 19);
            this.pBoxEskiKayitLogo.Name = "pBoxEskiKayitLogo";
            this.pBoxEskiKayitLogo.Size = new System.Drawing.Size(144, 111);
            this.pBoxEskiKayitLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxEskiKayitLogo.TabIndex = 11;
            this.pBoxEskiKayitLogo.TabStop = false;
            // 
            // textBoxEskiKayitSaat
            // 
            this.textBoxEskiKayitSaat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxEskiKayitSaat.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold);
            this.textBoxEskiKayitSaat.Location = new System.Drawing.Point(228, 324);
            this.textBoxEskiKayitSaat.Mask = "00:00";
            this.textBoxEskiKayitSaat.Name = "textBoxEskiKayitSaat";
            this.textBoxEskiKayitSaat.Size = new System.Drawing.Size(527, 31);
            this.textBoxEskiKayitSaat.TabIndex = 39;
            this.textBoxEskiKayitSaat.ValidatingType = typeof(System.DateTime);
            // 
            // BtnDrKayitGetir
            // 
            this.BtnDrKayitGetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnDrKayitGetir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnDrKayitGetir.BorderColor = System.Drawing.Color.Empty;
            this.BtnDrKayitGetir.BorderRadius = 40;
            this.BtnDrKayitGetir.BorderSize = 0;
            this.BtnDrKayitGetir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDrKayitGetir.FlatAppearance.BorderSize = 0;
            this.BtnDrKayitGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDrKayitGetir.ForeColor = System.Drawing.Color.White;
            this.BtnDrKayitGetir.ImageKey = "1medical-record.png";
            this.BtnDrKayitGetir.ImageList = this.ımageList1;
            this.BtnDrKayitGetir.Location = new System.Drawing.Point(268, 671);
            this.BtnDrKayitGetir.Name = "BtnDrKayitGetir";
            this.BtnDrKayitGetir.Size = new System.Drawing.Size(260, 50);
            this.BtnDrKayitGetir.TabIndex = 21;
            this.BtnDrKayitGetir.Text = " K A Y I T L A R I  G E T İ R";
            this.BtnDrKayitGetir.TextColor = System.Drawing.Color.White;
            this.BtnDrKayitGetir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDrKayitGetir.UseVisualStyleBackColor = false;
            this.BtnDrKayitGetir.Click += new System.EventHandler(this.BtnDrKayitGetir_Click);
            // 
            // userDrEskiKayitlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(90)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.textBoxEskiKayitSaat);
            this.Controls.Add(this.lblEskiKayitSaat);
            this.Controls.Add(this.textBoxEskiKayitTarih);
            this.Controls.Add(this.textBoxEskiKayıtHastaTc);
            this.Controls.Add(this.lblEskiKayitDoktor);
            this.Controls.Add(this.CBoxEskiKayitDoktor);
            this.Controls.Add(this.DrTxtBoxEskiRandevuNotu);
            this.Controls.Add(this.BtnDrKayitGetir);
            this.Controls.Add(this.lblEskiKayitTarih);
            this.Controls.Add(this.lblEskiKayitRandevuNot);
            this.Controls.Add(this.lblEskiKayitHastaTc);
            this.Controls.Add(this.pBoxEskiKayitLogo);
            this.Controls.Add(this.lblEskiKayitBaslik);
            this.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "userDrEskiKayitlar";
            this.Size = new System.Drawing.Size(855, 731);
            this.Tag = "E S K İ  R A N D E V U  K A Y I T L A R I ";
            this.Load += new System.EventHandler(this.userDrEskiKayitlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxEskiKayitLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEskiKayitTarih;
        private System.Windows.Forms.Label lblEskiKayitRandevuNot;
        private System.Windows.Forms.Label lblEskiKayitHastaTc;
        private System.Windows.Forms.PictureBox pBoxEskiKayitLogo;
        private System.Windows.Forms.Label lblEskiKayitBaslik;
        private RoundButton BtnDrKayitGetir;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TextBox DrTxtBoxEskiRandevuNotu;
        private System.Windows.Forms.ComboBox CBoxEskiKayitDoktor;
        private System.Windows.Forms.Label lblEskiKayitDoktor;
        private System.Windows.Forms.TextBox textBoxEskiKayıtHastaTc;
        private System.Windows.Forms.TextBox textBoxEskiKayitTarih;
        private System.Windows.Forms.Label lblEskiKayitSaat;
        private System.Windows.Forms.MaskedTextBox textBoxEskiKayitSaat;
    }
}
