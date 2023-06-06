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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        public Transaksi GetTransaksi(Transaksi transaksi)
        {
            transaksi.Nama = txtnamalaptop.Text;
            transaksi.IdentitasTransaksi = txttidentitastransaksi.Text;

            return transaksi;
        }
    }
}
