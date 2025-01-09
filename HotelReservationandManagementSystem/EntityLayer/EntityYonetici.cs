using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationandManagementSystem.EntityLayer
{
    internal class EntityYonetici
    {
        public int yoneticiID;
        public string yoneticiAd;
        public string yoneticiSoyad;
        public string yoneticiTC;
        public int yoneticiSifre;

        public int YoneticiId { get => yoneticiID; set => yoneticiID = value; }
        public string YoneticiAd { get => yoneticiAd; set => yoneticiAd = value; }
        public string YoneticiSoyad { get => yoneticiSoyad; set => yoneticiSoyad = value; }
        public string YoneticiTC { get => yoneticiTC; set => yoneticiTC = value; }
        public int YoneticiSifre { get => yoneticiSifre; set => yoneticiSifre = value; }
    }
}
