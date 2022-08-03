using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lion_s_den_Gym
{
    public partial class admin_sign : UserControl
    {//database class object create to acsess database connection
        databaseclass db1 = new databaseclass();
        String current_pass;
        //database auto increment variable
    
        public admin_sign()
        {
            InitializeComponent();
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
               current_pass = DR1.GetValue(0).ToString();
               
            }
            con.Close();
            label5.Text = current_pass;     
        }
        private void current_paswd_change(object sender, EventArgs e)
        {
            admin_currnt_pass.MaxLength = 9;
            if (admin_currnt_pass.Text.Length == 9)
            {

                label2.Text = "Password Cannot exceed 8 characters";

            }
            if (admin_currnt_pass.Text.Length == 8)
            {

                label2.Text = "";

            }
        }

        private void new_passw_change(object sender, EventArgs e)
        {
            ad_new_pass.MaxLength = 9;
            if (ad_new_pass.Text.Length == 9)
            {

                label3.Text = "Password Cannot exceed 8 characters";

            }
            if (ad_new_pass.Text.Length == 8)
            {

                label3.Text = "";

            }
        }

        private void conf_passw_change(object sender, EventArgs e)
        {
            ad_new_conf_Passwd.MaxLength = 9;
            if (ad_new_conf_Passwd.Text.Length == 9)
            {

                label4.Text = "Password Cannot exceed 8 characters";

            }
            if (ad_new_conf_Passwd.Text.Length == 8)
            {

                label4.Text = "";

            }
        }

        private void ad_sign_btn_Click(object sender, EventArgs e) {
            String current_enter = admin_currnt_pass.Text;
            String new_pass=  ad_new_pass.Text;
            String conform_pass = ad_new_conf_Passwd.Text;
 
      //  int current_int = Convert.ToInt32(current_pass);
     
        {
                  if (current_pass == current_enter)
                    {
                    if (conform_pass == new_pass) {
                        DialogResult d = MessageBox.Show("Do You want to change password", " ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
                        if (d == DialogResult.Yes)
                        {
                            try
                            {
                                SqlConnection con = db1.getconnection();
                                con.Open();
                                SqlCommand cmd = new SqlCommand("UPDATE user_con SET passwor='"+ new_pass +"' WHERE id = '1'", con);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Password Chnage Succesfully", " ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                con.Close();
                            }
                            catch (SqlException)
                            {
                                MessageBox.Show("Database Error , cheque database connection or input values", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("conform password is not match with new password"," ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    }
                    else
                    {
                        MessageBox.Show("curent password is not match", " ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                        
                    
              
            }
        }
    }
}
