using gym;
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
    public partial class Suppliment_repot : UserControl
    { //database class object create to acsess database connection
        databaseclass db1 = new databaseclass();
        SqlDataAdapter adapt;
        int s3 = 0;
        public Suppliment_repot()
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = db1.getconnection();
            con.Open();
            DataTable dt = new DataTable();

            adapt = new SqlDataAdapter("SELECT suppliment_id As 'Supplement ID', member_id As 'Member ID', date As 'Date', price As 'Price (Rs)' FROM suppliment_payment where suppliment_id LIKE '%" + guna2TextBox6.Text + "%' AND YEAR(date)  LIKE '%" + guna2TextBox4.Text + "%' AND MONTH(date)  LIKE '%" + guna2TextBox5.Text + "%'", con);
            adapt.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            con.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = db1.getconnection();
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT suppliment_id As 'Supplement ID', name As 'Name', amount As 'Amount (Rs)', description As 'Description' FROM suppliment_id ", con);
            adapt.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            con.Close();

        }

        private void Suppliment_repot_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
         
            this.Hide();
            seceruty_login_admin_class.formload_fromhome = 3;
            guna2Button3.Hide();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
