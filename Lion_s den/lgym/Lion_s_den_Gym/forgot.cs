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
    public partial class forgot : Form
    {
        databaseclass db1 = new databaseclass();
        SqlCommand cmd;
        SqlDataAdapter adapt;
        bool iscorrect=true;
    
        public forgot()
        {
            InitializeComponent();
        }

        public void clearall()
        {
            guna2TextBox1.Clear();
            guna2TextBox2.Clear();
            guna2TextBox3.Clear();
            guna2TextBox4.Clear();
            label1.Text = ".";
            label2.Text = ".";
            label3.Text = ".";
            label4.Text = ".";
            label5.Text = ".";
            label6.Text = ".";
        }
        public void validations()
        { //validation variable 
            Regex rname = new Regex("[^A-Za-z]");
            Regex rnic = new Regex("[^A-Z0-9]");
            Regex rmob = new Regex("[^0-9]");
            Regex rnotes = new Regex("[^A-Za-z.,;9.)/:0-9]$");

            if (guna2TextBox3.Text =="")
            { //fisrt name
                iscorrect = false;
                label1.Text = "cannot empty";
            }
           
            if (guna2TextBox4.Text == "")
            {   //last name
                iscorrect = false;
                label4.Text = "cannot empty";
            }
          
            if (label5.Text == "")
            {   //last name
                iscorrect = false;
                label1.Text = "cannot empty";
            }
            if (label4.Text != "correct")
            {   //last name
                iscorrect = false;
                label4.Text = "invalid answer";
            }
            if (rmob.IsMatch(guna2TextBox1.Text) || guna2TextBox1.Text == "" )
            {   //nic
                iscorrect = false;
                label2.Text = "required correct format (max word 10)";
            }
            else
            {
                label2.Text = "..";
            }
            if (rmob.IsMatch(guna2TextBox2.Text) || guna2TextBox2.Text == "")
            {   //nic
                iscorrect = false;
                label3.Text = "required correct format (max word 10)";
            }
            else
            {
                label3.Text = "..";
            }
            if(guna2TextBox1.Text!= guna2TextBox2.Text)
            {
                label3.Text = "conform password not match with new password";
            }
        }
            private void ad_sign_btn_Click(object sender, EventArgs e)
        {
                    
        }
            private void forgot_Load(object sender, EventArgs e)
        {

        }

        private void ad_log_back_btn_Click(object sender, EventArgs e)
        {
            user_login f7 = new user_login();
            f7.Show();
            this.Hide();
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "use correct username";
            //database id outo increment  code          
            //auto increment id value        
            SqlConnection con = db1.getconnection();
            con.Open();
            SqlCommand Comm1 = new SqlCommand("select question  from user_con WHERE username='" + guna2TextBox3.Text + "'", con);
            SqlDataReader DR1 = Comm1.ExecuteReader();
            if (DR1.Read())
            {
                label5.Text = DR1.GetValue(0).ToString();
                label1.Text = ".";
            }
            con.Close();
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void guna2TextBox4_TextChanged_1(object sender, EventArgs e)
        {
            label4.Text = "use correct answer";
            //database id outo increment  code          
            //auto increment id value        
            SqlConnection con2 = db1.getconnection();
            con2.Open();
            SqlCommand Comm2 = new SqlCommand("select anser  from user_con WHERE anser='" + guna2TextBox4.Text + "'", con2);
            SqlDataReader DR2 = Comm2.ExecuteReader();
            if (DR2.Read())
            {
                label6.Text = DR2.GetValue(0).ToString();
                if (label6.Text != "")
                {
                    label4.Text = "correct";
                }
            }
            con2.Close();
        }

        private void ad_sign_btn_Click_1(object sender, EventArgs e)
        {
            //update database
            //cheque validation is ok
            validations();
            if (iscorrect == true)
            {             
                try
                {
                    SqlConnection con = db1.getconnection();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE user_con SET passwor='" + guna2TextBox1.Text + "'WHERE username = '" + guna2TextBox3.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Coach Password Reset Successful !", " " , MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    con.Close();
                    
                    user_login us1 = new user_login();
                    us1.Show();
                    this.Close();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Database Error , cheque database connection or input values", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                clearall();
            }
            //auto increment and reset values
         
            iscorrect = true;
           



        }
    }
}
