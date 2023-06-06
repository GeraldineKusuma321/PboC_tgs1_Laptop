using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PBO_pr_Penjualan_laptop__Geraldine_H.K_222410103008.Laptopp;

namespace PBO_pr_Penjualan_laptop__Geraldine_H.K_222410103008
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        public Laptop GetLaptop(Laptop laptop)
        {
            laptop.Nama = txtNama.Text;
            laptop.Harga = int.Parse(txtHarga.Text);
            laptop.Stok = int.Parse(txtStok.Text);

            return laptop;
        }

    }

}
