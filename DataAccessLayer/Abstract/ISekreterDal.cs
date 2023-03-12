using DataAccessLayer.Abstract;
using EntityLayer;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DataAccessLayer
{
    public interface ISekreterDal 
    {
        bool GirisBasariliMi(Sekreter sekreter);
         bool HastaMevcutMu(string tcNo);
        ComboBox BranslariGetir(ComboBox comboBox);
         List<Doktor> BransaGoreDoktorGetir(int brans_id);
         List<Randevu> HastayaGoreRandevulariGetir(string tcNo);
         Randevu RandevuIdyeGoreRandevuGetir(int randevuId);
        string EskiRandevuKayitlariniGetir(Randevu randevuBilgileri);

        //ComboBox BransaGoreDoktorGetir(ComboBox comboBox, int brans_id);
        ComboBox DoktorlariGetir(ComboBox comboBox);
       
        Hasta HastaGetir(string tcNo);
        Doktor DoktorGetir(string tcNo);
        Sekreter SekreterGetir(string tcNo);

        //EKLEME METOTLARI
        void HastaEkle(Hasta hasta);
        void DoktorEkle(Doktor doktor);
        void SekreterEkle(Sekreter sekreter);
        void RandevuEkle(Randevu randevu);
        void RandevuNotuEkle(Randevu randevu);

        //SİLME METOTLARI
        void Hastasil(Hasta hasta);
        void DoktorSil(Doktor doktor);
        void SekreterSil(Sekreter sekreter);
        void RandevuSil( int Randevu_id);

        //GÜNCELLEME METOTLARI
        void HastaGuncelle(Hasta hasta);
        void SekreterGuncelle(Sekreter sekreter);

        void DoktorGuncelle(Doktor doktor);
        void RandevuGuncelle(Randevu randevu);

         Chart DoktoraGoreHastaGrafigiGetir(Chart chart);

        Chart BransaGoreHastaSayisiGrafigiGetir(Chart chart);


    }
}
