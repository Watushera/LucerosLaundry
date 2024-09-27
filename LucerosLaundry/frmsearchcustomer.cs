using LaundrySystem;
using MySql.Data.MySqlClient;
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
    public partial class frmsearchcustomer : Form
    {
        frmcustomer cust = new frmcustomer();
        GlobalProcedure g_proc = new GlobalProcedure();
        int row;

        public frmsearchcustomer()
        {
            InitializeComponent();
            g_proc.fncConnectTODatabase();
            DisplayAllCustomer();
        }

        public void DisplayAllCustomer()
        {
            try
            {
                g_proc.sqlLaundryAdapter = new MySqlDataAdapter();
                g_proc.datLaundry = new DataTable();

                g_proc.sqlCommand.Parameters.Clear();
                g_proc.sqlCommand.CommandText = "procDisplayAllcustomer";
                g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                g_proc.sqlLaundryAdapter.SelectCommand = g_proc.sqlCommand;
                g_proc.datLaundry.Clear();
                g_proc.sqlLaundryAdapter.Fill(g_proc.datLaundry);
                if (g_proc.datLaundry.Rows.Count > 0)
                {
                    row = 0;
                    lblTotal.Text = "Total: " + (Convert.ToString(g_proc.datLaundry.Rows.Count));
                    datagridvalue.RowCount = g_proc.datLaundry.Rows.Count;
                    while (!(g_proc.datLaundry.Rows.Count - 1 < row))
                    {
                        datagridvalue.Rows[row].Cells[0].Value = g_proc.datLaundry.Rows[row]["id"].ToString();
                        datagridvalue.Rows[row].Cells[1].Value = g_proc.datLaundry.Rows[row]["fullname"].ToString();
                        datagridvalue.Rows[row].Cells[2].Value = Convert.ToDateTime(g_proc.datLaundry.Rows[row]["birthdate"].ToString()).ToShortDateString();
                        datagridvalue.Rows[row].Cells[3].Value = g_proc.datLaundry.Rows[row]["gender"].ToString();
                        datagridvalue.Rows[row].Cells[4].Value = g_proc.datLaundry.Rows[row]["address"].ToString();
                        datagridvalue.Rows[row].Cells[5].Value = g_proc.datLaundry.Rows[row]["contactno"].ToString();
                        datagridvalue.Rows[row].Cells[6].Value = g_proc.datLaundry.Rows[row]["emailadd"].ToString();
                        row++;
                    }
                }
                else
                {
                    MessageBox.Show("Record not Found!", "Records", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                g_proc.sqlLaundryAdapter.Dispose();
                g_proc.datLaundry.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

    
    public void searchCustomer(string v_name)
    {

        try
        {
            g_proc.sqlLaundryAdapter = new MySqlDataAdapter();
            g_proc.datLaundry = new DataTable();

            g_proc.sqlCommand.Parameters.Clear();
            g_proc.sqlCommand.CommandText = "procSearchCustomer";
            g_proc.sqlCommand.CommandType = CommandType.StoredProcedure;
                g_proc.sqlCommand.Parameters.AddWithValue("@p_search", v_name);
                g_proc.sqlLaundryAdapter.SelectCommand = g_proc.sqlCommand;
            g_proc.datLaundry.Clear();
            g_proc.sqlLaundryAdapter.Fill(g_proc.datLaundry);
            if (g_proc.datLaundry.Rows.Count > 0)
            {
                row = 0;
                lblTotal.Text = "Total: " + (Convert.ToString(g_proc.datLaundry.Rows.Count));
                datagridvalue.RowCount = g_proc.datLaundry.Rows.Count;
                while (!(g_proc.datLaundry.Rows.Count - 1 < row))
                {
                    datagridvalue.Rows[row].Cells[0].Value = g_proc.datLaundry.Rows[row]["id"].ToString();
                    datagridvalue.Rows[row].Cells[1].Value = g_proc.datLaundry.Rows[row]["fullname"].ToString();
                    datagridvalue.Rows[row].Cells[2].Value = Convert.ToDateTime(g_proc.datLaundry.Rows[row]["birthdate"].ToString()).ToShortDateString();
                    datagridvalue.Rows[row].Cells[3].Value = g_proc.datLaundry.Rows[row]["gender"].ToString();
                    datagridvalue.Rows[row].Cells[4].Value = g_proc.datLaundry.Rows[row]["address"].ToString();
                    datagridvalue.Rows[row].Cells[5].Value = g_proc.datLaundry.Rows[row]["contactno"].ToString();
                    datagridvalue.Rows[row].Cells[6].Value = g_proc.datLaundry.Rows[row]["emailadd"].ToString();
                    row++;
                }
            }
            else
            {
                MessageBox.Show("Record not Found!", "Records", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            g_proc.sqlLaundryAdapter.Dispose();
            g_proc.datLaundry.Dispose();

        }
        catch (Exception ex)
        {
            MessageBox.Show("" + ex.Message);
        }
    }
        public void datagridvalue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void btnsearch_Click(object sender, EventArgs e)
        {
            searchCustomer(txtsearch.Text);
        }

        private void btnedit_Click(object sender, EventArgs e)
        {

        }
    }
    }


