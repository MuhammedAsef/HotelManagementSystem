using HotelReservationandManagementSystem.DAL;
using HotelReservationandManagementSystem.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HotelReservationandManagementSystem.LogicLayer.OtelRezLogic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelReservationandManagementSystem.LogicLayer
{
    internal class OtelRezLogic
    {
        public static List<EntityOda> LLOdaListesi()
        {
            return OtelRezDAO.OdaListesi();
        }
        public static List<EntityMusteri> LLMusteriListesi()
        {
            return OtelRezDAO.MusteriListesi();
        }
        public static int LLMusteriEkle(EntityMusteri m)
        {
            if (m.MusteriAd != "" && m.MusteriSoyad != "")
            {
                return OtelRezDAO.MusteriEkle(m);
            }
            else
            {
                return -1;
            }
        }
        public static bool LLMusteriSil(int musteri)
        {
            if (musteri >= 1)
            {
                return OtelRezDAO.MusteriSil(musteri);
            }
            else
            {
                return false;
            }
        }
        public static bool LLMusteriGuncelle(EntityMusteri ent)
        {
            if (ent.MusteriAd != "" && ent.MusteriSoyad != "" && ent.MusteriTC != ""
                && ent.MusteriTelefon != "" && ent.MusteriCinsiyet != "")
            {
                return OtelRezDAO.MusteriGuncelle(ent);
            }
            else
            {
                return false;
            }
        }
        public static bool LLOdaSil(int oda)
        {
            if (oda >= 1)
            {
                return OtelRezDAO.OdaSil(oda);
            }
            else
            {
                return false;
            }
        }
        public static int LLOdaEkle(EntityOda o)
        {
            if (o.OdaNumara >= 100)
            {
                return OtelRezDAO.OdaEkle(o);
            }
            else
            {
                return -1;
            }
        }
        public static int LLOdaGuncelle(EntityOda ent)
        {
            if (ent.OdaDurum != "" && ent.OdaFiyat != 0 && ent.OdaTip != "" && ent.OdaNumara != 0)
            {
                return OtelRezDAO.OdaGuncelle(ent);
            }
            else
            {
                return -1;
            }
        }
        public static List<EntityRezervasyon> LLRezListesi()
        {
            return OtelRezDAO.RezervasyonListesi();
        }
        public static int LLRezervSil(int rez)
        {
            if (rez >= 1)
            {
                return OtelRezDAO.RezervasyonSil(rez);
            }
            else
            {
                return 0;
            }
        }

        public OtelRezDAO yoneticiDAL;
        public OtelRezLogic()
        {
            yoneticiDAL = new OtelRezDAO();
        }
        public bool LLGirisYap(string tc, string sifre)
        {
            if (string.IsNullOrWhiteSpace(tc) || string.IsNullOrWhiteSpace(sifre))
            {
                throw new ArgumentException("TC ve Şifre boş olamaz!");
            }

            return yoneticiDAL.YoneticiGirisKontrol(tc, sifre);
        }
        public bool LLBilgiGuncelle(EntityYonetici yonetici)
        {
            if (yonetici.YoneticiTC != "")
            {
                yoneticiDAL.YoneticiBilgiGuncelle(yonetici);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}