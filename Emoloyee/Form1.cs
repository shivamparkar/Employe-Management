using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;
using System.Collections;

namespace Emoloyee
{
    public partial class Form1 : Form
    {

        //string conn = ConfigurationManager.ConnectionStrings();
        SqlConnection con = new SqlConnection("data source=DESKTOP-IEPVL3O\\SQLEXPRESS; database=Project; uid=sa; password=Shivam123;");
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Enter_Salary_TextChanged(object sender, EventArgs e)
        {

        }

        private void Select_Yeat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private int additionalFieldsCount = 0;

        //private List<Label> labels = new List<Label>();
        //private List<TextBox> textBoxes = new List<TextBox>();


        private TextBox Phone;
        private TextBox Email;
        private ComboBox Role;
        private ComboBox Deparement;


        private void button1_Click(object sender, EventArgs e)
        {
            additionalFieldsCount++;

            Label label1 = new Label();
            label1.Text = "Phone Number";
            label1.Location = new Point(125 + additionalFieldsCount * 30, 270);
            label1.Size = new Size(100, 20);

            Phone = new TextBox();
            Phone.Name = "Phone Number" + additionalFieldsCount.ToString();
            Phone.Location = new Point(125 + additionalFieldsCount * 30, 290);
            Phone.Size = new Size(100, 20);

            Label label2 = new Label();
            label2.Text = "Email ID";
            label2.Location = new Point(240 + additionalFieldsCount * 30, 270);
            label2.Size = new Size(100, 20);

            Email = new TextBox();
            Email.Name = "Email ID" + additionalFieldsCount.ToString() + "_2";
            Email.Location = new Point(240 + additionalFieldsCount * 30, 290);
            Email.Size = new Size(100, 20);

            Label label3 = new Label();
            label3.Text = "Role";
            label3.Location = new Point(350 + additionalFieldsCount * 30, 270);
            label3.Size = new Size(100, 20);

            Role = new ComboBox();
            Role.Name = "Role" + additionalFieldsCount.ToString();
            Role.Location = new Point(350 + additionalFieldsCount * 30, 290);
            Role.Size = new Size(100, 20);

            List<string> roleDataList = FetchRoleDataFromDatabase();
            Role.DataSource = roleDataList;


            Label label4 = new Label();
            label4.Text = "Department";
            label4.Location = new Point(460 + additionalFieldsCount * 30, 270);
            label4.Size = new Size(100, 20);

            Deparement = new ComboBox();
            Deparement.Name = "Department" + additionalFieldsCount.ToString();
            Deparement.Location = new Point(460 + additionalFieldsCount * 30, 290);
            Deparement.Size = new Size(100, 20);

            List<string> DeparmentList = FetchDeparment();
            Deparement.DataSource = DeparmentList;




            this.Controls.Add(label1);
            this.Controls.Add(Phone);

            this.Controls.Add(label2);
            this.Controls.Add(Email);

            this.Controls.Add(label3);
            this.Controls.Add(Role);

            this.Controls.Add(label4);
            this.Controls.Add(Deparement);


        }

        private List<string> FetchRoleDataFromDatabase()
        {
            List<string> roles = new List<string>();

            con.Open();
            string query = "SELECT RoleName FROM Role";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    //con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    //con.Close();

                    while (reader.Read())
                    {
                        roles.Add(reader["RoleName"].ToString());
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                string err = ex.Message.ToString();
                MessageBox.Show(err);
            }

            return roles;
        }


        private List<string> FetchDeparment()
        {
            List<string> Department = new List<string>();

            con.Open();
            string query = "SELECT DepartmentName FROM Department";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    SqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        Department.Add(reader["DepartmentName"].ToString());
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                string err = ex.Message.ToString();
                MessageBox.Show(err);
            }

            return Department;

        }





        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            //string query = $"insert into Employee(@Name, @Code, @Year, @Salary, @RoleID, @DepartmentID, @Email, @PhoneNumber)";

            string query = "INSERT INTO Employee (Name, Code, [Year], Salary, Role, Department, Email, PhoneNumber) " +
               "VALUES (@Name, @Code, @Year, @Salary, @Role, @Department, @Email, @PhoneNumber)";


            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Code", textBox2.Text);
            //cmd.Parameters.AddWithValue("@Year", dateTimePicker1.Text);
            cmd.Parameters.Add("@Year", SqlDbType.DateTime).Value = dateTimePicker1.Value;
            cmd.Parameters.AddWithValue("@Salary", SalaryDetails.Text);
            cmd.Parameters.AddWithValue("@Role", Role.Text);
            cmd.Parameters.AddWithValue("@Department", Deparement.Text);
            cmd.Parameters.AddWithValue("@Email", Email.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", Phone.Text);


            try
            {
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                con.Close();

                if (rows > 0) 
                {
                   
                        MessageBox.Show("Your Recorded Save Successfully");
                        this.Hide();
                        Form2 f2 = new Form2(this);
                        f2.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Please Check your enteries");
                }

            }
            catch (Exception ex)
            {
                string err = ex.Message.ToString();
                MessageBox.Show("Oops Something went Wrong");
            }



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
        }

        void reset()
        {
            textBox1.Clear();
            textBox2.Clear();
            SalaryDetails.ClearSelected();
            Email.Clear();
            Phone.Clear();
            dateTimePicker1.Value = DateTime.Now;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                reset();
            }
            catch (Exception ex)
            {
                string err = ex.Message.ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        //private void OpenForm2()
        //{
        //    // Create an instance of Form2 and pass the current form as a parameter
        //    Form2 form2 = new Form2(this);

        //    // Show Form2
        //    form2.Show();

        //    // Hide Form1
        //    this.Hide();
        //}
        //private void buttonOpenForm2_Click(object sender, EventArgs e)
        //{
        //    OpenForm2(); // Call the method to open Form2
        //}


    }
}
