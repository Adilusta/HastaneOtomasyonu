using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Randevu :IEntity
    {
        public int Randevu_id { get; set; }
        public int Doktor_id { get; set; }
        public string Hasta_tcNo { get; set; }
        public string Brans_adi { get; set; }
        public string Randevu_saati { get; set; }
        public string Randevu_tarihi { get; set; }
        public string Randevu_notu { get; set; }
        public int Brans_id { get; set; }


    }
}
