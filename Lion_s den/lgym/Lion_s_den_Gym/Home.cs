using Lion_s_den_Gym;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gym
{
    public partial class Home : UserControl
    {

        // SqlConnection con = new SqlConnection("Server=DESKTOP-VNPDKN3;Database=Database1.mdf;Trusted_Connection=true");
        databaseclass db1 = new databaseclass();
        SqlCommand cmd;
        SqlDataAdapter adapt;
        String labe;
        public Home()
        {
            InitializeComponent();
            //login name
            label4.Text = seceruty_login_admin_class.name;

            SqlConnection con1 = db1.getconnection();
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("reminder_data");
            cmd1.Parameters.AddWithValue("@StatementType", "Select_reminder_1");
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Connection = con1;
            SqlDataReader DR1 = cmd1.ExecuteReader();
            if (DR1.Read())
            {
            String s1 = DR1.GetValue(0).ToString();
                label18.Text = s1;
                label17.Text = "01";
            }
            con1.Close();

            SqlConnection con2 = db1.getconnection();
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("reminder_data");
            cmd2.Parameters.AddWithValue("@StatementType", "Select_reminder_1_note");
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Connection = con2;
            SqlDataReader DR2 = cmd2.ExecuteReader();
            if (DR2.Read())
            {
                String s5 = DR2.GetValue(0).ToString();
                guna2TextBox3.Text = s5;
                con2.Close();

            }

            SqlConnection con3 = db1.getconnection();
            con3.Open();
            SqlCommand cmd3 = new SqlCommand("select count(member_id) from member_rej", con3);
            SqlDataReader DR3 = cmd3.ExecuteReader();
            if (DR3.Read())
            {
                label12.Text = DR3.GetValue(0).ToString();
            }
            con3.Close();

            SqlConnection con4 = db1.getconnection();
            con4.Open();
            SqlCommand cmd4= new SqlCommand("select count(coach_id) from coach_rej", con4);
            SqlDataReader DR4 = cmd4.ExecuteReader();
            if (DR4.Read())
            {
                label11.Text = DR4.GetValue(0).ToString();
            }
            con4.Close();

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // label2.Text = DateTime.Now.ToString("HH:mm:ss");
           // label3.Text = DateTime.Now.ToString("dddd, MMMM d");
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {

                Double g = Convert.ToDouble(guna2TextBox1.Text);
                Double m = Convert.ToDouble(guna2TextBox2.Text);
                Double z = g / ((m * m) / 10000);
                Double dc = Math.Round((Double)z, 2);
                string myString = dc.ToString();
                guna2TextBox8.Text = myString;
            }
            catch
            {
                guna2TextBox8.Text = "";
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                Double g = Convert.ToDouble(guna2TextBox1.Text);
                Double m = Convert.ToDouble(guna2TextBox2.Text);
                Double z = g / ((m * m) / 10000);
                Double dc = Math.Round((Double)z, 2);
                string myString = dc.ToString();
                guna2TextBox8.Text = myString;
            }
            catch
            {
                guna2TextBox8.Text = "";
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            seceruty_login_admin_class.formload_fromhome = 4;
            Suppliment_repot myUC1 = new Suppliment_repot();
            Controls.Add(myUC1);
            myUC1.BringToFront();
           

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            seceruty_login_admin_class.formload_fromhome = 4;
            Members_list myUC1 = new Members_list();
            Controls.Add(myUC1);
            myUC1.BringToFront();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            seceruty_login_admin_class.formload_fromhome = 4;
            reminder myUC1 = new reminder();
            Controls.Add(myUC1);
            myUC1.BringToFront();
        }

        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            seceruty_login_admin_class.formload_fromhome = 4;
            Members_list myUC1 = new Members_list();
            Controls.Add(myUC1);
            myUC1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
