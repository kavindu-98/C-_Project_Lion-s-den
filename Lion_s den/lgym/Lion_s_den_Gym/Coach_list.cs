using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lion_s_den_Gym
{
    public partial class Coach_list : UserControl
    {
        //database class object create to acsess database connection
        databaseclass db1 = new databaseclass();
        SqlDataAdapter adapt;
        int s3 = 0;
        public Coach_list()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = db1.getconnection();
                con.Open();
                DataTable dt = new DataTable();

                adapt = new SqlDataAdapter("SELECT coach_id As 'Coach ID', first_name As 'First Name', last_name As 'last Name', rejister_date As 'Registered Date', age As 'Age', nic As 'NIC', mobile_no As 'Mobile No.' ,qualification As 'Qualifications', adress As 'Address' , notes As 'notes' FROM coach_rej where coach_id  LIKE '%" + guna2TextBox6.Text + "%' ", con);
                adapt.Fill(dt);
                guna2DataGridView1.DataSource = dt;
                con.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Database Error", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            label12.Text = "Total count is " + guna2DataGridView1.Rows.Count.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = db1.getconnection();
                con.Open();
                DataTable dt = new DataTable();

                adapt = new SqlDataAdapter("SELECT coach_id As 'Coach ID', fyear As 'Year', fmonth As 'Month', amount As 'Amount' FROM coach_payment where coach_id  LIKE '%" + guna2TextBox6.Text + "%' AND fyear LIKE '%" + guna2TextBox4.Text + "%' AND fmonth LIKE '%" + guna2TextBox5.Text + "%'", con);
                adapt.Fill(dt);
                guna2DataGridView1.DataSource = dt;
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database Error", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            label12.Text ="Total count is "+guna2DataGridView1.Rows.Count.ToString();
        }

        private void label12_Click(object sender, EventArgs e)
        {
           


        }

        private void Coach_list_Load(object sender, EventArgs e)
        {

        }
    }
}
