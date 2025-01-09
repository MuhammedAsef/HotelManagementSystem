using MySql.Data.MySqlClient;
using HotelReservationandManagementSystem.DAL;
using HotelReservationandManagementSystem.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelReservationandManagementSystem.DAL
{
    internal class OtelRezDAO
    {
        public static List<EntityOda> OdaListesi()
        {
            List<EntityOda> degerler1 = new List<EntityOda>();
            using (MySqlConnection baglanti = (new baglantiGetir().BaglantiGetir()))
            {
                MySqlCommand komut = new MySqlCommand("Select * from TBLODA", baglanti);
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                MySqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    EntityOda ent = new EntityOda();
                    ent.OdaID = Convert.ToInt32(dr["OdaId"]);
                    ent.OdaNumara = Convert.ToInt32(dr["OdaNumara"]);
                    ent.OdaTip = Convert.ToString(dr["OdaTip"]);
                    ent.OdaFiyat = Convert.ToDecimal(dr["OdaFiyat"]);
                    ent.OdaDurum = Convert.ToString(dr["OdaDurum"]);
                    degerler1.Add(ent);
                }
                dr.Close();
                return degerler1;
            }
        }
        public static List<EntityMusteri> MusteriListesi()
        {
            List<EntityMusteri> degerler2 = new List<EntityMusteri>();
            using (MySqlConnection baglanti = (new baglantiGetir().BaglantiGetir()))
            {
                MySqlCommand komut1 = new MySqlCommand("Select * from TBLMUSTERİ", baglanti);
                if (komut1.Connection.State != ConnectionState.Open)
                {
                    komut1.Connection.Open();
                }
                MySqlDataReader dr = komut1.ExecuteReader();
                while (dr.Read())
                {
                    EntityMusteri ent = new EntityMusteri();
                    ent.MusteriId = Convert.ToInt32(dr["MusteriId"]);
                    ent.MusteriAd = Convert.ToString(dr["MusteriAd"]);
                    ent.MusteriSoyad = Convert.ToString(dr["MusteriSoyad"]);
                    ent.MusteriTC = Convert.ToString(dr["MusteriTc"]);
                    ent.MusteriTelefon = Convert.ToString(dr["MusteriTelefon"]);
                    ent.MusteriCinsiyet = Convert.ToString(dr["MusteriCinsiyet"]);
                    degerler2.Add(ent);
                }
                dr.Close();
                return degerler2;
            }
        }
        public static bool MusteriSil(int p)
        {
            using (MySqlConnection baglanti = (new baglantiGetir().BaglantiGetir()))
            {
                MySqlCommand komut2 = new MySqlCommand("delete from TBLMUSTERİ where MusteriID=@musteriID", baglanti);
                if (komut2.Connection.State != ConnectionState.Open)
                {
                    komut2.Connection.Open();
                }
                komut2.Parameters.AddWithValue("@musteriID", p);
                return komut2.ExecuteNonQuery() > 0;
            }
        }
        public static int MusteriEkle(EntityMusteri m)
        {
            using (MySqlConnection baglanti = (new baglantiGetir().BaglantiGetir()))
            {
                MySqlCommand komut3 = new MySqlCommand("insert into TBLMUSTERİ (MusteriAd,MusteriSoyad,MusteriTC,MusteriTelefon,MusteriCinsiyet) values (@musteriAd,@musteriSoyad,@musteriTC,@musteriTelefon,@musteriCinsiyet)", baglanti);
                if (komut3.Connection.State != ConnectionState.Open)
                {
                    komut3.Connection.Open();
                }
                komut3.Parameters.AddWithValue("@musteriAd", m.MusteriAd);
                komut3.Parameters.AddWithValue("@musteriSoyad", m.MusteriSoyad);
                komut3.Parameters.AddWithValue("@musteriTC", m.MusteriTC);
                komut3.Parameters.AddWithValue("@musteriTelefon", m.MusteriTelefon);
                komut3.Parameters.AddWithValue("@musteriCinsiyet", m.MusteriCinsiyet);
                return komut3.ExecuteNonQuery();
            }
        }
        public static bool MusteriGuncelle(EntityMusteri ent)
        {
            using (MySqlConnection baglanti = (new baglantiGetir()).BaglantiGetir())
            {
                MySqlCommand komut4 = new MySqlCommand("update TBLMUSTERİ set MusteriAd=@musteriAd,MusteriSoyad=@musteriSoyad,MusteriTC=@musteriTC,MusteriTelefon=@musteriTelefon,MusteriCinsiyet=@musteriCinsiyet where MusteriId=@id", baglanti);
                if (komut4.Connection.State != ConnectionState.Open)
                {
                    komut4.Connection.Open();
                }
                komut4.Parameters.AddWithValue("@musteriAd", ent.MusteriAd);
                komut4.Parameters.AddWithValue("@musteriSoyad", ent.MusteriSoyad);
                komut4.Parameters.AddWithValue("@musteriTC", ent.MusteriTC);
                komut4.Parameters.AddWithValue("@musteriTelefon", ent.MusteriTelefon);
                komut4.Parameters.AddWithValue("@musteriCinsiyet", ent.MusteriCinsiyet);
                komut4.Parameters.AddWithValue("@id", ent.MusteriId);
                return komut4.ExecuteNonQuery() > 0;
            }
        }
        public static bool OdaSil(int o)
        {
            using (MySqlConnection baglanti = (new baglantiGetir().BaglantiGetir()))
            {
                MySqlCommand komut5 = new MySqlCommand("delete from TBLODA where OdaID=@odaID", baglanti);
                if (komut5.Connection.State != ConnectionState.Open)
                {
                    komut5.Connection.Open();
                }
                komut5.Parameters.AddWithValue("@odaID", o);
                return komut5.ExecuteNonQuery() > 0;
            }
        }
        public static int OdaEkle(EntityOda o)
        {
            using (MySqlConnection baglanti = (new baglantiGetir().BaglantiGetir()))
            {
                MySqlCommand komut6 = new MySqlCommand("insert into TBLODA (OdaNumara,OdaTip,OdaFiyat,OdaDurum) values (@odaNumara,@odaTip,@odaFiyat,@odaDurum)", baglanti);
                if (komut6.Connection.State != ConnectionState.Open)
                {
                    komut6.Connection.Open();
                }
                komut6.Parameters.AddWithValue("@odaNumara", o.OdaNumara);
                komut6.Parameters.AddWithValue("@odaTip", o.OdaTip);
                komut6.Parameters.AddWithValue("@odaFiyat", o.OdaFiyat);
                komut6.Parameters.AddWithValue("@odaDurum", o.OdaDurum);
                return komut6.ExecuteNonQuery();
            }
        }
        public static int OdaGuncelle(EntityOda o)
        {
            using (MySqlConnection baglanti = (new baglantiGetir().BaglantiGetir()))
            {
                MySqlCommand komut7 = new MySqlCommand("update TBLODA set OdaTip=@odaTip,OdaNumara=@odaNumara,OdaFiyat=@odaFiyat,OdaDurum=@odaDurum where OdaID=@odaID", baglanti);
                if (komut7.Connection.State != ConnectionState.Open)
                {
                    komut7.Connection.Open();
                }
                komut7.Parameters.AddWithValue("@odaTip", o.OdaTip);
                komut7.Parameters.AddWithValue("@odaNumara", o.OdaNumara);
                komut7.Parameters.AddWithValue("@odaFiyat", o.OdaFiyat);
                komut7.Parameters.AddWithValue("@odaDurum", o.OdaDurum);
                komut7.Parameters.AddWithValue("@odaID", o.OdaID);

                return komut7.ExecuteNonQuery();
            }
        }
        public static List<EntityRezervasyon> RezervasyonListesi()
        {
            List<EntityRezervasyon> degerler3 = new List<EntityRezervasyon>();
            using (MySqlConnection baglanti = (new baglantiGetir().BaglantiGetir()))
            {
                MySqlCommand komut8 = new MySqlCommand("select * from TBLREZERVASYON", baglanti);
                if (komut8.Connection.State != ConnectionState.Open)
                {
                    komut8.Connection.Open();
                }
                MySqlDataReader dr = komut8.ExecuteReader();
                while (dr.Read())
                {
                    EntityRezervasyon ent = new EntityRezervasyon();
                    ent.RezervasyonID = Convert.ToInt32(dr["RezervasyonID"]);
                    ent.RezGirisTarihi = Convert.ToDateTime(dr["RezGirisTarihi"].ToString());
                    ent.RezCikisTarihi = Convert.ToDateTime(dr["RezCikisTarihi"].ToString());
                    ent.MusteriID = Convert.ToInt32(dr["MusteriID"].ToString());
                    if (int.TryParse(dr["OdaID"].ToString(), out int odaID))
                    {
                        ent.OdaID = odaID;
                    }
                    else
                    {
                        ent.OdaID = 0;
                    }
                    degerler3.Add(ent);
                }
                dr.Close();
                return degerler3;
            }
        }
        public bool YoneticiGirisKontrol(string tc, string sifre)
        {
            using (MySqlConnection baglanti = (new baglantiGetir().BaglantiGetir()))
            {
                MySqlCommand komut9 = new MySqlCommand("Select * from TBLYONETİCİ where YoneticiTC=@yoneticiTC and YoneticiSifre=@yoneticiSifre", baglanti);
                komut9.Parameters.AddWithValue("@yoneticiTC", tc);
                komut9.Parameters.AddWithValue("@yoneticiSifre", sifre);

                MySqlDataReader dr = komut9.ExecuteReader();
                return dr.Read();
            }
        }
        public bool YoneticiBilgiGuncelle(EntityYonetici yonetici)
        {
            using (MySqlConnection baglanti = (new baglantiGetir().BaglantiGetir()))
            {
                MySqlCommand komut10 = new MySqlCommand("UPDATE TBLYONETİCİ SET YoneticiAd=@yoneticiAd, YoneticiSoyad=@yoneticiSoyad, YoneticiSifre=@yoneticiSifre WHERE YoneticiTc=@yoneticiTC", baglanti);
                komut10.Parameters.AddWithValue("@yoneticiAd", yonetici.yoneticiAd);
                komut10.Parameters.AddWithValue("@yoneticiSoyad", yonetici.yoneticiSoyad);
                komut10.Parameters.AddWithValue("@yoneticiSifre", yonetici.yoneticiSifre);
                komut10.Parameters.AddWithValue("@yoneticiTC", yonetici.yoneticiTC);

                return komut10.ExecuteNonQuery() >0;
            }
        }
        public static int RezervasyonSil(int rez)
        {
            using (MySqlConnection baglanti = (new baglantiGetir().BaglantiGetir()))
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                using (MySqlCommand komut11 = new MySqlCommand("UPDATE TBLFATURA SET RezervasyonDurumu = 'Geçmiş rezervasyon' WHERE RezervasyonID = @rezervasyonID", baglanti))
                {
                    komut11.Parameters.AddWithValue("@rezervasyonID", rez);
                    komut11.ExecuteNonQuery();
                }
                int odaID = 0;
                using (MySqlCommand komutOdaBul = new MySqlCommand("SELECT OdaID FROM TBLREZERVASYON WHERE RezervasyonID = @rezervasyonID", baglanti))
                {
                    komutOdaBul.Parameters.AddWithValue("@rezervasyonID", rez);
                    object odaIDObj = komutOdaBul.ExecuteScalar();
                    if (odaIDObj != null)
                    {
                        odaID = Convert.ToInt32(odaIDObj);
                    }
                }
                MySqlCommand komut12 = new MySqlCommand("Delete from TBLREZERVASYON where RezervasyonID=@rezervasyonId", baglanti);
                komut12.Parameters.AddWithValue("@rezervasyonId", rez);
                int result = komut12.ExecuteNonQuery();

                if (odaID > 0)
                {
                    using (MySqlCommand komutOdaGuncelle = new MySqlCommand("UPDATE TBLODA SET OdaDurum = 'Uygun' WHERE OdaID = @odaID", baglanti))
                    {
                        komutOdaGuncelle.Parameters.AddWithValue("@odaID", odaID);
                        komutOdaGuncelle.ExecuteNonQuery();
                    }
                }
                return result;
            }
        }
        public static bool OdaRezervasonTarihiUygunMu(int OdaId, DateTime girisTarihi, DateTime cikisTarihi)
        {
            using (MySqlConnection baglanti = (new baglantiGetir().BaglantiGetir()))
            {
                try
                {
                    if (baglanti.State != ConnectionState.Open)
                    {
                        baglanti.Open();
                    }
                    string query = "SELECT COUNT(*) FROM TBLREZERVASYON WHERE OdaID = @odaid AND (RezGirisTarihi <= @cikistarih AND RezCikisTarihi >= @giristarih)";
                    using (MySqlCommand komut13 = new MySqlCommand(query, baglanti))
                    {
                        komut13.Parameters.AddWithValue("@odaid", OdaId);
                        komut13.Parameters.AddWithValue("@giristarih", girisTarihi.Date);
                        komut13.Parameters.AddWithValue("@cikistarih", cikisTarihi.Date);

                        int rezervasyonsayisi = Convert.ToInt32(komut13.ExecuteScalar());
                        return rezervasyonsayisi == 0;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tarih kontrolü sırasında hata:" + ex.Message);
                    return false;
                }
            }
        }
        public static bool RezervasyonYap(int OdaId, int MusteriId, DateTime GirisTarihi, DateTime CıkısTarihi)
        {
            if (OdaRezervasonTarihiUygunMu(OdaId, GirisTarihi, CıkısTarihi))
            {
                using (MySqlConnection baglanti = (new baglantiGetir().BaglantiGetir()))
                {
                    if (baglanti.State != ConnectionState.Open)
                    {
                        baglanti.Open();
                    }
                    
                    MySqlCommand komut14 = new MySqlCommand("Insert Into TBLREZERVASYON (OdaID, MusteriID, RezGirisTarihi, RezCikisTarihi) values (@odaID, @musteriID, @girisTarih, @cikisTarih)", baglanti);
                    komut14.Parameters.AddWithValue("@odaID", OdaId);
                    komut14.Parameters.AddWithValue("@girisTarih", GirisTarihi);
                    komut14.Parameters.AddWithValue("@cikisTarih", CıkısTarihi);
                    komut14.Parameters.AddWithValue("@musteriID", MusteriId);

                    komut14.ExecuteNonQuery();
                    long rezervasyonID = komut14.LastInsertedId;

                    if (rezervasyonID > 0)
                    {
                        MySqlCommand komut15 = new MySqlCommand("Insert Into TBLFATURA (MusteriID, RezervasyonID, ToplamUcret) values (@musteriID, @rezervasyonID, @toplamUcret)", baglanti);
                        komut15.Parameters.AddWithValue("@musteriID", MusteriId);
                        komut15.Parameters.AddWithValue("@rezervasyonID", rezervasyonID);

                        double toplamUcret = HesaplaToplamUcret(GirisTarihi, CıkısTarihi, OdaId);
                        komut15.Parameters.AddWithValue("@toplamUcret", toplamUcret);

                        komut15.ExecuteNonQuery();
                        
                        MySqlCommand komut16 = new MySqlCommand("UPDATE TBLODA SET OdaDurum = 'Uygun Değil' WHERE OdaID = @odaID", baglanti);
                        komut16.Parameters.AddWithValue("@odaID", OdaId);

                        komut16.ExecuteNonQuery();
                    }
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        private static double HesaplaToplamUcret(DateTime GirisTarihi, DateTime CıkısTarihi, int OdaId)
        {
            using (MySqlConnection baglanti = (new baglantiGetir().BaglantiGetir()))
            {
                int geceSayisi = (CıkısTarihi - GirisTarihi).Days +1;

                MySqlCommand komut17 = new MySqlCommand("SELECT OdaFiyat FROM TBLODA WHERE OdaID = @odaID", baglanti);
                komut17.Parameters.AddWithValue("@odaID", OdaId);

                object fiyatObj = komut17.ExecuteScalar();
                if (fiyatObj != null && double.TryParse(fiyatObj.ToString(), out double odaFiyat))
                {
                    return geceSayisi * odaFiyat;
                }
                else
                {
                    throw new Exception("Oda fiyatı bulunamadı.");
                }
            }
        }
        public static DataTable FaturalariGetir()
        {
            DataTable dtFaturalar = new DataTable();

            using (MySqlConnection baglanti = (new baglantiGetir().BaglantiGetir()))
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                MySqlCommand komut18 = new MySqlCommand("SELECT FaturaID, MusteriID, ToplamUcret, RezervasyonDurumu FROM TBLFATURA", baglanti);
                MySqlDataAdapter da = new MySqlDataAdapter(komut18);

                da.Fill(dtFaturalar);
            }
            return dtFaturalar;
        }
    }
}