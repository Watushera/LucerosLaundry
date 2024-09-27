using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaundrySystem;
using MySql.Data.MySqlClient;


namespace LucerosLaundry
{
    public partial class frmcustomer : Form
    {

        GlobalProcedure globalProcedure = new GlobalProcedure();
        string selectedPath;

        public frmcustomer()
        {
            InitializeComponent();
            this.globalProcedure.fncConnectTODatabase();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmcustomer_Load(object sender, EventArgs e)
        {

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdPic = new OpenFileDialog();
            ofdPic.Filter = "Image Files (*.jpg;*.gif;*.bmp)|*.jpg;*.gif;*.bmp";

            if(ofdPic.ShowDialog() == DialogResult.OK)
            {
                picBoxInsert.Image = new Bitmap(ofdPic.FileName);
                selectedPath = ofdPic.FileName;
                picBoxInsert.Image = Image.FromFile(selectedPath);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            MySqlCommand sqlCmd = this.globalProcedure.sqlCommand;

            try
            {
                sqlCmd.Parameters.Clear();
                sqlCmd.CommandText = "procAddCustomer";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@p_fullname", txtfullname.Text);
                sqlCmd.Parameters.AddWithValue("@p_birthdate", dateTimePickerdashboard.Value);
                sqlCmd.Parameters.AddWithValue("@p_gender", cmboxgender.Text);
                sqlCmd.Parameters.AddWithValue("@p_address", txtaddress.Text);
                sqlCmd.Parameters.AddWithValue("@p_contactno", txtnumber.Text);
                sqlCmd.Parameters.AddWithValue("@p_emailadd", txtemail.Text);
                sqlCmd.Parameters.AddWithValue("@p_cust_photo", btninsert.Text);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Customer Profile Added!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed" + ex.Message);
            }

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void genderfemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnreturn_Click(object sender, EventArgs e)
        {

        }
    }
    }

