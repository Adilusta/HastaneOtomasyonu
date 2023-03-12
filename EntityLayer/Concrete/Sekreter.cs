using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Sekreter : IEntity
    {
        public int Sekreter_id { get; set; }
        public string Sekreter_adi { get; set; }
        public string Sekreter_soyadi { get; set; }
        public string Sekreter_tcno { get; set; }
        public int Sekreter_yasi { get; set; }
        public string Sekreter_cinsiyeti { get; set; }
        public string Sekreter_telNo { get; set; }
        public int Sekreter_bransid { get; set; }
        public string Sekreter_email { get; set; }
        public string Sekreter_sifre { get; set; }
    }
}
