using HotelReservationandManagementSystem.PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HotelReservationandManagementSystem
{
    public partial class FrmYonetici : Form
    {
        public FrmYonetici()
        {
            InitializeComponent();
        }
        private void LoadUserControl(UserControl control)
        {
            mainPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(control);
        }
        private void pctExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Kapatmak istediğinize emin misiniz?", "Onay Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void pctMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Onay Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmGiris fr = new FrmGiris();
                fr.Show();

                this.Hide();
            }
        }
        private void btnMusteriIslemleri_Click(object sender, EventArgs e)
        {
            LoadUserControl(new FrmMusteriIslemleri());
        }
        private void btnOdaIslemleri_Click(object sender, EventArgs e)
        {
            LoadUserControl(new FrmOdaIslemleri());
        }
        private void btnRezervasyonIslemleri_Click(object sender, EventArgs e)
        {
            LoadUserControl(new FrmRezervasyonIslemleri());
        }
        private void btnFaturalariGoruntule_Click(object sender, EventArgs e)
        {
            LoadUserControl(new FrmFatura());
        }
        private void btnBilgilerimiDuzenle_Click(object sender, EventArgs e)
        {
            LoadUserControl(new FrmBilgiDuzenle());
        }
    }
}
