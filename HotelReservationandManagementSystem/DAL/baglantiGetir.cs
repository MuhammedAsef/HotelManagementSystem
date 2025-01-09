using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationandManagementSystem.DAL
{
    public class baglantiGetir
    {
        public MySqlConnection BaglantiGetir()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=25_132330061;User=25_132330061;Password=!nif.ogr61KU;");
            baglanti.Open();
            return baglanti;
        }
    }
}