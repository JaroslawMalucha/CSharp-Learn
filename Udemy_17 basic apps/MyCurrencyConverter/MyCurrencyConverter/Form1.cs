﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCurrencyConverter
{
    public partial class frmCurrencyConverter : Form
    {
        public frmCurrencyConverter()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.co.uk/finance/converter");
        }
    }
}
