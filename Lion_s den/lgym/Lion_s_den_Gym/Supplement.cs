using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Lion_s_den_Gym;

namespace gym
{
    public partial class Supplement : UserControl
    {
        //database class object create to acsess database connection
        databaseclass db1 = new databaseclass();
        SqlDataAdapter adapt;
        int s3 = 0;
        //validation
        bool iscorrect = true;
        public Supplement()
        {
            InitializeComponent();
            //clear the data when from start
            label16.Text = ".";
            label17.Text = ".";
            label18.Text = ".";
            label19.Text = ".";
           
            //auto increment databse id
            auto_create_values();
            clearall();
        }

        public void auto_create_values()
        {   //database id outo increment  code
            String s1;
            //auto increment id value forsuppliment_id tabel       
            SqlConnection con = db1.getconnection();
            con.Open();
            SqlCommand Comm1 = new SqlCommand("select id from suppliment_id WHERE id=(SELECT max(id) FROM suppliment_id)", con);
            SqlDataReader DR1 = Comm1.ExecuteReader();
            if (DR1.Read())
            {
                s1 = DR1.GetValue(0).ToString();
                int s2 = Convert.ToInt32(s1);
                s3 = s2 + 1;
            }
            con.Close();
            //     string currentYear = DateTime.Now.Year.ToString();
            //    String y2 = ("S" + currentYear + "0" + s3).ToString();
            label7.Text = s3.ToString(); 

            //tabel load for suppliment_id 
            SqlConnection con1 = db1.getconnection();
            con1.Open();
            SqlCommand cmd = new SqlCommand("table_loadings");
            cmd.Parameters.AddWithValue("@StatementType", "suppliment");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con1;
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);
            guna2DataGridView1.DataSource = dt;
          
            con1.Close();

        }

        public void clearall()
        {
            txtSearchSID.Clear();
            guna2TextBox1.Clear();
            txtName.Clear();          
            txtAmount.Clear();
            txtDescription.Clear();
            //clear the data when from start
            label16.Text = ".";
            label17.Text = ".";
            label18.Text = ".";
            label19.Text = ".";

        }

        public void validation()
        {
            //validation variable 
            Regex rname = new Regex("[^A-Za-z]");
            Regex rnic = new Regex("[^A-Z0-9]");
            Regex rmob = new Regex("[^0-9]");
            Regex rnotes = new Regex("[^A-Za-z.,/:0-9]");
            if (label7.Text == "000")
            {
                iscorrect = false;
                MessageBox.Show("Empty Id", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*if (rname.IsMatch(guna2TextBox1.Text) || guna2TextBox1.Text == "" || (guna2TextBox1.Text.Length > 5))
            { //fisrt name
                iscorrect = false;
                label16.Text = "required correct format(max word 5)";
            }
            else
            {

                label16.Text = "..";
            }*/
            
            if (rname.IsMatch(txtName.Text) || txtName.Text == "" || (txtName.Text.Length >30))
            {   //last name
                iscorrect = false;
                label17.Text = "required correct format (max word 30)";
            }
            else
            {

                label17.Text = ".";
            }
            if (rmob.IsMatch(txtAmount.Text) || txtAmount.Text == "" || (txtAmount.Text.Length >4))
            { //fisrt name
                iscorrect = false;
                label18.Text = "required correct format(max word 4)";
            }
            else
            {

                label18.Text = ".";
            }
            if (rnotes.IsMatch(txtDescription.Text) || txtDescription.Text == "" || (txtDescription.Text.Length >99))
            { //fisrt name
                iscorrect = false;
                label19.Text = "required correct format(max word 99)";
            }
            else
            {

                label19.Text = ".";
            }

        }


        private void Supplement_Load(object sender, EventArgs e)
        {
            

           

        }

       
    

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //cheque validation is ok
            validation();
            if (iscorrect == true)
            {
                String new_id = txtName.Text.ToString() + s3.ToString();
                try
                {  
                    SqlConnection con = db1.getconnection();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO suppliment_id(id,suppliment_id,name,amount,description) VALUES('" + s3 + "','" + new_id + "','" + txtName.Text + "','" + txtAmount.Text + "','" + txtDescription + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Insert successfully. equipment id is  " + new_id + "  Thank you", " ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error , cheque database connection or input values", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //auto increment and reset values
            s3 = 0;
            iscorrect = true;
            auto_create_values();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {   
            s3 = 0;
            iscorrect = true;
            auto_create_values();
            clearall();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {



            //update database
            //cheque validation is ok
            validation();
            if (iscorrect == true)
            {

                try
                {
                    SqlConnection con = db1.getconnection();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE suppliment SET suppliment_name='" + txtName.Text + "',amount='" + txtAmount.Text + "',description='" + txtDescription.Text + "',WHERE ddddd= '" + label7.Text + "'AND supplier_mobile_no='" + guna2TextBox1.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully!");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error , cheque database connection or input values", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //auto increment and reset values
            iscorrect = true;
            s3 = 0;
            auto_create_values();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          
            try
            {
                SqlConnection con = db1.getconnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE from suppliment_id WHERE suppliment_id = '" + label7.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete successfully.  " + label7.Text + " is no will longer available. Thank you", " ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                con.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Database Error , cheque database connection or input values", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //auto increment and reset values
            s3 = 0;
            auto_create_values();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = db1.getconnection();
            con1.Open();
            DataTable dt1 = new DataTable();
            adapt = new SqlDataAdapter("SELECT suppliment_id As 'suppliment id',name As 'suppliment name',amount FROM suppliment_id where suppliment_id = '" + txtSearchSID.Text + "'", con1);
            adapt.Fill(dt1);
            guna2DataGridView1.DataSource = dt1;
            con1.Close();

            SqlConnection con2 = db1.getconnection();
            con2.Open();
            SqlCommand Comm2 = new SqlCommand("SELECT * FROM suppliment_id where suppliment_id LIKE '%" + txtSearchSID.Text + "%'", con2);
            SqlDataReader DR2 = Comm2.ExecuteReader();
            if (DR2.Read())
            {
                label7.Text = DR2.GetValue(1).ToString();
                txtName.Text= DR2.GetValue(2).ToString();
                txtAmount.Text = DR2.GetValue(3).ToString();
                txtDescription.Text = DR2.GetValue(4).ToString();

            }
            con2.Close();

            
        }

        private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
              /*  DataGridViewRow row = this.Table.Rows[e.RowIndex];
                label7.Text = row.Cells[0].Value.ToString();
                guna2TextBox1.Text = row.Cells[1].Value.ToString();
                txtName.Text = row.Cells[2].Value.ToString();
                datePicker.Text = row.Cells[3].Value.ToString();
                txtAmount.Text = row.Cells[4].Value.ToString();
                txtDescription.Text = row.Cells[5].Value.ToString(); */

            }
        }

        private void RefreshIcon_Click(object sender, EventArgs e)
        {
            
        }

        private void label15_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            //cheque validation is ok
            //validation variable 
            Regex rname = new Regex("[^A-Za-z]");
            Regex rnic = new Regex("[^A-Z0-9]");
            Regex rmob = new Regex("[^0-9]");
            if (rmob.IsMatch(txtAmount.Text) || txtAmount.Text == "" || (txtAmount.Text.Length > 4))
            { //fisrt name
                iscorrect = false;
                label18.Text = "required correct format(max word 4)";
            }
            else
            {
                try
                {
                    SqlConnection con = db1.getconnection();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE suppliment_id SET  amount='" + txtAmount.Text + "' WHERE suppliment_id ='" + label7.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Successfully!");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error , cheque database connection or input values", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                clearall();
            
            label18.Text = "..";
            }
   
            auto_create_values();

        }
    }
}

    



