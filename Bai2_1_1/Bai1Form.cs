using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_1_1
{
    public partial class Bai1Form : Form
    {
        public Bai1Form()
        {
            InitializeComponent();
        }

        private void rbXanh_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "22000";
        }

        private void rbDo_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "21000";
        }

        private void rbTrang_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "20000";
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int soTien=int.Parse(txtDonGia.Text)*int.Parse(txtSoLuong.Text);
            lblSoTien.Text = soTien.ToString();
        }
    }
}
