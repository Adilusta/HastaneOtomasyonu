namespace PresentationLayer
{
    partial class FrmRolSecimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRolSecimi));
            this.lblAnaBaslik = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.AnaPanel = new System.Windows.Forms.Panel();
            this.BtnAltEkran = new System.Windows.Forms.Button();
            this.BtnKapat = new System.Windows.Forms.Button();
            this.pBoxDoktorlar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSekreter = new PresentationLayer.RoundButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnDoktor = new PresentationLayer.RoundButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.AnaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDoktorlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAnaBaslik
            // 
            this.lblAnaBaslik.AutoSize = true;
            this.lblAnaBaslik.Font = new System.Drawing.Font("Lucida Handwriting", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnaBaslik.ForeColor = System.Drawing.Color.White;
            this.lblAnaBaslik.Location = new System.Drawing.Point(503, 200);
            this.lblAnaBaslik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnaBaslik.Name = "lblAnaBaslik";
            this.lblAnaBaslik.Size = new System.Drawing.Size(656, 183);
            this.lblAnaBaslik.TabIndex = 4;
            this.lblAnaBaslik.Text = "HASTA RANDEVU KAYIT\r\n         SİSTEMİNE\r\n      HOŞ GELDİNİZ\r\n";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "doctor.png");
            this.ımageList1.Images.SetKeyName(1, "secretary.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(33)))), ((int)(((byte)(9)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Lucida Handwriting", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 810);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PresentationLayer.Properties.Resources.hospital3;
            this.pictureBox3.Location = new System.Drawing.Point(0, 216);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(332, 288);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // AnaPanel
            // 
            this.AnaPanel.Controls.Add(this.BtnAltEkran);
            this.AnaPanel.Controls.Add(this.BtnKapat);
            this.AnaPanel.Controls.Add(this.pBoxDoktorlar);
            this.AnaPanel.Controls.Add(this.lblAnaBaslik);
            this.AnaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnaPanel.Location = new System.Drawing.Point(0, 0);
            this.AnaPanel.Name = "AnaPanel";
            this.AnaPanel.Size = new System.Drawing.Size(1187, 810);
            this.AnaPanel.TabIndex = 8;
            this.AnaPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnaPanel_MouseDown);
            this.AnaPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AnaPanel_MouseMove);
            this.AnaPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AnaPanel_MouseUp);
            // 
            // BtnAltEkran
            // 
            this.BtnAltEkran.BackgroundImage = global::PresentationLayer.Properties.Resources.minus;
            this.BtnAltEkran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAltEkran.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAltEkran.FlatAppearance.BorderSize = 0;
            this.BtnAltEkran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAltEkran.ImageKey = "(none)";
            this.BtnAltEkran.Location = new System.Drawing.Point(1126, 0);
            this.BtnAltEkran.Name = "BtnAltEkran";
            this.BtnAltEkran.Size = new System.Drawing.Size(33, 31);
            this.BtnAltEkran.TabIndex = 11;
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
            this.BtnKapat.TabIndex = 10;
            this.BtnKapat.UseVisualStyleBackColor = true;
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // pBoxDoktorlar
            // 
            this.pBoxDoktorlar.BackColor = System.Drawing.Color.Transparent;
            this.pBoxDoktorlar.Image = global::PresentationLayer.Properties.Resources.heart_rate;
            this.pBoxDoktorlar.Location = new System.Drawing.Point(663, 0);
            this.pBoxDoktorlar.Name = "pBoxDoktorlar";
            this.pBoxDoktorlar.Size = new System.Drawing.Size(240, 199);
            this.pBoxDoktorlar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxDoktorlar.TabIndex = 3;
            this.pBoxDoktorlar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresentationLayer.Properties.Resources.medicine;
            this.pictureBox1.Location = new System.Drawing.Point(862, 537);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSekreter
            // 
            this.BtnSekreter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnSekreter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnSekreter.BorderColor = System.Drawing.Color.Empty;
            this.BtnSekreter.BorderRadius = 40;
            this.BtnSekreter.BorderSize = 0;
            this.BtnSekreter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSekreter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnSekreter.FlatAppearance.BorderSize = 0;
            this.BtnSekreter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSekreter.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold);
            this.BtnSekreter.ForeColor = System.Drawing.Color.White;
            this.BtnSekreter.ImageKey = "secretary.png";
            this.BtnSekreter.ImageList = this.ımageList1;
            this.BtnSekreter.Location = new System.Drawing.Point(839, 414);
            this.BtnSekreter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnSekreter.Name = "BtnSekreter";
            this.BtnSekreter.Size = new System.Drawing.Size(254, 61);
            this.BtnSekreter.TabIndex = 6;
            this.BtnSekreter.Text = " S E K R E T E R";
            this.BtnSekreter.TextColor = System.Drawing.Color.White;
            this.BtnSekreter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSekreter.UseVisualStyleBackColor = false;
            this.BtnSekreter.Click += new System.EventHandler(this.BtnSekreter_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PresentationLayer.Properties.Resources.medical_result;
            this.pictureBox2.Location = new System.Drawing.Point(412, 537);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(260, 246);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // BtnDoktor
            // 
            this.BtnDoktor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnDoktor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnDoktor.BorderColor = System.Drawing.Color.Empty;
            this.BtnDoktor.BorderRadius = 40;
            this.BtnDoktor.BorderSize = 0;
            this.BtnDoktor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDoktor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(53)))), ((int)(((byte)(24)))));
            this.BtnDoktor.FlatAppearance.BorderSize = 0;
            this.BtnDoktor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDoktor.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDoktor.ForeColor = System.Drawing.Color.White;
            this.BtnDoktor.ImageKey = "doctor.png";
            this.BtnDoktor.ImageList = this.ımageList1;
            this.BtnDoktor.Location = new System.Drawing.Point(494, 414);
            this.BtnDoktor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnDoktor.Name = "BtnDoktor";
            this.BtnDoktor.Size = new System.Drawing.Size(254, 61);
            this.BtnDoktor.TabIndex = 5;
            this.BtnDoktor.Text = " D O K T O R";
            this.BtnDoktor.TextColor = System.Drawing.Color.White;
            this.BtnDoktor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDoktor.UseVisualStyleBackColor = false;
            this.BtnDoktor.Click += new System.EventHandler(this.BtnDoktor_Click);
            // 
            // FrmRolSecimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(90)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1187, 810);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnSekreter);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnDoktor);
            this.Controls.Add(this.AnaPanel);
            this.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRolSecimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRolSecimi_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.AnaPanel.ResumeLayout(false);
            this.AnaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDoktorlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pBoxDoktorlar;
        private System.Windows.Forms.Label lblAnaBaslik;
        private RoundButton BtnDoktor;
        private System.Windows.Forms.ImageList ımageList1;
        private RoundButton BtnSekreter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel AnaPanel;
        private System.Windows.Forms.Button BtnAltEkran;
        private System.Windows.Forms.Button BtnKapat;
    }
}

