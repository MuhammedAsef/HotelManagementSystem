using HotelReservationandManagementSystem.DAL;
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
    public partial class FrmFatura : UserControl
    {
        public FrmFatura()
        {
            InitializeComponent();
        }

        private void FrmFatura_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable faturalar = OtelRezDAO.FaturalariGetir();
                dataGridView1.DataSource = faturalar;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
