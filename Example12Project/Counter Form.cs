﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example12Project
{
    public partial class Counter_Form : Form
    {
        public Counter_Form()
        {
            InitializeComponent();
            lblCounter.Text = CounterConfig.Count.ToString();
        }

        private void Counter_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            CounterConfig.Count++;
            lblCounter.Text = CounterConfig.Count.ToString();
            CounterConfig.lblStatus.Text = "Plus";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            CounterConfig.Count--;
            lblCounter.Text = CounterConfig.Count.ToString();
            CounterConfig.lblStatus.Text = "Minus";
        }
    }
}
