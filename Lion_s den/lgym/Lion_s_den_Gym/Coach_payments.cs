using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lion_s_den_Gym
{
    public partial class Coach_payments : UserControl
    {
        //database class object create to acsess database connection
        databaseclass db1 = new databaseclass();
        SqlDataAdapter adapt;
        //auto create variable
        int s3 = 0;
        //validation
        bool iscorrect = true;
        public Coach_payments()
        {
            InitializeComponent();
            auto_create_values();
        }

        public void auto_create_values()
        {
            //database id outo increment  code
            String s1;
            //auto increment id value 
            SqlConnection con = db1.getconnection();
            con.Open();
            SqlCommand Comm1 = new SqlCommand("select id from coach_payment WHERE id=(SELECT max(id) FROM coach_payment)", con);
            SqlDataReader DR1 = Comm1.ExecuteReader();
            if (DR1.Read())
            {
                s1 = DR1.GetValue(0).ToString();
                int s2 = Convert.ToInt32(s1);
                s3 = s2 + 1;
            }
            con.Close();
            //set date and time to boxes
            guna2TextBox3.Text = DateTime.Now.Year.ToString();
            guna2ComboBox1.Text = DateTime.Now.Month.ToString();
            //invoice details
            label21.Text = label15.Text;
            Date.Text = DateTime.Now.ToString();


            SqlConnection con1 = db1.getconnection();
            con1.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT coach_id As 'Coach ID', fyear As 'Year', fmonth As 'Month', amount As 'Amount' FROM coach_payment where  coach_id LIKE '%" + label15.Text + "%'AND fyear LIKE '%" + guna2TextBox3.Text + "%' AND fmonth LIKE '%" + guna2ComboBox1.Text + "%'", con1);
            // adapt = new SqlDataAdapter("select * from member_payments WHERE fyear='" + guna2TextBox5.Text + "'AND fmonth='" + guna2TextBox6.Text + "'", con);
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();

            label2.Text = ".";
            label4.Text = ".";
        }

        public void clearall()
        {
            guna2TextBox1.Clear();
            guna2TextBox2.Clear();
            guna2TextBox3.Clear();
            guna2TextBox4.Clear();
            guna2TextBox5.Clear();
            guna2TextBox6.Clear();
            guna2ComboBox1.SelectedItem = null;
            //  guna2DateTimePicker1.Value = DateTimePicker.MinimumDateTime;
            label2.Text = ".";
            label4.Text = ".";

        }
        public void validations()
        { //validation variable 
            Regex rname = new Regex("[^A-Za-z]");
            Regex rnic = new Regex("[^A-Z0-9]");
            Regex rmob = new Regex("[^0-9]");
            Regex rnotes = new Regex("[^A-Za-z.,;9.)/:0-9]$");
            if (label15.Text == "000")
            {
                iscorrect = false;
                MessageBox.Show("Empty Id", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (rmob.IsMatch(guna2TextBox2.Text) || guna2TextBox2.Text == "" || (guna2TextBox2.Text.Length > 10))
            { //fisrt name
                iscorrect = false;
                label4.Text = "Required correct format";
            }
            else
            {
                label4.Text = ".";
            }
            if (rmob.IsMatch(guna2TextBox3.Text) || guna2TextBox3.Text == "" || (guna2TextBox3.Text.Length > 4))
            { //fisrt name
                iscorrect = false;
                label2.Text = "Required correct format";
            }
            else
            {
                label2.Text = ".";
            }
        }
            private void Close_Click(object sender, EventArgs e)
        {
            SqlConnection con = db1.getconnection();
            con.Open();
            SqlCommand Comm1 = new SqlCommand("SELECT coach_id,first_name FROM coach_rej where  coach_id = '" + guna2TextBox4.Text + "'", con);
            SqlDataReader DR1 = Comm1.ExecuteReader();
            if (DR1.Read())
            {
                label15.Text = DR1.GetValue(0).ToString();
                guna2TextBox1.Text = DR1.GetValue(1).ToString();
            }
            con.Close();

            SqlConnection con2 = db1.getconnection();
            con2.Open();
            SqlCommand Comm2 = new SqlCommand("SELECT * FROM coach_payment where  coach_id LIKE '%" + label15.Text + "%' AND fyear ='" + guna2TextBox5.Text + "' AND fmonth ='" + guna2TextBox6.Text + "'", con2);
            SqlDataReader DR2 = Comm2.ExecuteReader();
            if (DR2.Read())
            {

              //guna2ComboBox3.Text = DR2.GetValue(2).ToString();
                guna2TextBox3.Text = DR2.GetValue(2).ToString();
                guna2ComboBox1.Text = DR2.GetValue(3).ToString();
                guna2TextBox2.Text = DR2.GetValue(4).ToString();

            }
            con2.Close();

            SqlConnection con3 = db1.getconnection();
            con3.Open();
            DataTable dt3 = new DataTable();
            adapt = new SqlDataAdapter("SELECT coach_id As 'Coach ID', fyear As 'Year', fmonth As 'Month', amount As 'Amount' FROM coach_payment where  coach_id LIKE '%" + label15.Text + "%' AND fyear LIKE '%" + guna2TextBox5.Text + "%' AND fmonth LIKE '%" + guna2TextBox6.Text + "%'", con3);
            adapt.Fill(dt3);
            dataGridView2.DataSource = dt3;
            con3.Close();

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            s3 = 0;
            auto_create_values();
            clearall();
            iscorrect = true;
        //    dataGridView1.DataSource = null;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           int rowcount = dataGridView2.Rows.Count; // returns gridview raw count
            if (rowcount == 0)
            {
                MessageBox.Show("Empty table cannot print", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String printdate = DateTime.Now.ToString();
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Coach Fee Invoice";
                printer.SubTitle = "Mr/Ms " + guna2TextBox1.Text + "  Coach ID - " + label15.Text;
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "Lion Dem Gym" + printdate;
                printer.FooterSpacing = 15;
          //      printer.PrintDataGridView(dataGridView1);
            }
        }

        private void Coach_payments_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            //insert data code -we pass the male as 0 and female as 1 for the database ,
            //because string gives an error insert code to the cheque box from database
            //cheque validation is ok
            validations();
            if (iscorrect == true)
            {
                try
                {
                    SqlConnection con = db1.getconnection();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO coach_payment(Id,coach_id,fyear,fmonth,amount) VALUES('" + s3 + "','" + label15.Text + "','" + guna2TextBox3.Text + "','" + guna2ComboBox1.SelectedItem + "','" + guna2TextBox2.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Done your payment  Thank you", " ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error , cheque database connection or input values", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //dont use clear all beacuse print perpose
            }
            //auto increment and reset values
            s3 = 0;
            iscorrect = true;
            auto_create_values();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

            //delete database
            if (seceruty_login_admin_class.securitylogin == 0)
            {
                try
            {
                SqlConnection con = db1.getconnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE from coach_payment WHERE coach_id = '" + label15.Text + "'AND fyear = '" + guna2TextBox3.Text + "'AND fmonth = '" + guna2ComboBox1.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete successfully.  " + label15.Text + " is no will longer available. Thank you", " ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                con.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Database Error , cheque database connection or input relevent values", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clearall();
            //auto increment and reset values
            s3 = 0;
            auto_create_values();
        }
               else
            {
                //MessageBox.Show("admin acsess only", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label7.Text = "Admin access only !";
            }
        }
    }
}
