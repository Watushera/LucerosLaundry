using LaundrySystem;
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
    public partial class frmeditcustomer : Form
    {
        private int selectedRowIndex = -1;
        private int CustomerId { get; set; }
        public string FullName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public string EmailAddress { get; set; }

        private GlobalProcedure proc;
        public frmeditcustomer(int customer_id, string fullName, DateTime birthdate, string gender, string address, string contactNo,
    string emailAddress)
        {
            InitializeComponent();
            proc = new GlobalProcedure();
            proc.fncConnectTODatabase();
            CustomerId = customer_id;
            txtfullname.Text = fullName;
            dateTimePickerdashboard.Value = birthdate;
            // Set the ComboBox's value based on gender
            if (gender == "Male")
                cmboxgender.SelectedItem = "Male";
            else if (gender == "Female")
                cmboxgender.SelectedItem = "Female";
            txtaddress.Text = address;
            txtnumber.Text = contactNo;
            txtemail.Text = emailAddress;
        }

        public void procUpdateCustomer(int id)
        {
            try
            {
                proc.sqlCommand.Parameters.Clear();
                proc.sqlCommand.CommandText = "procUpdateCustomer";
                proc.sqlCommand.CommandType = CommandType.StoredProcedure;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void procEditCustomer()
        {
            try
            {
                proc.sqlCommand.Parameters.Clear();
                proc.sqlCommand.CommandText = "procEditCustomer";
                proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                proc.sqlCommand.Parameters.AddWithValue("@p_id", CustomerId);
                proc.sqlCommand.Parameters.AddWithValue("@p_fullname", FullName);
                proc.sqlCommand.Parameters.AddWithValue("@p_birthdate", Birthdate);
                proc.sqlCommand.Parameters.AddWithValue("@p_gender", Gender);
                proc.sqlCommand.Parameters.AddWithValue("@p_address", Address);
                proc.sqlCommand.Parameters.AddWithValue("@p_contactno", ContactNo);
                proc.sqlCommand.Parameters.AddWithValue("@p_emailadd", EmailAddress);
                proc.sqlCommand.Parameters.AddWithValue("@p_cust_photo", "");
                proc.sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Record updated successfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }



        private void frmeditcustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            FullName = txtfullname.Text;
            Birthdate = dateTimePickerdashboard.Value;
            Gender = cmboxgender.SelectedItem.ToString();
            Address = txtaddress.Text;
            ContactNo = txtnumber.Text;
            EmailAddress = txtemail.Text;

            DialogResult = DialogResult.OK;  
            procEditCustomer();
            Close();
        }
    }
}
