using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationandManagementSystem.EntityLayer
{
    internal class EntityOda
    {
        private int odaID;
        private int odaNumara;
        private string odaTip;
        private decimal odaFiyat;
        private string odaDurum;

        public int OdaID { get => odaID; set => odaID = value; }
        public int OdaNumara { get => odaNumara; set => odaNumara = value; }
        public string OdaTip { get => odaTip; set => odaTip = value; }
        public decimal OdaFiyat { get => odaFiyat; set => odaFiyat = value; }
        public string OdaDurum { get => odaDurum; set => odaDurum = value; }
    }
}
