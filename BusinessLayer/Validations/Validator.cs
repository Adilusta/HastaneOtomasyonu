using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BusinessLayer.Validations
{
    public static class Validator
    {
        public static bool DoktorValidate(Doktor doktor)
        {

            //Tc nonun sadece rakamlardan oluşup oluşmadığını kontrol ediyoruz.
            foreach (char c in doktor.Doktor_tcNo)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Tc No sadece sayılardan oluşmalıdır");
                    return false;
                }
            }
            //Doktor adının sadece harflerden oluşup oluşmadığını kontrol ediyoruz.
            foreach (char c in doktor.Doktor_adi)
            {
                if (!char.IsLetter(c))
                {
                    MessageBox.Show("Doktor adının sadece harflerden oluşması gerekir");
                    return false;

                }
            }

            //Doktor soyadının sadece harflerden oluşup oluşmadığını kontrol ediyoruz.
            foreach (char c in doktor.Doktor_soyadi)
            {
                if (!char.IsLetter(c))
                {
                    MessageBox.Show("Doktor soyadının sadece harflerden oluşması gerekir");
                    return false;

                }
            }
            // tc no nun 11 haneden oluşup oluşmadığını kontrol ediyoruz
            if (!(doktor.Doktor_tcNo.Length == 11))
            {
                MessageBox.Show("Lütfen geçerli bir tc no giriniz.");
                return false;
            }
            /*doktor adınının 2 karaktere eşit ya da büyük ve 30 karakterden az olup olmadığını
            kontrol ediyoruz */
            if (!(doktor.Doktor_adi.Length >= 2 && doktor.Doktor_adi.Length < 30))
            {
                MessageBox.Show("Doktor adı çok kısa veya çok uzun lütfen geçerli bir ad giriniz");
                return false;
            }
            /*doktor soyadının 2 karaktere eşit ya da büyük ve 30 karakterden az olup olmadığını
           kontrol ediyoruz */
            if (!(doktor.Doktor_soyadi.Length >= 2 && doktor.Doktor_soyadi.Length < 30))
            {
                MessageBox.Show("Doktor soyadı çok kısa veya çok uzun lütfen geçerli bir soyad giriniz");

            }
            //Doktor yaşının 15 ten büyük 150 den küçük olup olmadığını kontrol ediyoruz.
            if (!(doktor.Doktor_yasi > 15 && doktor.Doktor_yasi < 150))
            {
                MessageBox.Show("Lütfen geçerli bir doktor yaşı giriniz(15-150 arası)");
                return false;
            }
            // Doktor emailinin geçerli olup olmadığını kontrol ediyoruz.
            if (!(doktor.Doktor_email.Contains("@") && doktor.Doktor_email.Contains(".")))
            {
                MessageBox.Show("Lütfen geçerli bir e mail giriniz.");
                return false;
            }

            return true;
        }

        public static bool HastaValidate(Hasta hasta)
        {
            //Hasta adının sadece harflerden oluşup oluşmadığını kontrol ediyoruz.
            foreach (char c in hasta.Hasta_adi)
            {
                if (!char.IsLetter(c))
                {
                    MessageBox.Show("Hasta adının sadece harflerden oluşması gerekir");
                    return false;

                }
            }

            //Hasta soyadının sadece harflerden oluşup oluşmadığını kontrol ediyoruz.
            foreach (char c in hasta.Hasta_soyadi)
            {
                if (!char.IsLetter(c))
                {
                    MessageBox.Show("Hasta soyadının sadece harflerden oluşması gerekir");
                    return false;

                }
            }

            foreach (char c in hasta.Hasta_tcno)
            {
                if (!char.IsDigit(c))
                {

                    return false;

                }
            }

            if (!(hasta.Hasta_tcno.Length == 11))
            {
                MessageBox.Show("Lütfen geçerli bir tc no giriniz.");
                return false;
            }

            if (!(hasta.Hasta_adi.Length >= 2 && hasta.Hasta_adi.Length < 30))
            {
                MessageBox.Show("Hasta adı çok kısa veya çok uzun lütfen geçerli bir ad giriniz");
                return false;
            }
            if (!(hasta.Hasta_soyadi.Length >= 2 && hasta.Hasta_soyadi.Length < 30))
            {
                MessageBox.Show("Hasta soyadı çok kısa veya çok uzun lütfen geçerli bir soyad giriniz");
                return false;
            }

            if (!(hasta.Hasta_yasi > 1 && hasta.Hasta_yasi < 150))
            {
                MessageBox.Show("Lütfen geçerli bir hasta yaşı giriniz");
                return false;
            }

            if (!(hasta.Hasta_email.Contains("@") && hasta.Hasta_email.Contains(".")))
            {
                MessageBox.Show("Lütfen geçerli bir e mail giriniz.");
                return false;
            }

            return true;

        }

        public static bool SekreterValidate(Sekreter sekreter)
        {
            //Sekreter adının sadece harflerden oluşup oluşmadığını kontrol ediyoruz.
            foreach (char c in sekreter.Sekreter_adi)
            {
                if (!char.IsLetter(c))
                {
                    MessageBox.Show("Sekreter adının sadece harflerden oluşması gerekir");
                    return false;

                }
            }

            //Sekreter soyadının sadece harflerden oluşup oluşmadığını kontrol ediyoruz.
            foreach (char c in sekreter.Sekreter_soyadi)
            {
                if (!char.IsLetter(c))
                {
                    MessageBox.Show("Sekreter soyadının sadece harflerden oluşması gerekir");
                    return false;

                }
            }


            foreach (char c in sekreter.Sekreter_tcno)
            {
                if (!char.IsDigit(c))
                {

                    return false;
                }
            }

            if (!(sekreter.Sekreter_tcno.Length == 11))
            {
                MessageBox.Show("Lütfen geçerli bir tc no giriniz.");
                return false;
            }

            if (!(sekreter.Sekreter_adi.Length >= 2 && sekreter.Sekreter_adi.Length < 30))
            {
                MessageBox.Show("Sekreter adı çok kısa veya çok uzun lütfen geçerli bir ad giriniz");
                return false;
            }
            if (!(sekreter.Sekreter_soyadi.Length >= 2 && sekreter.Sekreter_soyadi.Length < 30))
            {
                MessageBox.Show("Sekreter soyadı çok kısa veya çok uzun lütfen geçerli bir soyad giriniz");
            }

            if (!(sekreter.Sekreter_yasi > 10 && sekreter.Sekreter_yasi < 150))
            {
                MessageBox.Show("Lütfen geçerli bir sekreter yaşı giriniz");
                return false;
            }

            if (!(sekreter.Sekreter_email.Contains("@") && sekreter.Sekreter_email.Contains(".")))
            {
                MessageBox.Show("Lütfen geçerli bir e mail giriniz.");
                return false;
            }

            return true;
        }

        public static bool HastaEmailGecerliMi(string email)
        {
            if (!(email.Contains("@hotmail.com")))
            {
                MessageBox.Show("Lütfen geçerli bir mail giriniz (@hotmail.com şeklinde olmalıdır.)");
                return false;
            }

            return true;
        }
    }
}
