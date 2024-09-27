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
    public partial class dashboard : Form
    {
        private Color staticColor;
        private Form activeForm;
        public dashboard()
        {
            InitializeComponent();
            
        }
        private Color SelectColorBtn()
        {
            return staticColor;

        }
        private void SetButtonColor(Button btn)
        {
            btn.BackColor = SelectColorBtn();
        }
        private void OpenChildForm(Form childform, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.paneldashboardoutput.Controls.Add(childform);
            this.paneldashboardoutput.Tag = childform;
            childform.BringToFront();
            childform.Show();
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LucerosLaundry.frnservice(), sender);
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {

            OpenChildForm(new LucerosLaundry.frmcustomer(), sender);

        }

       

        private void btndashboardgarments_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LucerosLaundry.frmgarments(), sender);
        }

        private void btnsearchcustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LucerosLaundry.frmsearchcustomer(), sender);
        }

        private void btnstaff_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LucerosLaundry.frmstaff(), sender);
        }

        private void btnprofile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LucerosLaundry.frmProfilecs(), sender);
        }

        private void paneldashboardoutput_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

