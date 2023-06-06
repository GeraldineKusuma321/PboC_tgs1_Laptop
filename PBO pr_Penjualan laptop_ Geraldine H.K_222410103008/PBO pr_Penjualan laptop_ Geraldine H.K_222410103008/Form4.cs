using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PBO_pr_Penjualan_laptop__Geraldine_H.K_222410103008.Laptopp;

namespace PBO_pr_Penjualan_laptop__Geraldine_H.K_222410103008
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public DetailTransaksi GetDetailTransaksi(DetailTransaksi detailtransaksi)
        {
            detailtransaksi.Transaksi = txtTransaksi.Text;
            detailtransaksi.LaptopDibeli = txtLaptopyangdibeli.Text;
            detailtransaksi.StokDibeli = int.Parse(txtStokyangcibeli.Text);

            return detailtransaksi;
        }

    }
}
