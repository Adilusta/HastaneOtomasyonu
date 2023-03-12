using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Hasta : IEntity
    {
        public int Hasta_id { get; set; }
        public string Hasta_adi { get; set; }
        public string Hasta_soyadi { get; set; }
        public string Hasta_tcno { get; set; }
        public int Hasta_yasi { get; set; }
        public string Hasta_cinsiyeti { get; set; }
        public string Hasta_telNo { get; set; }
        public string Hasta_email { get; set; }

    }
}
