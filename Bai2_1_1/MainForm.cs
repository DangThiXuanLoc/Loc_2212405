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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tsmlBai1_Click(object sender, EventArgs e)
        {
            var form =new Bai1Form();
            form.ShowDialog();
        }

        private void tsmlBai2_Click(object sender, EventArgs e)
        {
            var form = new Bai2Form();
            form.ShowDialog();
        }

        private void tsmlBai3_Click(object sender, EventArgs e)
        {

            var form = new Bai3Form();
            form.ShowDialog();
        }

        private void tsmiBai4_Click(object sender, EventArgs e)
        {
            var form = new Bai4Form();
            form.ShowDialog();

        }
    }
}
