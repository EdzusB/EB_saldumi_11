﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EB_saldumi_11_G
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void aprekins_Click(object sender, EventArgs e)
        {
            double sk1 = Convert.ToDouble(daudzums.Text);
            double sk2 = 9.88;
            double rezultats = sk1 / sk2;
            daudzums_kg.Text = rezultats.ToString();
        }
    }
}
