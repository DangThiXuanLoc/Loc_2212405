﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void rbNam_CheckedChanged(object sender, EventArgs e)
        {
            if(rbNam.Checked)
            MessageBox.Show("Bạn chọn giơi tính Nam", "Thông báo");
        }

        private void rbNu_CheckedChanged(object sender, EventArgs e)
        {
            if(rbNu.Checked)
            MessageBox.Show("Bạn chọn giơi tính Nữ", "Thông báo");
        }

        private void btnToMau_Click(object sender, EventArgs e)
        {
            if (rbDo.Checked)
                txtHopMau.BackColor = Color.Red;
            else
                txtHopMau.BackColor= Color.Green;   
        }
    }
}
