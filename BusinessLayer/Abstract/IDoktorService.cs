using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IDoktorService
    {
        bool GirisBasariliMi(Doktor doktor);
        void RandevuGorusmesiKaydet();

        void EskiKayitlariGetir();
    }
}
