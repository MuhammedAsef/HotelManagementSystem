using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationandManagementSystem.EntityLayer
{
    internal class EntityMusteri
    {
        private int musteriId;
        private string musteriAd;
        private string musteriSoyad;
        private string musteriTC;
        private string musteriTelefon;
        private string musteriCinsiyet;

        public int MusteriId { get => musteriId; set => musteriId = value; }
        public string MusteriAd { get => musteriAd; set => musteriAd = value; }
        public string MusteriSoyad { get => musteriSoyad; set => musteriSoyad = value; }
        public string MusteriTC { get => musteriTC; set => musteriTC = value; }
        public string MusteriTelefon { get => musteriTelefon; set => musteriTelefon = value; }
        public string MusteriCinsiyet { get => musteriCinsiyet; set => musteriCinsiyet = value; }
    }
}
