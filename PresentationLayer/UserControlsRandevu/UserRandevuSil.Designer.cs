namespace PresentationLayer.UserControlsRandevu
{
    partial class UserRandevuSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRandevuSil));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblUserHastaBaslik = new System.Windows.Forms.Label();
            this.ListViewRandevular = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Brans_adi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBoxRandevuSilHastaTc = new System.Windows.Forms.TextBox();
            this.lblSekrtrRandevuSilHastaTc = new System.Windows.Forms.Label();
            this.BtnUserRandevuGetir = new PresentationLayer.RoundButton();
            this.BtnUserRandevuSil = new PresentationLayer.RoundButton();
            this.pBoxUserHastaLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUserHastaLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "calendar.png");
            this.ımageList1.Images.SetKeyName(1, "deep-learning.png");
            this.ımageList1.Images.SetKeyName(2, "trash.png");
            this.ımageList1.Images.SetKeyName(3, "post-it.png");
            this.ımageList1.Images.SetKeyName(4, "trash-can.png");
            // 
            // lblUserHastaBaslik
            // 
            this.lblUserHastaBaslik.AutoSize = true;
            this.lblUserHastaBaslik.Font = new System.Drawing.Font("Lucida Handwriting", 22.2F, System.Drawing.FontStyle.Bold);
            this.lblUserHastaBaslik.ForeColor = System.Drawing.Color.White;
            this.lblUserHastaBaslik.Location = new System.Drawing.Point(224, 25);
            this.lblUserHastaBaslik.Name = "lblUserHastaBaslik";
            this.lblUserHastaBaslik.Size = new System.Drawing.Size(529, 96);
            this.lblUserHastaBaslik.TabIndex = 10;
            this.lblUserHastaBaslik.Text = "R A N D E V U   K A Y D I\r\n            S İ L M E \r\n";
            // 
            // ListViewRandevular
            // 
            this.ListViewRandevular.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.Brans_adi});
            this.ListViewRandevular.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold);
            this.ListViewRandevular.FullRowSelect = true;
            this.ListViewRandevular.GridLines = true;
            this.ListViewRandevular.HideSelection = false;
            this.ListViewRandevular.Location = new System.Drawing.Point(22, 249);
            this.ListViewRandevular.Name = "ListViewRandevular";
            this.ListViewRandevular.Size = new System.Drawing.Size(816, 382);
            this.ListViewRandevular.TabIndex = 40;
            this.ListViewRandevular.UseCompatibleStateImageBehavior = false;
            this.ListViewRandevular.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Randevu ID";
            this.columnHeader1.Width = 127;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hasta TC No";
            this.columnHeader2.Width = 119;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Doktor ID";
            this.columnHeader3.Width = 113;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Randevu Tarihi";
            this.columnHeader4.Width = 170;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Randevu Saati";
            this.columnHeader5.Width = 165;
            // 
            // Brans_adi
            // 
            this.Brans_adi.Text = "Brans Adı";
            this.Brans_adi.Width = 113;
            // 
            // txtBoxRandevuSilHastaTc
            // 
            this.txtBoxRandevuSilHastaTc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBoxRandevuSilHastaTc.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtBoxRandevuSilHastaTc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxRandevuSilHastaTc.Location = new System.Drawing.Point(278, 182);
            this.txtBoxRandevuSilHastaTc.Name = "txtBoxRandevuSilHastaTc";
            this.txtBoxRandevuSilHastaTc.Size = new System.Drawing.Size(515, 31);
            this.txtBoxRandevuSilHastaTc.TabIndex = 38;
            // 
            // lblSekrtrRandevuSilHastaTc
            // 
            this.lblSekrtrRandevuSilHastaTc.AutoSize = true;
            this.lblSekrtrRandevuSilHastaTc.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblSekrtrRandevuSilHastaTc.ForeColor = System.Drawing.Color.White;
            this.lblSekrtrRandevuSilHastaTc.Location = new System.Drawing.Point(62, 184);
            this.lblSekrtrRandevuSilHastaTc.Name = "lblSekrtrRandevuSilHastaTc";
            this.lblSekrtrRandevuSilHastaTc.Size = new System.Drawing.Size(190, 29);
            this.lblSekrtrRandevuSilHastaTc.TabIndex = 37;
            this.lblSekrtrRandevuSilHastaTc.Text = "Hasta TC No:";
            // 
            // BtnUserRandevuGetir
            // 
            this.BtnUserRandevuGetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnUserRandevuGetir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnUserRandevuGetir.BorderColor = System.Drawing.Color.Empty;
            this.BtnUserRandevuGetir.BorderRadius = 40;
            this.BtnUserRandevuGetir.BorderSize = 0;
            this.BtnUserRandevuGetir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUserRandevuGetir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnUserRandevuGetir.FlatAppearance.BorderSize = 0;
            this.BtnUserRandevuGetir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnUserRandevuGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUserRandevuGetir.ForeColor = System.Drawing.Color.White;
            this.BtnUserRandevuGetir.ImageKey = "post-it.png";
            this.BtnUserRandevuGetir.ImageList = this.ımageList1;
            this.BtnUserRandevuGetir.Location = new System.Drawing.Point(456, 653);
            this.BtnUserRandevuGetir.Name = "BtnUserRandevuGetir";
            this.BtnUserRandevuGetir.Size = new System.Drawing.Size(249, 52);
            this.BtnUserRandevuGetir.TabIndex = 39;
            this.BtnUserRandevuGetir.Text = "   R A N D E V U  G E T İ R";
            this.BtnUserRandevuGetir.TextColor = System.Drawing.Color.White;
            this.BtnUserRandevuGetir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUserRandevuGetir.UseVisualStyleBackColor = false;
            this.BtnUserRandevuGetir.Click += new System.EventHandler(this.BtnUserRandevuGetir_Click);
            // 
            // BtnUserRandevuSil
            // 
            this.BtnUserRandevuSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnUserRandevuSil.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnUserRandevuSil.BorderColor = System.Drawing.Color.Empty;
            this.BtnUserRandevuSil.BorderRadius = 40;
            this.BtnUserRandevuSil.BorderSize = 0;
            this.BtnUserRandevuSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUserRandevuSil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnUserRandevuSil.FlatAppearance.BorderSize = 0;
            this.BtnUserRandevuSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnUserRandevuSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUserRandevuSil.ForeColor = System.Drawing.Color.White;
            this.BtnUserRandevuSil.ImageKey = "trash.png";
            this.BtnUserRandevuSil.ImageList = this.ımageList1;
            this.BtnUserRandevuSil.Location = new System.Drawing.Point(146, 653);
            this.BtnUserRandevuSil.Name = "BtnUserRandevuSil";
            this.BtnUserRandevuSil.Size = new System.Drawing.Size(249, 52);
            this.BtnUserRandevuSil.TabIndex = 36;
            this.BtnUserRandevuSil.Text = "  R A N D E V U  S İ L";
            this.BtnUserRandevuSil.TextColor = System.Drawing.Color.White;
            this.BtnUserRandevuSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUserRandevuSil.UseVisualStyleBackColor = false;
            this.BtnUserRandevuSil.Click += new System.EventHandler(this.BtnUserRandevuSil_Click);
            // 
            // pBoxUserHastaLogo
            // 
            this.pBoxUserHastaLogo.Image = global::PresentationLayer.Properties.Resources.deep_learning;
            this.pBoxUserHastaLogo.Location = new System.Drawing.Point(55, 16);
            this.pBoxUserHastaLogo.Name = "pBoxUserHastaLogo";
            this.pBoxUserHastaLogo.Size = new System.Drawing.Size(144, 111);
            this.pBoxUserHastaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxUserHastaLogo.TabIndex = 11;
            this.pBoxUserHastaLogo.TabStop = false;
            // 
            // UserRandevuSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(90)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.ListViewRandevular);
            this.Controls.Add(this.BtnUserRandevuGetir);
            this.Controls.Add(this.txtBoxRandevuSilHastaTc);
            this.Controls.Add(this.lblSekrtrRandevuSilHastaTc);
            this.Controls.Add(this.BtnUserRandevuSil);
            this.Controls.Add(this.pBoxUserHastaLogo);
            this.Controls.Add(this.lblUserHastaBaslik);
            this.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F);
            this.Name = "UserRandevuSil";
            this.Size = new System.Drawing.Size(855, 731);
            this.Tag = "R A N D E V U  K A Y D I  S İ L M E";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUserHastaLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pBoxUserHastaLogo;
        private System.Windows.Forms.Label lblUserHastaBaslik;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ListView ListViewRandevular;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader Brans_adi;
        private RoundButton BtnUserRandevuGetir;
        private System.Windows.Forms.TextBox txtBoxRandevuSilHastaTc;
        private System.Windows.Forms.Label lblSekrtrRandevuSilHastaTc;
        private RoundButton BtnUserRandevuSil;
    }
}
