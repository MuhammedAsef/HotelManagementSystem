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
using MySql;
using MySql.Data.MySqlClient;

namespace HotelReservationandManagementSystem
{
    public partial class FrmMusteriIslemleri : UserControl
    {
        public FrmMusteriIslemleri()
        {
            InitializeComponent();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMusteriID.Text))
            {
                MessageBox.Show("Lütfen Müşteri ID bilgisini girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    int musteriID = Convert.ToInt32(txtMusteriID.Text);
                    bool sonuc = OtelRezLogic.LLMusteriSil(musteriID);

                    if (sonuc)
                    {
                        MessageBox.Show("Müşteri başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtMusteriID.Clear();

                        LoadDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Müşteri silinirken bir hata oluştu veya müşteri bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Lütfen Müşteri ID için doğru formatta bir sayı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Beklenmeyen bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMusteriAd.Text) ||
                string.IsNullOrWhiteSpace(txtMusteriSoyad.Text) ||
                string.IsNullOrWhiteSpace(mskTC.Text) ||
                string.IsNullOrWhiteSpace(mskMusteriTelefon.Text) ||
                string.IsNullOrWhiteSpace(cmbCinsiyet.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    EntityMusteri ent = new EntityMusteri();
                    ent.MusteriAd = txtMusteriAd.Text;
                    ent.MusteriSoyad = txtMusteriSoyad.Text;
                    ent.MusteriTC = mskTC.Text;
                    ent.MusteriTelefon = mskMusteriTelefon.Text;
                    ent.MusteriCinsiyet = cmbCinsiyet.Text;

                    int sonuc = OtelRezLogic.LLMusteriEkle(ent);

                    if (sonuc > 0)
                    {
                        MessageBox.Show("Müşteri kaydı başarıyla oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtMusteriAd.Clear();
                        txtMusteriSoyad.Clear();
                        mskTC.Clear();
                        mskMusteriTelefon.Clear();
                        cmbCinsiyet.SelectedIndex = -1;

                        LoadDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Müşteri eklenirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Lütfen doğru formatta değerler girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Beklenmeyen bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMusteriID.Text) ||
       string.IsNullOrWhiteSpace(txtMusteriAd.Text) ||
       string.IsNullOrWhiteSpace(txtMusteriSoyad.Text) ||
       string.IsNullOrWhiteSpace(mskTC.Text) ||
       string.IsNullOrWhiteSpace(mskMusteriTelefon.Text) ||
       string.IsNullOrWhiteSpace(cmbCinsiyet.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    EntityMusteri ent = new EntityMusteri();
                    ent.MusteriId = Convert.ToInt32(txtMusteriID.Text);
                    ent.MusteriAd = txtMusteriAd.Text;
                    ent.MusteriSoyad = txtMusteriSoyad.Text;
                    ent.MusteriTC = mskTC.Text;
                    ent.MusteriTelefon = mskMusteriTelefon.Text;
                    ent.MusteriCinsiyet = cmbCinsiyet.Text;

                    bool sonuc = OtelRezLogic.LLMusteriGuncelle(ent);

                    if (sonuc)
                    {
                        MessageBox.Show("Müşteri bilgileri başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtMusteriID.Clear();
                        txtMusteriAd.Clear();
                        txtMusteriSoyad.Clear();
                        mskTC.Clear();
                        mskMusteriTelefon.Clear();
                        cmbCinsiyet.SelectedIndex = -1;

                        LoadDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme işlemi sırasında bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Lütfen doğru formatta değerler girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Beklenmeyen bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadDataGridView()
        {
            try
            {
                dataGridView1.DataSource = OtelRezLogic.LLMusteriListesi();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veriler yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtMusteriID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtMusteriAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtMusteriSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mskTC.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskMusteriTelefon.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            cmbCinsiyet.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }
        private void FrmMusteriIslemleri_Load(object sender, EventArgs e)
        {
            List<EntityMusteri> MusteriListesi = OtelRezLogic.LLMusteriListesi();
            dataGridView1.DataSource = MusteriListesi;
        }
    }
}