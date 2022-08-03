using DGVPrinterHelper;
using Lion_s_den_Gym;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace gym
{
    public partial class Schedule : UserControl
    {
        //database class object create to acsess database connection
        databaseclass db1 = new databaseclass();
        SqlDataAdapter adapt;
        //validation
        bool iscorrect = true;
        int s3 = 0;
        public Schedule()
        {
            InitializeComponent();
            SqlConnection con = db1.getconnection();
            try
            {
                con.Open();
                label6.Text = "Connection-OK";
                con.Close();

            }
            catch
            {
                label6.Text = "Connection-Error";
            }
            auto_create_values();
        }

        public void auto_create_values()
        {   //database id outo increment  code
            String s1;
           
            //auto increment id value 
            SqlConnection con = db1.getconnection();
            con.Open();
            SqlCommand Comm1 = new SqlCommand("select id from shedule WHERE id=(SELECT max(id) FROM shedule)", con);
            SqlDataReader DR1 = Comm1.ExecuteReader();
            if (DR1.Read())
            {
                s1 = DR1.GetValue(0).ToString();
                int s2 = Convert.ToInt32(s1);
                s3 = s2 + 1;
            }
            con.Close();


            SqlConnection con3 = db1.getconnection();
            con3.Open();
            DataTable dt3 = new DataTable();
            adapt = new SqlDataAdapter("select member_id As 'Member ID',excercise As 'Exercise Name',sets As 'Set',reps As 'Reps',rest_time As 'Rest Time' from shedule where  member_id LIKE '%" + label15.Text + "%' OR excercise_no LIKE '%" + label12.Text + "%' ", con3);
            adapt.Fill(dt3);
            guna2DataGridView1.DataSource = dt3;
            con3.Close();


            Date.Text= DateTime.Now.ToString();
            label15.Text = ".";
            label18.Text = ".";
            label19.Text = ".";
            label20.Text = ".";
            label21.Text = ".";

           
        }

       public void  clearall()
        {
            guna2TextBox1.Clear();
            guna2TextBox9.Clear();
            //guna2TextBox3.Clear();
            guna2TextBox4.Clear();
            guna2TextBox5.Clear();
            guna2TextBox6.Clear();
            guna2TextBox9.Clear();
            guna2DateTimePicker1.Value = DateTime.Now;

            label18.Text = ".";
            label19.Text = ".";
            label20.Text = ".";
            label21.Text = ".";
            label12.Text = "1";
                



        }

        public void validations()
        { //validation variable 
            Regex rname = new Regex("[^A-Za-z]");
            Regex rnic = new Regex("[^A-Z0-9]");
            Regex rmob = new Regex("[^0-9]");
            Regex rnotes = new Regex("[^A-Za-z.,;9.)/:0-9]$");
            if (label15.Text == ".")
            {
                iscorrect = false;
                MessageBox.Show("Invalied Id ,enter your Id no using serch box.", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (rnotes.IsMatch(guna2TextBox9.Text) || guna2TextBox9.Text == "" || (guna2TextBox9.Text.Length > 50))
            { //fisrt name
                iscorrect = false;
                label18.Text = "Required correct format";
            }
            else
            {

                label18.Text = ".";
            }
            if (rmob.IsMatch(guna2TextBox5.Text) || guna2TextBox5.Text == "" || (guna2TextBox5.Text.Length > 4))
            {   //nic
                iscorrect = false;
                label19.Text = "Required correct format (maximum words 4)";
            }
            else
            {
                label19.Text = ".";
            }
            if (rmob.IsMatch(guna2TextBox6.Text) || guna2TextBox6.Text == "" || (guna2TextBox6.Text.Length > 4))
            {   //nic
                iscorrect = false;
                label20.Text = "required correct format (maximum words 4)";
            }
            else
            {
                label20.Text = ".";
              
            }
            if (rmob.IsMatch(guna2TextBox1.Text) || guna2TextBox1.Text == "" || (guna2TextBox1.Text.Length > 4))
            {   //nic
                iscorrect = false;
                label21.Text = "required correct format (maximum words 4)";
            }
            else
            {
                label21.Text = ".";

            }
        }
            private void timer1_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToString("yyyy, MM, d");
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            s3 = 0;        
            auto_create_values();
            clearall();
            iscorrect = true;
            guna2DataGridView1.DataSource = null;
        }

        private void Schedule_Load(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            int s4 = 0;
            label12.Text = "1";
            

            SqlConnection con = db1.getconnection();
            con.Open();
            SqlCommand Comm1 = new SqlCommand("SELECT member_id ,first_name FROM member_rej where  member_id ='" + guna2TextBox4.Text + "'", con);
            SqlDataReader DR1 = Comm1.ExecuteReader();
            if (DR1.Read())
            {
                label15.Text = DR1.GetValue(0).ToString();
                label7.Text = DR1.GetValue(1).ToString();
            }
            con.Close();

            SqlConnection con2 = db1.getconnection();
            con2.Open();
            SqlCommand Comm2 = new SqlCommand("select excercise_no from shedule WHERE excercise_no=(SELECT max(excercise_no) FROM shedule where member_id='"+ label15.Text+"')", con2);
            SqlDataReader DR2 = Comm2.ExecuteReader();
            if (DR2.Read())
            {
                String s1;

                s1 = DR2.GetValue(0).ToString();
                int s2 = Convert.ToInt32(s1);
                if (s2 >=1)
                {
                    s4 = s2 + 1;
                }
                else
                {
                    s4 =  1;
                }
                label12.Text = s4.ToString();
            }
            con2.Close();

            SqlConnection con3 = db1.getconnection();
            con3.Open();
            DataTable dt3 = new DataTable();
            adapt = new SqlDataAdapter("select member_id As 'Member ID',excercise As 'Exercise Name',sets As 'Set',reps As 'Reps',rest_time As 'Rest Time' from shedule where  member_id LIKE '%" + label15.Text + "%' OR excercise_no LIKE '%" + label12.Text + "%' ", con3);
            adapt.Fill(dt3);
            guna2DataGridView1.DataSource = dt3;
            con3.Close();
            //     MessageBox.Show("Successfully!");

            s4 = 0;

            //memid and name

            label4.Text = label15.Text;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            //insert data code -we pass the male as 0 and female as 1 for the database ,
            //because string gives an error insert code to the cheque box from database
            validations();
            if (iscorrect == true)
            {
                try
                {
                    SqlConnection con = db1.getconnection();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO shedule(id,member_id,excercise_no,excercise,sets,reps,rest_time,date) VALUES('" + s3 + "','" + label15.Text + "','" + label12.Text + "','" + guna2TextBox9.Text + "','" + guna2TextBox5.Text + "','" + guna2TextBox6.Text + "','" + guna2TextBox1.Text + "','" + guna2DateTimePicker1.Value.Date + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saved successfully. Shedule for " + label15.Text + " "+label12.Text +"  Thank you", " ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error , cheque database connection or input values", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                SqlConnection con3 = db1.getconnection();
                con3.Open();
                DataTable dt3 = new DataTable();
                adapt = new SqlDataAdapter("select member_id As 'Member ID',excercise As 'Exercise Name',sets As 'Sets',reps As 'Reps',rest_time As 'Rest Time' from shedule where  member_id LIKE '%" + label15.Text + "%' AND excercise_no LIKE '%" + label12.Text + "%' ", con3);
                adapt.Fill(dt3);
                guna2DataGridView1.DataSource = dt3;
                con3.Close();
                //     MessageBox.Show("Successfully!");
                clearall();
            }
            iscorrect = true;
            //auto increment and reset values
            s3 = 0;
            auto_create_values();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //update database
            int radioButton;

            try
            {
                SqlConnection con = db1.getconnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE equipment SET amount='" + guna2TextBox9.Text + "',age='" + guna2TextBox4.Text + "',WHERE shedule_id = '" + label15.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully!", " ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error , cheque database connection or input values", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //auto increment and reset values
            s3 = 0;
            auto_create_values();

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            //delete database
            try
            {
                SqlConnection con = db1.getconnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE from shedule WHERE member_id ='"+ label15.Text+ "'AND excercise_no ='" + label12.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully.  " + label15.Text +" excersice no  "+label12.Text+" is no will longer available. Thank you", " ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error , cheque database connection or input values", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //auto increment and reset values
            s3 = 0;
            auto_create_values();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.guna2DataGridView1.Rows[e.RowIndex];
              //   label15.Text = row.Cells[0].Value.ToString();
                //guna2TextBox1.Text = row.Cells[1].Value.ToString();
                //guna2TextBox7.Text = row.Cells[2].Value.ToString();
                
                //guna2TextBox9.Text = row.Cells[3].Value.ToString();
               // guna2TextBox5.Text = row.Cells[4].Value.ToString();
                //guna2TextBox6.Text = row.Cells[5].Value.ToString();
                //guna2TextBox4.Text = row.Cells[6].Value.ToString();
              


            }*/
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            int rowcount = guna2DataGridView1.Rows.Count; // returns gridview raw count
            if (rowcount == 0)
            {
                MessageBox.Show("Empty table cannot print", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String printdate = DateTime.Now.ToString();
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Member Schedule";
                printer.SubTitle = "Mr/Ms " + label7.Text + "   Member ID - " + label15.Text;
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "Lion Dem Gym" + printdate;
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(guna2DataGridView1);
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con4 = db1.getconnection();
            con4.Open();
            SqlCommand Comm4 = new SqlCommand("SELECT excercise_no ,excercise,sets,reps,rest_time,date FROM shedule where  member_id ='" + guna2TextBox4.Text + "' AND excercise = '" + guna2TextBox9.Text + "' ", con4);
            SqlDataReader DR4 = Comm4.ExecuteReader();
            if (DR4.Read())
            {
                label12.Text = DR4.GetValue(0).ToString();
                guna2TextBox5.Text = DR4.GetValue(2).ToString();
                guna2TextBox6.Text = DR4.GetValue(3).ToString();
                guna2TextBox1.Text = DR4.GetValue(4).ToString();
                guna2DateTimePicker1.Text = DR4.GetValue(5).ToString();
            }
            con4.Close();


            SqlConnection con3 = db1.getconnection();
            con3.Open();
            DataTable dt3 = new DataTable();
            adapt = new SqlDataAdapter("select member_id As 'Member ID',excercise As 'Exercise Name',sets As 'Sets',reps As 'Reps',rest_time As 'Rest Time' from shedule where  member_id LIKE '%" + label15.Text + "%' AND excercise_no LIKE '%" + label12.Text + "%' ", con3);
            adapt.Fill(dt3);
            guna2DataGridView1.DataSource = dt3;
            con3.Close();
        }
    }
}
