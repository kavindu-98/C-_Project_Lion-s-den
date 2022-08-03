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
    public partial class mem_reg : UserControl
    {   //database class object create to acsess database connection
        databaseclass db1 = new databaseclass();
        //database auto increment variable
        int s3 = 0;
        //validation
        bool iscorrect = true;

        public mem_reg()
        {
            InitializeComponent();
            //cheque database connection - not nessasary
            try
            {
                SqlConnection con = db1.getconnection();
                con.Open();
                label12.Text = "Connection-OK";
                con.Close();
            }
            catch (Exception ex)
            {
                label12.Text = "Connection-Error";
            }
            //clear the data when from start
            label16.Text = ".";
            label17.Text = ".";
            label18.Text = ".";
            label19.Text = ".";
            label20.Text = ".";
            label21.Text = ".";
            label22.Text = ".";
            label23.Text = ".";
            label24.Text = ".";
            label25.Text = ".";
            label26.Text = ".";
            label27.Text = ".";
            //auto increment databse id
            auto_create_values();
        }
        public void validations()
        { //validation variable 
            Regex rname = new Regex("[^A-Za-z]");
            Regex rnic = new Regex("[^A-Z0-9]");
            Regex rmob = new Regex("[^0-9]");
            Regex rnotes = new Regex("[^A-Za-z.,;9.)/:0-9]$");
           
            if (rname.IsMatch(guna2TextBox1.Text) || guna2TextBox1.Text == "" || (guna2TextBox1.Text.Length > 14))
            { //fisrt name
                iscorrect = false;
                label16.Text = "Required correct format";
            }
            else
            {

                label16.Text = ".";
            }
            if (rname.IsMatch(guna2TextBox2.Text) || guna2TextBox2.Text == "" || (guna2TextBox1.Text.Length > 14))
            {   //last name
                iscorrect = false;
                label17.Text = "Required correct format";
            }
            else
            {

                label17.Text = ".";
            }
            if ((guna2ImageRadioButton1.Checked) || (guna2ImageRadioButton2.Checked))
            {
                //gender
                label18.Text = ".";

            }
            else
            {
                iscorrect = false;
                label18.Text = "Required correct format";
            }
            if (guna2ComboBox3.Text == "")
            {   //age
                iscorrect = false;
                label20.Text = "Required correct format";
            }
            else
            {
                label20.Text = ".";
            }

            if (rnic.IsMatch(guna2TextBox3.Text)||guna2TextBox3.Text==""||(guna2TextBox3.Text.Length>12))
            {   //nic
                iscorrect = false;
                label21.Text = "Required correct format";
            }
            else
            {
                label21.Text = ".";
            }
            if (guna2ComboBox1.Text == "")
            { //weight
                iscorrect = false;
                label22.Text = "Required correct format";
            }
            else
            {
                label22.Text = ".";
            }
            if (guna2ComboBox2.Text == "")
            {  //height
                iscorrect = false;
                label23.Text = "Required correct format";
            }
            else
            {
                label23.Text = ".";
            }

            if (guna2TextBox8.Text == "")
            {  //height
                iscorrect = false;
                label24.Text = "Required correct format";
            }
            else
            {
                label24.Text = ".";
            }
            if (rmob.IsMatch(guna2TextBox7.Text) || guna2TextBox7.Text == "" || (guna2TextBox7.Text.Length != 10))
            {   //nic
                iscorrect = false;
                label25.Text = "Required correct format";
            }
            else
            {
                label25.Text = ".";
            }
            if (rnotes.IsMatch(guna2TextBox5.Text) || guna2TextBox5.Text == "" || (guna2TextBox5.Text.Length > 100))
            {   //nic
                iscorrect = false;
                label26.Text = "Required correct format";
            }
            else
            {
                label26.Text = ".";
            }
            if (rnotes.IsMatch(guna2TextBox6.Text) || guna2TextBox6.Text == "" || (guna2TextBox6.Text.Length > 1500))
            {   //nic
                iscorrect = false;
                label27.Text = "Required correct format (maximum words 1500)";
            }
            else
            {
                label27.Text = ".";
            }

        }


        public void auto_create_values()
        {   //database id outo increment  code
            String s1;
            //auto increment id value        
            SqlConnection con = db1.getconnection();
            con.Open();
            SqlCommand Comm1 = new SqlCommand("select id from member_rej WHERE id=(SELECT max(id) FROM member_rej)", con);
            SqlDataReader DR1 = Comm1.ExecuteReader();
            if (DR1.Read())
            {
                s1 = DR1.GetValue(0).ToString();
                int s2 = Convert.ToInt32(s1);
                s3 = s2 + 1;
            }
            con.Close();
            string currentYear = DateTime.Now.Year.ToString();
            String y2 = "M" + currentYear + "0" + s3.ToString();
            label15.Text = y2;

        }

        public void clearall()
        {
            //clear all codes
            guna2TextBox4.Clear();
            guna2TextBox1.Clear();
            guna2TextBox2.Clear();
            guna2ImageRadioButton1.Checked = false;
            guna2ImageRadioButton2.Checked = false;
            guna2DateTimePicker1.Value = DateTime.Now; 
            guna2ComboBox3.SelectedItem = null;
            guna2TextBox3.Clear();
            guna2ComboBox1.SelectedItem = null;
            guna2ComboBox2.SelectedItem = null;
            guna2TextBox8.Text = "";
            guna2TextBox7.Clear();
            guna2TextBox5.Clear();
            guna2TextBox6.Clear();


            //clear the data when from start
            label16.Text = ".";
            label17.Text = ".";
            label18.Text = ".";
            label19.Text = ".";
            label20.Text = ".";
            label21.Text = ".";
            label22.Text = ".";
            label23.Text = ".";
            label24.Text = ".";
            label25.Text = ".";
            label26.Text = ".";
            label27.Text = ".";



        }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { //bmi value outo genarate code
           try
            {
               
                Double g = Convert.ToDouble(guna2ComboBox1.Text);
                Double m = Convert.ToDouble(guna2ComboBox2.Text);
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
            //cheque validation is ok
            validations();
            if ( iscorrect==true) {

                //insert data code -we pass the male as 0 and female as 1 for the database ,
                //because string gives an error insert code to the cheque box from database
                bool radioButton;
                if (guna2ImageRadioButton1.Checked)
                {
                    radioButton = false;
                }
                else
                {
                    radioButton = true;
                }

                try
                {
                    SqlConnection con = db1.getconnection();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO member_rej(id, member_id,first_name,last_name,gender,rejister_date,age,nic,weight,height,bmi,mobile_no,adress,notes) VALUES('" + s3 + "','" + label15.Text + "','" + guna2TextBox1.Text + "','" + guna2TextBox2.Text + "','" + radioButton + "','" + guna2DateTimePicker1.Value.Date + "','" + guna2ComboBox3.SelectedItem + "','" + guna2TextBox3.Text + "','" + guna2ComboBox1.SelectedItem + "','" + guna2ComboBox2.SelectedItem + "','" + guna2TextBox8.Text + "','" + guna2TextBox7.Text + "','" + guna2TextBox5.Text + "','" + guna2TextBox6.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registered successfully. Your Member ID is  " + label15.Text + ".  Thank you !", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Database Error , Cheque Database connection or input values", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                clearall();
            }
            //auto increment and reset values
            s3 = 0;
            iscorrect = true;
            auto_create_values();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            //auto increment and reset values

            clearall();
            s3 = 0;
            iscorrect = true;
            auto_create_values();

       

        }

        private void mem_reg_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //delete database
            try
            {
                SqlConnection con = db1.getconnection();
                con.Open();
                SqlCommand   cmd = new SqlCommand("DELETE from member_rej WHERE member_id = '" + label15.Text + "'", con);
                cmd.ExecuteNonQuery();              
                con.Close();

                SqlConnection con1 = db1.getconnection();
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("DELETE from shedule WHERE member_id = '" + label15.Text + "'", con1);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully.  " + label15.Text + " Data and Shedule  will no longer be available. Thank you !", " ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                con1.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Database Error , Cheque Database connection or input values", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clearall();
            //auto increment and reset values
            s3 = 0;
            auto_create_values();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //update database
            //cheque validation is ok
            validations();
            if (iscorrect == true)
            {
                bool radioButton;
                if (guna2ImageRadioButton1.Checked)
                {
                    radioButton = false;
                }
                else
                {
                    radioButton = true;
                }
                try
                {
                    SqlConnection con = db1.getconnection();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE member_rej SET first_name='" + guna2TextBox1.Text + "',last_name='" + guna2TextBox2.Text + "',gender='" + radioButton + "',rejister_date='" + guna2DateTimePicker1.Value.Date + "',age='" + guna2ComboBox3.SelectedItem + "',nic='" + guna2TextBox3.Text + "',weight='" + guna2ComboBox1.SelectedItem + "',height='" + guna2ComboBox2.SelectedItem + "',bmi='" + guna2TextBox8.Text + "',mobile_no='" + guna2TextBox7.Text + "',adress='" + guna2TextBox5.Text + "',notes='" + guna2TextBox6.Text + "' WHERE member_id = '" + label15.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully! ", " ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    con.Close();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Database Error , Cheque database connection or input values", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                clearall();
            }
            //auto increment and reset values
            s3 = 0;
            iscorrect = true;
            auto_create_values();


        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Close_Click(object sender, EventArgs e)
        {
                //serch database using entering member_id
                SqlConnection con = db1.getconnection();
                con.Open();
                SqlCommand Comm1 = new SqlCommand("SELECT * FROM member_rej where member_id LIKE '%" + guna2TextBox4.Text + "%'", con);
                SqlDataReader DR2 = Comm1.ExecuteReader();
                if (DR2.Read())
                {
                    label15.Text = DR2.GetValue(1).ToString();
                    guna2TextBox1.Text = DR2.GetValue(2).ToString();
                    guna2TextBox2.Text = DR2.GetValue(3).ToString();
                    String radiobutton1 = DR2.GetValue(4).ToString();
                 //   int r1 = int.Parse(radiobutton1);

                    if (radiobutton1 == "True")
                    {
                       guna2ImageRadioButton1.Checked = true;
                    }
                    else if (radiobutton1 == "False")
                    {
                        guna2ImageRadioButton2.Checked = true;
                    }
                    guna2DateTimePicker1.Text = DR2.GetValue(5).ToString();
                    guna2ComboBox3.Text = DR2.GetValue(6).ToString();
                    guna2TextBox3.Text = DR2.GetValue(7).ToString();
                    guna2ComboBox1.Text = DR2.GetValue(8).ToString();
                    guna2ComboBox2.Text = DR2.GetValue(9).ToString();
                 //   guna2TextBox8.Text = DR2.GetValue(10).ToString();
                    guna2TextBox7.Text = DR2.GetValue(11).ToString();
                    guna2TextBox5.Text = DR2.GetValue(12).ToString();
                    guna2TextBox6.Text = DR2.GetValue(13).ToString();
                }
                con.Close();

            
        }

        private void guna2ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {

                Double g = Convert.ToDouble(guna2ComboBox1.Text);
                Double m = Convert.ToDouble(guna2ComboBox2.Text);
                Double z = g / ((m * m) / 10000);
                Double dc = Math.Round((Double)z, 2);
                String myString = dc.ToString();
                guna2TextBox8.Text = myString;
            }
            catch
            {
                guna2TextBox8.Text = "";
            }
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                Double g = Convert.ToDouble(guna2ComboBox1.Text);
                Double m = Convert.ToDouble(guna2ComboBox2.Text);
                Double z = g / ((m * m) / 10000);
                Double dc = Math.Round((Double)z, 2);
                String myString = dc.ToString();
                guna2TextBox8.Text = myString;
            }
            catch
            {
                guna2TextBox8.Text = "";
            }
        }

        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
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

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            try
            {

                Double g = Convert.ToDouble(guna2ComboBox1.SelectedItem);
                Double m = Convert.ToDouble(guna2ComboBox2.SelectedItem);
                Double z = g / ((m * m) / 10000);
                Double dc = Math.Round((Double)z, 2);
                String myString = dc.ToString();
                guna2TextBox8.Text = myString;
            }
            catch
            {
                guna2TextBox8.Text = "";
            }
        }
    }
}
