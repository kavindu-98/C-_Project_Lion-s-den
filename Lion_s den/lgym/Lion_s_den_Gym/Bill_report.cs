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
    public partial class Bill_report : UserControl
    { //database class object create to acsess database connection
        databaseclass db1 = new databaseclass();
        SqlDataAdapter adapt;
        int s3 = 0;
        public Bill_report()
        {
            InitializeComponent();

            SqlConnection con = db1.getconnection();
            con.Open();
            DataTable dt = new DataTable();

            adapt = new SqlDataAdapter("SELECT bill_no As 'Bill No', purpose As 'Purpose', bill_date As 'Bill Date', amount As 'Amount' FROM bill_payment ", con);
            adapt.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            con.Close();
        }

        private void Bill_report_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = db1.getconnection();
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT bill_no As 'Bill No', purpose As 'Purpose', bill_date As 'Bill Date', amount As 'Amount' FROM bill_payment where bill_no = '" + guna2TextBox4.Text + "'", con);
            adapt.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
