using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Data.Odbc;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using PresentationLayer.UserControlsEkleme;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.AccessDb;
using EntityLayer.Concrete;
using System.Net;
using BusinessLayer.Validations;

namespace PresentationLayer.UserControls
{
    public partial class userDrRandevuKayitlari : UserControl
    {
        public userDrRandevuKayitlari()
        {
            InitializeComponent();
        }
        SekreterManager sekreterManager = new SekreterManager(new SekreterRepository());

        private void userDrRandevuKayitlari_Load(object sender, EventArgs e)
        {
            TextboxRandevuGorusmesiHastaEmail.Visible = false;
            LabelRandevuGorusmesiHastaEmail.Visible = false;

            //doktorları combobox a getiriyoruz.
            comboBoxDoktorlar = sekreterManager.DoktorlariGetir(comboBoxDoktorlar);
            int doktor_id = (int)comboBoxDoktorlar.SelectedValue;

        }
        private void BtnDrRandevuKaydet_Click(object sender, EventArgs e)
        {
            Randevu randevu = new Randevu
            {
                Doktor_id = (int)comboBoxDoktorlar.SelectedValue,
                Hasta_tcNo = DrTxtBoxHastaTc.Text,
                Randevu_tarihi = txtBoxRandevuTarih.Text,
                Randevu_saati = txtBoxRandevuSaat.Text,
                Randevu_notu = DrTxtBoxRandevuNotu.Text

            };

            //Bir hata olur da mail gönderilemezse diye try-catch e alıyoruz.
            try
            {
                //Comboboxtan evet e tıklandıysa mail gönderecek
                if (DrRadioBtnMailGonder.Checked)
                {
                    MailGonder();

                }

            }
            catch
            {

                MessageBox.Show("Mail gönderilemedi lütfen tekrar deneyiniz");
            }


            sekreterManager.RandevuNotuEkle(randevu);
            MessageBox.Show("Randevu notu eklendi");


        }
        public string TurkceKarakter(string text)
        {
            text = text.Replace("İ", "u\0130");
            text = text.Replace("ı", "u\0131");
            text = text.Replace("Ş", "u\015e");
            text = text.Replace("Ğ", "u\011e");
            text = text.Replace("Ö", "u\00d6");
            text = text.Replace("Ç", "u\02c7");
            text = text.Replace("Ü", "u\00dc");
            return text;
        }

        private void BtnDrPdfOlustur_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF DOSYALARI(*.pdf) | *.pdf";
            saveFileDialog.Title = "PDF DOSYASI OLUŞTURMA";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream dosya = File.Open(saveFileDialog.FileName, FileMode.Create);
                Document pdf = new Document();
                PdfWriter.GetInstance(pdf, dosya);
                pdf.Open();

                pdf.AddAuthor(comboBoxDoktorlar.Text);
                pdf.AddCreationDate();

                pdf.AddTitle("Adil");

                Paragraph gorusmeNotu = new Paragraph(DrTxtBoxRandevuNotu.Text);
                pdf.Add(gorusmeNotu);
                pdf.Close();

                MessageBox.Show("PDF OLUŞTURULDU");


            }
        }

        private void MailGonder()
        {
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.office365.com";
            sc.EnableSsl = true;



            string kime = TextboxRandevuGorusmesiHastaEmail.Text;
            bool hastaEmailGecerliMi = Validator.HastaEmailGecerliMi(kime);

            string konu = "Randevu Görüşmesi Kayıtları";
            string icerik = DrTxtBoxRandevuNotu.Text;
            if (hastaEmailGecerliMi)
            {


                sc.Credentials = new NetworkCredential("hastaRandevuOtomasyon@hotmail.com", "H123456H");
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("hastaRandevuOtomasyon@hotmail.com", "Hastane Otomasyonu");
                mail.To.Add(kime);
                mail.Subject = konu;
                mail.IsBodyHtml = true;
                mail.Body = icerik;
                sc.Send(mail);
                MessageBox.Show("Mail gönderildi");
            }
        }

        private void DrRadioBtnMailGonder_CheckedChanged(object sender, EventArgs e)
        {
            if (DrRadioBtnMailGonder.Checked)
            {
                TextboxRandevuGorusmesiHastaEmail.Visible = true;
                LabelRandevuGorusmesiHastaEmail.Visible = true;
            }
            if (!(DrRadioBtnMailGonder.Checked))
            {
                TextboxRandevuGorusmesiHastaEmail.Visible = false;
                LabelRandevuGorusmesiHastaEmail.Visible = false;
            }
        }

    }
}

