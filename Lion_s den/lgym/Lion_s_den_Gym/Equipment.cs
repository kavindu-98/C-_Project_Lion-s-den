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
    public partial class Equipment : UserControl
    {

        //database class object create to acsess database connection
        databaseclass db1 = new databaseclass();
        SqlDataAdapter adapt;
        int s3 = 0;
        //validation
        bool iscorrect = true;
        public Equipment()
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
            label7.Text = ".";
            label8.Text = ".";
            label9.Text = ".";
            label10.Text = ".";

            auto_create_values();
        }

        public void validations()
        { //validation variable 
            Regex rname = new Regex("[^A-Za-z]");
            Regex rnic = new Regex("[^A-Z0-9]");
            Regex rmob = new Regex("[^0-9]");
            Regex rnotes = new Regex("[^A-Za-z.,/:0-9]");
            if (rname.IsMatch(guna2TextBox1.Text) || guna2TextBox1.Text == "" || (guna2TextBox1.Text.Length >= 15))
            { //fisrt name
                iscorrect = false;
                label7.Text = "Required correct format";
            }
            else
            {

                label7.Text = ".";
            }
            if (rmob.IsMatch(guna2TextBox2.Text) || guna2TextBox2.Text == "" || (guna2TextBox2.Text.Length >= 10))
            {   //nic
                iscorrect = false;
                label8.Text = "Required correct format";
            }
            else
            {
                label8.Text = ".";
            }
            if (rnotes.IsMatch(guna2TextBox3.Text) || guna2TextBox3.Text == "" || (guna2TextBox3.Text.Length >= 100))
            {   //nic
                iscorrect = false;
                label10.Text = "Required correct format (max word 100)";
            }
            else
            {
                label10.Text = ".";
            }

        }
        public void auto_create_values()
        {   //database id outo increment  code
            String s1;
            //auto increment id value 
            SqlConnection con = db1.getconnection();
            con.Open();
            SqlCommand Comm1 = new SqlCommand("select id from equipment WHERE id=(SELECT max(id) FROM equipment)", con);
            SqlDataReader DR1 = Comm1.ExecuteReader();
            if (DR1.Read())
            {
                s1 = DR1.GetValue(0).ToString();
                int s2 = Convert.ToInt32(s1);
                s3 = s2 + 1;
            }
            con.Close();
            string currentYear = DateTime.Now.Year.ToString();
            String y2 = ("E" + currentYear + "0" + s3).ToString();
            label15.Text = y2;

            //clear all codes
            SqlConnection con1 = db1.getconnection();
            con1.Open();
            SqlCommand cmd = new SqlCommand("table_loadings");
            cmd.Parameters.AddWithValue("@StatementType", "equipment");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con1;
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            con1.Close();
       //     MessageBox.Show("Successfully!");

        }
        public void clearall()
        {
            guna2TextBox1.Clear();
            guna2TextBox2.Clear();
            guna2TextBox3.Clear();
            guna2TextBox4.Clear();
            guna2DateTimePicker1.Value = DateTime.Now;
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            //auto increment and reset values
            s3 = 0;
            auto_create_values();
            clearall();
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
                    SqlCommand cmd = new SqlCommand("INSERT INTO equipment(id,equipment_id,name,amount,date,description) VALUES('" + s3 + "','" + label15.Text + "','" + guna2TextBox1.Text + "','" + guna2TextBox2.Text + "','" + guna2DateTimePicker1.Value.Date + "','" + guna2TextBox3.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inventory saved successfully. equipment ID is  " + label15.Text + ".", " ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    con.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database Error , Cheque database connection or input values", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //auto increment and reset values
                clearall();
                //auto increment and reset values
            }
            s3 = 0;
            iscorrect = true;
            auto_create_values();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //update database
            int radioButton;
            //cheque validation is ok
            validations();
            if (iscorrect == true)
            {
                try
                {
                    SqlConnection con = db1.getconnection();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE equipment SET name='" + guna2TextBox1.Text + "',amount='" + guna2TextBox2.Text + "',date='" + guna2DateTimePicker1.Value.Date + "',description='" + guna2TextBox3.Text + "'WHERE equipment_id = '" + label15.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inventory Updated Successfully!");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error , Cheque database connection or input values", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                clearall();
            }
            //auto increment and reset values
            iscorrect = true;
            s3 = 0;
            auto_create_values();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //delete database
            try
            {
                SqlConnection con = db1.getconnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE from equipment WHERE equipment_id = '" + label15.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully.  " + label15.Text + "  will no longer be available. ", " ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0){
                DataGridViewRow row = this.guna2DataGridView1.Rows[e.RowIndex];
                label15.Text = row.Cells[0].Value.ToString();
                guna2TextBox1.Text = row.Cells[1].Value.ToString();             
                guna2TextBox2.Text = row.Cells[2].Value.ToString();
                guna2DateTimePicker1.Text = row.Cells[3].Value.ToString();
                guna2TextBox3.Text = row.Cells[4].Value.ToString();
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            SqlConnection con = db1.getconnection();
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT equipment_id As 'Equipment ID' ,name As 'Name',amount As 'Amount',date As 'Date',description As 'Description' FROM equipment where  equipment_id LIKE '%" + guna2TextBox4.Text + "%'", con);
            adapt.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            con.Close();

            String s1;
            SqlConnection con2 = db1.getconnection();
            con2.Open();
            SqlCommand Comm2 = new SqlCommand("SELECT * FROM equipment where  equipment_id LIKE '%" + guna2TextBox4.Text + "%'", con2);
            SqlDataReader DR2 = Comm2.ExecuteReader();
            if (DR2.Read())
            {
                label15.Text = DR2.GetValue(1).ToString();
                guna2TextBox1.Text = DR2.GetValue(2).ToString();
                guna2TextBox2.Text = DR2.GetValue(3).ToString();
                guna2DateTimePicker1.Text= DR2.GetValue(4).ToString();
                guna2TextBox3.Text = DR2.GetValue(5).ToString();

            }
            con2.Close();
           
        }

        private void Equipment_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
