using BusinessLayer.Abstract;
using DataAccessLayer;
using DataAccessLayer.Abstract;
using EntityLayer;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BusinessLayer.Concrete
{
    public class SekreterManager : ISekreterService
    {
        private ISekreterDal _sekreterDal;
        public SekreterManager(ISekreterDal sekreterDal)
        {
            this._sekreterDal = sekreterDal;
        }
        public ComboBox BranslariGetir(ComboBox comboBox)
        {
           return _sekreterDal.BranslariGetir(comboBox);
        }
        public List<Doktor> BransaGoreDoktorGetir(int brans_id)
        {
           return _sekreterDal.BransaGoreDoktorGetir(brans_id);
        }
        public List<Randevu> HastayaGoreRandevulariGetir(string tcNo)
        {
           return _sekreterDal.HastayaGoreRandevulariGetir(tcNo);
        }
        public Randevu RandevuIdyeGoreRandevuGetir(int randevuId)
        {
           return _sekreterDal.RandevuIdyeGoreRandevuGetir(randevuId);
        }
        public string EskiRandevuKayitlariniGetir(Randevu randevuBilgileri)
        {
            return _sekreterDal.EskiRandevuKayitlariniGetir(randevuBilgileri);
        }
        //public ComboBox BransaGoreDoktorGetir(ComboBox comboBox, int brans_id)
        //{
        //  return  _sekreterDal.BransaGoreDoktorGetir(comboBox,brans_id);
        //}
        public ComboBox DoktorlariGetir(ComboBox comboBox)
        {
            return _sekreterDal.DoktorlariGetir(comboBox);
        }
        public Hasta HastaGetir(string tcNo)
        {
            return _sekreterDal.HastaGetir(tcNo);
        }
        public Doktor DoktorGetir(string tcNo)
        {
            return _sekreterDal.DoktorGetir(tcNo);
        }
        public Sekreter SekreterGetir(string tcNo)
        {
            return _sekreterDal.SekreterGetir(tcNo);
        }
        public bool GirisBasariliMi(Sekreter sekreter)
        {
            return _sekreterDal.GirisBasariliMi(sekreter);
        }
       public bool HastaMevcutMu(string tcNo)
        {
            return _sekreterDal.HastaMevcutMu(tcNo);
        }

        #region EKLEME  İŞLEMLERİ

        public void HastaEkle(Hasta hasta)
        {
            _sekreterDal.HastaEkle(hasta);
        }
        public void DoktorEkle(Doktor doktor)
        {
            _sekreterDal.DoktorEkle( doktor);
        }
        public void SekreterEkle(Sekreter sekreter)
        {
            _sekreterDal.SekreterEkle( sekreter);
        }
        public void RandevuEkle(Randevu randevu)
        {
            _sekreterDal.RandevuEkle(randevu);
        }
        public void RandevuNotuEkle(Randevu randevu)
        {
            _sekreterDal.RandevuNotuEkle(randevu);
        }

        #endregion

        #region SİLME İŞLEMLERİ
        public void Hastasil(Hasta hasta)
        {
            _sekreterDal.Hastasil(hasta);
        }
        public void DoktorSil(Doktor doktor)
        {
            _sekreterDal.DoktorSil(doktor);
        }
        public void SekreterSil(Sekreter sekreter)
        {
            _sekreterDal.SekreterSil(sekreter);
        }
        public void RandevuSil(int Randevu_id)
        {
            _sekreterDal.RandevuSil(Randevu_id);
        }
        #endregion

        #region GÜNCELLEME İŞLEMLERİ
        public void HastaGuncelle(Hasta hasta)
        {
            _sekreterDal.HastaGuncelle(hasta);
        }
        public void DoktorGuncelle(Doktor doktor)
        {
            _sekreterDal.DoktorGuncelle(doktor);
        }

       
      
        public void SekreterGuncelle(Sekreter sekreter)
        {
            _sekreterDal.SekreterGuncelle(sekreter);
        }
        public void RandevuGuncelle(Randevu randevu)
        {
            _sekreterDal.RandevuGuncelle(randevu);
        }
        #endregion


        public Chart DoktoraGoreHastaGrafigiGetir(Chart chart)
        {
            return _sekreterDal.DoktoraGoreHastaGrafigiGetir(chart);
        }

        public Chart BransaGoreHastaSayisiGrafigiGetir(Chart chart)
        {
            return _sekreterDal.BransaGoreHastaSayisiGrafigiGetir(chart);
        }








    }
}
