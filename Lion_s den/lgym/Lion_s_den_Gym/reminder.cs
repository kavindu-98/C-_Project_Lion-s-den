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
    
    public partial class reminder : UserControl
    {
        // SqlConnection con = new SqlConnection("Server=DESKTOP-VNPDKN3;Database=Database1.mdf;Trusted_Connection=true");
        databaseclass db1 = new databaseclass();
        // SqlCommand cmd;
        SqlDataAdapter adapt;
        String labe;
        int s3 = 0;
        //validation
        bool iscorrect = true;
        public reminder()
        {
            InitializeComponent();


            if (seceruty_login_admin_class.formload_fromhome == 4)
            {
                guna2Button5.Show();
            }
            else
            {
                guna2Button5.Hide();
            }
            //hide date button when open the form
            datePicker.Hide();
            label2.Text = "..";
            auto_create_values();
        }

        public void auto_create_values()
        {   //database id outo increment  code
            String s1;
            //auto increment id value        
            SqlConnection con = db1.getconnection();
            con.Open();
            SqlCommand Comm1 = new SqlCommand("select id from reminder WHERE id=(SELECT max(id) FROM reminder)", con);
            SqlDataReader DR1 = Comm1.ExecuteReader();
            if (DR1.Read())
            {
                s1 = DR1.GetValue(0).ToString();
                int s2 = Convert.ToInt32(s1);
                s3 = s2 + 1;
            }
            con.Close();
            string currentYear = DateTime.Now.Year.ToString();
            String y2 =  s3.ToString();
            label7.Text = y2;

        }

       public void  clearall()
        {
            txtDescription.Clear();
            label2.Text = "..";
        }
        public void validations()
        { //validation variable 
            Regex rname = new Regex("[^A-Za-z]");
            Regex rnic = new Regex("[^A-Z0-9]");
            Regex rmob = new Regex("[^0-9]");
            Regex rnotes = new Regex("[^A-Za-z.,;9.)/:0-9]$");
            if (rnotes.IsMatch(txtDescription.Text) || txtDescription.Text == "" || (txtDescription.Text.Length > 14))
            { //fisrt name
                iscorrect = false;
                label2.Text = "required correct format(max word 1500)";
            }
            else
            {

                label2.Text = "..";
            }
        }
        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        { //hide and show button
          if(  guna2CheckBox1.Checked)
            {
                datePicker.Show();
            }
            else
            {
                datePicker.Hide();
            }

        }

        private void reminder_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //cheque validation is ok
            validations();
            if (iscorrect == true)
            {
                //insert data code -we pass the male as 0 and female as 1 for the database ,
                //because string gives an error insert code to the cheque box from database
                if (guna2CheckBox1.Checked)
                {
                    try
                    {
                        SqlConnection con = db1.getconnection();
                        con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO reminder(Id,reminder_date,note) VALUES('" + s3 + "','" + datePicker.Value.Date + "','" + txtDescription.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Insert successfully your member id is  " + label7.Text + "  Thank you", " ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        con.Close();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Database Error , cheque database connection or input values", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    clearall();
                }
                else
                {
                    try
                    {
                        SqlConnection con1 = db1.getconnection();
                        con1.Open();
                        SqlCommand cmd1 = new SqlCommand("INSERT INTO reminder(Id,note) VALUES('" + s3 + "','" + txtDescription.Text + "')", con1);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Insert successfully your member id is  " + label7.Text + "  Thank you", " ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        con1.Close();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Database Error , cheque database connection or input values", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    clearall();
                }
            }
            //auto increment and reset values
            s3 = 0;
            iscorrect = true;
            auto_create_values();
            clearall();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = db1.getconnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("reminder_data");
            cmd.Parameters.AddWithValue("@StatementType","Select_all");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            con.Close();
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = db1.getconnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("reminder_data");
            DataTable dt = new DataTable();
            cmd.Parameters.AddWithValue("@StatementType", "Select_reminder");
            //cmd.Parameters["@param1"].Value = "2";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            con.Close();
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            //delete database
            try
            {
                SqlConnection con = db1.getconnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE from reminder WHERE id = '" + label7.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete successfully.  " + label2.Text + " is no will longer available. Thank you", " ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                con.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Database Error , cheque database connection or input values", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clearall();
            //auto increment and reset values
            s3 = 0;
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

        private void guna2Button2_Click(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("UPDATE reminder SET note='" + txtDescription.Text + "'where id='" + label7.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Successfully!");
                    con.Close();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Database Error , cheque database connection or input values", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                clearall();
            }
            //auto increment and reset values
            s3 = 0;
            iscorrect = true;
            auto_create_values();

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            seceruty_login_admin_class.formload_fromhome = 3;
            guna2Button5.Hide();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.guna2DataGridView1.Rows[e.RowIndex];
                label7.Text = row.Cells[0].Value.ToString();
                txtDescription.Text = row.Cells[2].Value.ToString();
                datePicker.Text = row.Cells[1].Value.ToString(); 
            }
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            SqlConnection con = db1.getconnection();
            con.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM reminder where  id = '" + guna2TextBox4.Text + "'", con);
            SqlDataReader DR1 = cmd.ExecuteReader();
            if (DR1.Read())
            {
                label7.Text = DR1.GetValue(0).ToString();
              
            }
            con.Close();

            SqlConnection con2 = db1.getconnection();
            con2.Open();
            DataTable dt2 = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM reminder where  id LIKE '%" + guna2TextBox4.Text + "%'", con2);
            adapt.Fill(dt2);
            guna2DataGridView1.DataSource = dt2;
            con2.Close();
        }
    }
}
