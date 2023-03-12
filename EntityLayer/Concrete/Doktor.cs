using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Doktor :IEntity
    {
        public int Doktor_id { get; set; }
        public string Doktor_adi { get; set; }
        public string Doktor_soyadi { get; set; }
        public string Doktor_tcNo { get; set; }
        public int Doktor_yasi { get; set; }
        public string Doktor_cinsiyeti { get; set; }
        public string Doktor_tel_no { get; set; }
        public int Doktor_bransid { get; set; }
        public string Doktor_email { get; set; }
        public string Doktor_sifre { get; set; }
        public string Doktor_bransi { get; set; }



    }
}
