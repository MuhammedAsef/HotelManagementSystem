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

namespace HotelReservationandManagementSystem.PresentationLayer
{
    public partial class FrmBilgiDuzenle : UserControl
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                EntityYonetici yonetici = new EntityYonetici();
                yonetici.YoneticiAd = txtAd.Text;
                yonetici.YoneticiSoyad = txtSoyad.Text;
                yonetici.YoneticiTC = mskTC.Text;
                yonetici.YoneticiSifre = int.Parse(txtSifre.Text);

                OtelRezLogic yoneticiService = new OtelRezLogic();
                yoneticiService.LLBilgiGuncelle(yonetici);

                MessageBox.Show("Bilgileriniz başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            kodolustur();
        }
        void kodolustur()
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(10000, 100000);
            txtKod2.Text = sayi.ToString();
        }
    }
}