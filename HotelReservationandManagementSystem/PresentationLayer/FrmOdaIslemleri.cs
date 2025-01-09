using HotelReservationandManagementSystem;
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
using MySql.Data.MySqlClient;
using MySql;

namespace HotelReservationandManagementSystem
{
    public partial class FrmOdaIslemleri : UserControl
    {
        public FrmOdaIslemleri()
        {
            InitializeComponent();
        }
        private void btnOdaEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOdaNumara.Text) ||
                string.IsNullOrWhiteSpace(txtOdaTip.Text) ||
                string.IsNullOrWhiteSpace(txtOdaFiyat.Text) ||
                string.IsNullOrWhiteSpace(txtOdaDurum.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    EntityOda ent = new EntityOda();
                    ent.OdaNumara = Convert.ToInt32(txtOdaNumara.Text);
                    ent.OdaTip = txtOdaTip.Text;
                    ent.OdaFiyat = Convert.ToDecimal(txtOdaFiyat.Text);
                    ent.OdaDurum = txtOdaDurum.Text;

                    int sonuc = OtelRezLogic.LLOdaEkle(ent);

                    if (sonuc > 0)
                    {
                        MessageBox.Show("Oda başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtOdaNumara.Clear();
                        txtOdaTip.Clear();
                        txtOdaFiyat.Clear();
                        txtOdaDurum.Clear();

                        LoadOdaDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Oda eklenirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Lütfen sayısal alanlara doğru değerler girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Beklenmeyen bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnOdaSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOdaID.Text))
            {
                MessageBox.Show("Lütfen Oda ID bilgisini girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    int odaID = Convert.ToInt32(txtOdaID.Text);
                    bool sonuc = OtelRezLogic.LLOdaSil(odaID);

                    if (sonuc)
                    {
                        MessageBox.Show("Oda başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtOdaID.Clear();

                        LoadOdaDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Oda silinirken bir hata oluştu veya oda bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Lütfen Oda ID için doğru formatta bir sayı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Beklenmeyen bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnOdaGuncelle_Click(object sender, EventArgs e)
        {
            short odaID;
            int odaNumara;
            decimal odaFiyat;

            if (string.IsNullOrWhiteSpace(txtOdaID.Text) ||
                string.IsNullOrWhiteSpace(txtOdaTip.Text) ||
                string.IsNullOrWhiteSpace(txtOdaNumara.Text) ||
                string.IsNullOrWhiteSpace(txtOdaFiyat.Text) ||
                string.IsNullOrWhiteSpace(txtOdaDurum.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else if (!short.TryParse(txtOdaID.Text, out odaID))
            {
                MessageBox.Show("Oda ID yalnızca kısa tam sayı (short) olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(txtOdaNumara.Text, out odaNumara))
            {
                MessageBox.Show("Oda numarası yalnızca tam sayı (int) olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!decimal.TryParse(txtOdaFiyat.Text, out odaFiyat))
            {
                MessageBox.Show("Fiyat yalnızca ondalıklı sayı (decimal) olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    EntityOda ent = new EntityOda
                    {
                        OdaID = odaID,
                        OdaTip = txtOdaTip.Text,
                        OdaNumara = odaNumara,
                        OdaFiyat = odaFiyat,
                        OdaDurum = txtOdaDurum.Text
                    };

                    int sonuc = OtelRezLogic.LLOdaGuncelle(ent);

                    if (sonuc > 0)
                    {
                        MessageBox.Show("Oda başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtOdaID.Clear();
                        txtOdaTip.Clear();
                        txtOdaNumara.Clear();
                        txtOdaFiyat.Clear();
                        txtOdaDurum.Clear();

                        LoadOdaDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Oda güncellenirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Beklenmeyen bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadOdaDataGridView()
        {
            try
            {
                dataGridView1.DataSource = OtelRezLogic.LLOdaListesi();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veriler yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtOdaID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtOdaNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtOdaTip.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtOdaFiyat.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtOdaDurum.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }
        private void FrmOdaIslemleri_Load(object sender, EventArgs e)
        {
            List<EntityOda> MusteriList = OtelRezLogic.LLOdaListesi();
            dataGridView1.DataSource = MusteriList;
        }
    }
}