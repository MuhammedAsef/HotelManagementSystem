using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationandManagementSystem.EntityLayer
{
    internal class EntityFatura
    {
        private int faturaId;
        private int rezervasyonID;
        private int musteriID;
        private decimal toplamUcret;
        private string rezervasyonDurumu;

        public int FaturaId { get => faturaId; set => faturaId = value; }
        public int RezervasyonID { get => rezervasyonID; set => rezervasyonID = value; }
        public int MusteriID { get => musteriID; set => musteriID = value; }
        public decimal ToplamUcret { get => toplamUcret; set => toplamUcret = value; }
        public string RezervasyonDurumu { get => rezervasyonDurumu; set => rezervasyonDurumu = value; }
    }
}
