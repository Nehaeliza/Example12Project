using System;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            CounterConfig.lblStatus = lblStatus;
        }
        private Counter_Form counterConfig = new Counter_Form();
        private Extended_Form extendedForm = new Extended_Form();
        private void mnuSimple_Click(object sender, EventArgs e)
        {
            //counterConfig.MdiParent = this; 
            //counterConfig.Show; 
            CounterConfig.ShowChild(this,counterConfig);
        }

        private void mnuExtended_Click(object sender, EventArgs e)
        {
            CounterConfig.ShowChild(this, extendedForm);

        }
    }
}
