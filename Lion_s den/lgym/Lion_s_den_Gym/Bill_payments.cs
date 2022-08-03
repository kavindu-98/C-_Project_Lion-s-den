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
    public partial class Bill_payments : UserControl
    {
        //database class object create to acsess database connection
        databaseclass db1 = new databaseclass();
        SqlDataAdapter adapt;
        //auto create variable
        int s3 = 0;
        //validation
        bool iscorrect = true;
        public Bill_payments()
        {
            InitializeComponent();
            auto_create_values();
            
        }

        public void auto_create_values()
        {   //database id outo increment  code
            String s1;
            //auto increment id value 
            SqlConnection con = db1.getconnection();
            con.Open();
            SqlCommand Comm1 = new SqlCommand("select id from bill_payment WHERE id=(SELECT max(id) FROM bill_payment)", con);
            SqlDataReader DR1 = Comm1.ExecuteReader();
            if (DR1.Read())
            {
                s1 = DR1.GetValue(0).ToString();
                int s2 = Convert.ToInt32(s1);
                s3 = s2 + 1;
            }
            con.Close();
            string currentYear = DateTime.Now.Year.ToString();
            string currentMonth = DateTime.Now.Month.ToString();
            String y2 = ("B" + currentYear + currentMonth+"0" + s3).ToString();
            label2.Text = y2;
            //clear all codes
   
        }

        public void validation()
        {
            //validation variable 
            Regex rname = new Regex("[^A-Za-z]");
            Regex rnic = new Regex("[^A-Z0-9]");
            Regex rmob = new Regex("[^0-9]");
            Regex rnotes = new Regex("[^A-Za-z.,/:0-9]");

            if (rname.IsMatch(guna2TextBox1.Text) || guna2TextBox1.Text == "" || (guna2TextBox1.Text.Length >= 50))
            { //fisrt name
                iscorrect = false;
                label4.Text = "required correct format(max word 50)";
            }
            else
            {

                label4.Text = "..";
            }

            if (rmob.IsMatch(guna2TextBox2.Text) || guna2TextBox2.Text == "" || (guna2TextBox2.Text.Length >= 6))
            {   //nic
                iscorrect = false;
                label6.Text = "required correct format (max word 6)";
            }
            else
            {
                label6.Text = "..";
            }
        }

        public void clearall()
        {
            guna2TextBox1.Clear();
            guna2TextBox2.Clear();
            guna2TextBox4.Clear();
            guna2DateTimePicker1.Value = DateTimePicker.MinimumDateTime;
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            //insert data code -we pass the male as 0 and female as 1 for the database ,
            //because string gives an error insert code to the cheque box from database
            validation();
            if ( iscorrect== true)
            {
                try
                {
                    SqlConnection con = db1.getconnection();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO bill_payment(Id,bill_no,purpose,bill_date,amount) VALUES('" + s3 + "','" + label2.Text + "','" + guna2TextBox1.Text + "','" + guna2DateTimePicker1.Value.Date + "','" + guna2TextBox2.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Insert successfully. bill no is  " + label2.Text + "  Thank you", " ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    con.Close();

                    SqlConnection con1 = db1.getconnection();
                    con1.Open();
                    DataTable dt = new DataTable();
                    adapt = new SqlDataAdapter("SELECT bill_no As 'Bill No', purpose As 'Purpose', bill_date As 'Date', amount As 'Amount' FROM bill_payment where  bill_no LIKE '%" + label2.Text + "%'", con1); ; ;
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con1.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database Error , cheque database connection or input values already there", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               

            }

            iscorrect = true;
            auto_create_values();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            s3 = 0;
            auto_create_values();
            clearall();
            iscorrect = true;
            dataGridView1.DataSource = null;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        { 
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            //update database
            validation();
            if (iscorrect == true && (seceruty_login_admin_class.securitylogin == 0))
            {


                try
                {
                    SqlConnection con = db1.getconnection();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE bill_payment SET purpose='"+guna2TextBox1.Text+"',bill_date='"+guna2DateTimePicker1.Value.Date +"',amount='"+guna2TextBox2.Text+"'WHERE bill_no='"+label2.Text+"'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Updated Successfully!");
                    con.Close();

                    SqlConnection con1 = db1.getconnection();
                    con1.Open();
                    DataTable dt = new DataTable();
                    adapt = new SqlDataAdapter("SELECT bill_no As 'Bill No', purpose As 'Purpose', bill_date As 'Date', amount As 'Amount (Rs)'   FROM bill_payment where  bill_no LIKE '%" + label2.Text + "%'", con1); ; ;
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con1.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error , cheque database connection or input values", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                iscorrect = true;
            }
            else
            {
                //MessageBox.Show("admin acsess only", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label9.Text = "Admin access only !";

            }


        }

        private void Close_Click(object sender, EventArgs e)
        {
            SqlConnection con = db1.getconnection();
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT bill_no As 'Bill No', purpose As 'Purpose', bill_date As 'Date', amount As 'Amount (Rs)' FROM bill_payment where  bill_no = '" + guna2TextBox4.Text + "'", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            SqlConnection con2 = db1.getconnection();
            con2.Open();
            SqlCommand Comm1 = new SqlCommand("SELECT bill_no FROM bill_payment where bill_no LIKE '%" + guna2TextBox4.Text + "%'", con2);
            SqlDataReader DR2 = Comm1.ExecuteReader();
            if (DR2.Read())
            {
                label2.Text = DR2.GetValue(0).ToString();
            }
            con2.Close();
        }

        private void Bill_payments_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            String printdate = DateTime.Now.ToString();
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Bill Report";
            printer.SubTitle ="Bill No "+label2.Text;

            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Lion Den Gym" + printdate;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);
        }
    }
    }
