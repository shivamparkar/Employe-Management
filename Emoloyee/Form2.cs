using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Emoloyee
{
    public partial class Form2 : Form
    {
         //Enter Your Database Creds Here
        SqlConnection con = new SqlConnection("");

        private Form parentForm;
        public Form2(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }


        private void label2_Click(object sender, EventArgs e)
        {
            FetchAndDisplayData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //string selectedPhoneNumber = textBox1.Text;
            FetchAndDisplayData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string name = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                string code = dataGridView1.Rows[e.RowIndex].Cells["Code"].Value.ToString();
                string year = dataGridView1.Rows[e.RowIndex].Cells["Year"].Value.ToString();
                string salary = dataGridView1.Rows[e.RowIndex].Cells["Salary"].Value.ToString();

                string rowData = $"Name: {name}, Code: {code}, Year: {year}, Salary: {salary}";
                MessageBox.Show(rowData, "Selected Row Data");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FetchAndDisplayData();
        }

        private void FetchAndDisplayData()
        {
            string selectedDate = dateTimePicker1.Value.ToShortDateString();
            //string selectedPhoneNumber = label2.Text;
            string selectedPhoneNumber = textBox1.Text;


            string query = $"SELECT Name, Code, Year, Salary FROM Employee WHERE Year = '{selectedDate}' AND PhoneNumber = '{selectedPhoneNumber}'";

            DataTable dataTable = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    if (con != null)
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dataTable);
                        if (dataTable.Columns.Count > 0 && dataTable !=null)
                        {
                            dataGridView1.DataSource = dataTable;
                        }
                        else
                        {
                            string err = "no data available";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Something is wrong");
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                string err = ex.Message.ToString();
            }
        }


    }
}
