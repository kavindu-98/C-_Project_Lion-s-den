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
    public partial class user_sign : UserControl
    {
        databaseclass db1 = new databaseclass();
        SqlCommand cmd;
        SqlDataAdapter adapt;
        String admin_password;

        public user_sign()
        {
            InitializeComponent();
          
                
                try
                {
                SqlConnection con = db1.getconnection();
                con.Open();
                label5.Text = "Connection-OK";
                con.Close();

                }
                catch
                {
                    label5.Text = "Connection-Error";
                }
            passwordload();
        }

        public void passwordload()
        {
            //database id outo increment  code          
            //auto increment id value        
            SqlConnection con = db1.getconnection();
            con.Open();
            SqlCommand Comm1 = new SqlCommand("select passwor from user_con WHERE id=1", con);
            SqlDataReader DR1 = Comm1.ExecuteReader();
            if (DR1.Read())
            {
               admin_password = DR1.GetValue(0).ToString();

            }
            con.Close();
      
        }
        private void usr_name_change(object sender, EventArgs e)
        {
            usr_sign_username.MaxLength = 9;
            if (usr_sign_username.Text.Length == 9)
            {

                label2.Text = "Username cannot exceed 8 characters";

            }
            if (usr_sign_username.Text.Length == 8)
            {

                label2.Text = "";

            }
        }

        private void usr_new_paswd_change(object sender, EventArgs e)
        {
            usr_new_password.MaxLength = 9;
            if (usr_new_password.Text.Length == 9)
            {

                label3.Text = "Password Cannot exceed 8 characters";

            }
            if (usr_new_password.Text.Length == 8)
            {

                label3.Text = "";

            }
        }

        private void usr_conf_paswd_change(object sender, EventArgs e)
        {
            usr_sign_conf_Paswd.MaxLength = 9;
            if (usr_sign_conf_Paswd.Text.Length == 9)
            {

                label4.Text = "Password Cannot exceed 8 characters";

            }
            if (usr_sign_conf_Paswd.Text.Length == 8)
            {

                label4.Text = "";

            }
        }

        private void ad_sign_btn_Click(object sender, EventArgs e)
        {
            Regex rname = new Regex("[^A-Za-z]");
            Regex rnic = new Regex("[^A-Z0-9]");
            Regex rmob = new Regex("[^0-9]");
            Regex rnotes = new Regex("[^A-Za-z.,;9.)/:0-9]$");
            String s1; 
            String s4="ok";
            int s3 = 0;
         ;
           
                if (usr_new_password.Text != usr_sign_conf_Paswd.Text)
                {
                    label4.Text = "Conform Password is incorrect";
                }
               else if(rname.IsMatch(guna2TextBox2.Text))
            {
                label7.Text = "invalide security name";
                label4.Text = "..";
            }
                else if(admin_password!= guna2TextBox1.Text)
                {
                    label6.Text = "Admin Password is incorrect";
                    label4.Text = "..";
                label7.Text = "..";
            }
                else if (rmob.IsMatch(usr_new_password.Text))
                {
  
                label4.Text = "numbers only";
                label6.Text = ".";
                label4.Text = ".";
                label7.Text = ".";
            }
                else
            {
                label4.Text = ".";
                label6.Text = ".";
                label4.Text = ".";
                label7.Text = ".";
                try
                    {
                        SqlConnection con = db1.getconnection();
                        con.Open();
                        SqlCommand Comm1 = new SqlCommand("select id from user_con WHERE id=(SELECT max(id) FROM user_con)", con);
                        SqlDataReader DR1 = Comm1.ExecuteReader();
                        if (DR1.Read())
                        {
                             s1 = DR1.GetValue(0).ToString();
                            int s2 = Convert.ToInt32(s1);
                            s3 = s2 + 1;
                          //  s4 = s3.ToString();
                        }
                        con.Close();
                        
                        con.Open();
                        cmd = new SqlCommand("INSERT INTO user_con(id, username, passwor,question,anser) VALUES('"+s3+"','"+usr_sign_username.Text+"','"+usr_new_password.Text+ "','" + guna2ComboBox3.SelectedItem + "','" + guna2TextBox2.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("succesfully usernme added", " ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                    
                   
                }
                    catch(Exception ex1)
                    {
                        MessageBox.Show("Database Error , cheque database connection or input values", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            

        }
    }
}
