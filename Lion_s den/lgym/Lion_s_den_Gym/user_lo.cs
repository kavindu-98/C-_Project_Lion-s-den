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
    public partial class user_lo : UserControl
    {
        //database class object create to acsess database connection
        databaseclass db1 = new databaseclass();
        String current_pass;
        String current_user;
        //database auto increment variable
        public user_lo()
        {
            InitializeComponent();
        }

        private void ad_log_btn_Click(object sender, EventArgs e)
        {
            passwordload();
           
                if (current_pass == usr_log_password.Text)
                {
                    label3.Text = ".";
                    label1.Text = ".";

                    seceruty_login_admin_class.securitylogin = 1;
                //user login name
                seceruty_login_admin_class.name = usr_log_username.Text.ToString();
                menu f6 = new menu();
                    f6.Show();
                    var f4 = this.ParentForm;
                    f4.Close();
            
                }
                else
                {
                    label3.Text = "Password in invalied";
                }

           

        }

        public void passwordload()
        {
            //database id outo increment  code          
            //auto increment id value        
            try
            {
                SqlConnection con = db1.getconnection();
                con.Open();
                SqlCommand Comm1 = new SqlCommand("select username,passwor from user_con WHERE username='" + usr_log_username.Text + "'", con);
                SqlDataReader DR1 = Comm1.ExecuteReader();
                if (DR1.Read())
                {
                       current_pass = DR1.GetValue(1).ToString();
                       current_user= DR1.GetValue(0).ToString();

                }
                con.Close();
                //  ad_log_btn.Text = current_user;
                //  usr_log_password.Text = current_pass;
               //forgot.Text = current_pass;
            
            }
            catch(SqlException ex)
            {
                label1.Text = "Invalied Username";
            }
        }
        private void forgot_btn_h(object sender, EventArgs e)
        {
           
        }

        private void user_name_change(object sender, EventArgs e)
        {
            usr_log_username.MaxLength = 9;
            if (usr_log_username.Text.Length == 9)
            {

                label1.Text = "Username cannot exeed 8 characters";

            }
            if (usr_log_username.Text.Length == 8)
            {

                label1.Text = "";

            }
        }

        private void user_paswd_change(object sender, EventArgs e)
        {
            usr_log_password.MaxLength = 9;
            if (usr_log_password.Text.Length == 9)
            {

                label3.Text = "Password cannot exceed 8 characters";

            }
            if (usr_log_password.Text.Length == 8)
            {

                label3.Text = "";

            }
        }

        private void forgot_Click(object sender, EventArgs e)
        {
            forgot f6 = new forgot();
            f6.Show();
            var f4 = this.ParentForm;
            f4.Close();
        }
    }
}
