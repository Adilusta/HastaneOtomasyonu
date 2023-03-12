using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DoktorManager : IDoktorService
    {
        private IDoktorDal _doktorDal;
        public DoktorManager(IDoktorDal doktorDal)
        {
            _doktorDal = doktorDal;
        }

        public bool GirisBasariliMi(Doktor doktor)
        {
          return  _doktorDal.GirisBasariliMi(doktor);
        }

        public void EskiKayitlariGetir()
        {
            throw new NotImplementedException();
        }

       
        public void RandevuGorusmesiKaydet()
        {
            throw new NotImplementedException();
        }
    }
}
