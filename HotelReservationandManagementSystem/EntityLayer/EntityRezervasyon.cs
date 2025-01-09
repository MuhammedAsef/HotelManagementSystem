using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationandManagementSystem.EntityLayer
{
    internal class EntityRezervasyon
    {
        private int rezervasyonID;
        private DateTime rezGirisTarihi;
        private DateTime rezCikisTarihi;
        private int musteriID;
        private int odaID;

        public int RezervasyonID { get => rezervasyonID; set => rezervasyonID = value; }
        public DateTime RezGirisTarihi { get => rezGirisTarihi; set => rezGirisTarihi = value; }
        public DateTime RezCikisTarihi { get => rezCikisTarihi; set => rezCikisTarihi = value; }
        public int MusteriID { get => musteriID; set => musteriID = value; }
        public int OdaID { get => odaID; set => odaID = value; }
    }
}
