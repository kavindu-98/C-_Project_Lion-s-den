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
    public partial class Members_list : UserControl
    {
        //database class object create to acsess database connection
        databaseclass db1 = new databaseclass();
        SqlDataAdapter adapt;
        int s3 = 0;
        public Members_list()
        {
            InitializeComponent();
            if (seceruty_login_admin_class.formload_fromhome == 4)
            {
                guna2Button3.Show();
            }
            else
            {
                guna2Button3.Hide();
            }
          
        }

        public void complete_payment()
        {

        }
        private void Members_list_Load(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = db1.getconnection();
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT member_id As 'Member ID', package As 'Package', fyear As 'Year', fmonth As 'Month', price As 'Price (Rs)' FROM member_payments where member_id  LIKE '%" + guna2TextBox3.Text + "%' AND fyear LIKE '%" + guna2TextBox1.Text + "%' AND fmonth LIKE '%" + guna2TextBox2.Text + "%'", con);
            adapt.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            con.Close();
            //
            int a = guna2DataGridView1.Rows.Count - 1;
            label6.Text = "Total count is " + a.ToString();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = db1.getconnection();
            con.Open();
            DataTable dt = new DataTable();

            adapt = new SqlDataAdapter("SELECT member_id As 'Member ID', first_name As 'First Name', last_name As 'last Name', rejister_date As 'Registered Date', age As 'Age', nic As 'NIC', weight As 'Weight', height As 'Height', mobile_no As 'Mobile No.' , adress As 'Address' , notes As 'notes'  FROM member_rej where member_id  LIKE '%" + guna2TextBox3.Text + "%' ", con);
            adapt.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            con.Close();
            label6.Text = "Total count is " + guna2DataGridView1.Rows.Count.ToString();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            seceruty_login_admin_class.formload_fromhome = 3;
            guna2Button3.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = db1.getconnection();
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT member_rej.member_id,member_rej.first_name ,member_rej.last_name, mobile_no FROM member_rej WHERE NOT EXISTS(SELECT * FROM member_payments WHERE member_rej.member_id = member_payments.member_id AND member_payments.member_id  LIKE '%" + guna2TextBox3.Text + "%' AND member_payments.fyear LIKE '%" + guna2TextBox1.Text + "%' AND member_payments.fmonth LIKE '%" + guna2TextBox2.Text + "%')", con);
            adapt.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            con.Close();
            label6.Text = "Total count is " + guna2DataGridView1.Rows.Count.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
