using HotelReservationandManagementSystem.DAL;
using HotelReservationandManagementSystem.EntityLayer;
using HotelReservationandManagementSystem.LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationandManagementSystem
{
    public partial class FrmRezervasyonIslemleri : UserControl
    {
        public FrmRezervasyonIslemleri()
        {
            InitializeComponent();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int OdaId = Convert.ToInt32(txtOdaID.Text);
                int MusteriId = Convert.ToInt32(txtMusteriID.Text);
                DateTime GirisTarihi = dtpGirisTarihi.Value;
                DateTime CıkısTarihi = dtpCikisTarihi.Value;

                bool islem = OtelRezDAO.RezervasyonYap(OdaId, MusteriId, GirisTarihi, CıkısTarihi);
                if (islem)
                {
                    MessageBox.Show("Rezervasyon başarıyla yapıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hata : Rezervasyon yapılamadı", "Uyarı", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA" + ex.Message);
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int rezervasyonID = Convert.ToInt32(txtRezervasyonID.Text);

                int sonuc = OtelRezLogic.LLRezervSil(rezervasyonID);

                if (sonuc > 0)
                {
                    MessageBox.Show("Rezervasyon başarıyla silindi ve ilgili oda durumu güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Rezervasyon silinemedi. Rezervasyon ID bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dtpGirisTarihi_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker1 = sender as DateTimePicker;

            if (dateTimePicker1 != null)
            {
                DateTime selectedDate = dateTimePicker1.Value;

                if (selectedDate < DateTime.Today)
                {
                    MessageBox.Show("Lütfen bugünden sonraki bir tarih seçin!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dateTimePicker1.Value = DateTime.Today;
                }
                else
                {
                    MessageBox.Show($"Seçilen Tarih : {selectedDate.ToShortDateString()}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void dtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker2 = sender as DateTimePicker;

            if (dateTimePicker2 != null)
            {
                DateTime selectedDate2 = dateTimePicker2.Value;

                DateTime selectedDate1 = dtpGirisTarihi.Value;

                if (selectedDate2 < selectedDate1)
                {
                    MessageBox.Show("Çıkış tarihi, giriş tarihinden sonraki bir tarih olmalıdır!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dateTimePicker2.Value = selectedDate1;
                }
                else
                {
                    MessageBox.Show($"Seçilen Çıkış Tarihi : {selectedDate2.ToShortDateString()}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void FrmRezervasyonIslemleri_Load(object sender, EventArgs e)
        {
            List<EntityRezervasyon> RezList = OtelRezLogic.LLRezListesi();
            dataGridView1.DataSource = RezList;
        }
    }
}
