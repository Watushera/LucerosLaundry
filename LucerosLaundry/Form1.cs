using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LucerosLaundry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbllogininfo_Click(object sender, EventArgs e)
        {

        }

      

        private void btnlogin_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            this.Hide();
            dashboard.ShowDialog();
            this.Close();

        }
    }
}
