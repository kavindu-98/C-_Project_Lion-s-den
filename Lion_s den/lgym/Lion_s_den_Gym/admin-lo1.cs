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
    public partial class admin_lo1 : UserControl
    {
        //database class object create to acsess database connection
        databaseclass db1 = new databaseclass();
        String current_pass;
        String current_user;
        //database auto increment variable
        public admin_lo1()
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
            SqlCommand Comm1 = new SqlCommand("select username,passwor from user_con WHERE id=1", con);
            SqlDataReader DR1 = Comm1.ExecuteReader();
            if (DR1.Read())
            {
                current_pass = DR1.GetValue(1).ToString();
                current_user= DR1.GetValue(0).ToString();

            }
            con.Close();
      //      ad_log_username.Text = current_user;
      //      ad_log_password.Text = current_pass;

        }
        private void ad_log_btn_Click(object sender, EventArgs e)
        {
            passwordload();
            if (current_user == ad_log_username.Text )
            { 
                if (current_pass == ad_log_password.Text)
                {
                    label3.Text = "..";
                    label1.Text = "..";
                    seceruty_login_admin_class.securitylogin = 0;
                    //name login
                    seceruty_login_admin_class.name = ad_log_username.Text.ToString();
                    menu f6 = new menu();
                    f6.Show();
                    var f1 = this.ParentForm;
                    f1.Close();
                   

                }
                else
                {
                    label3.Text = "Password in invalied";
                }
            }
            else
            {
                label1.Text = "Username in invalied";
            }



        }

        private void ad_log_username_TextChanged(object sender, EventArgs e)
        {
            ad_log_username.MaxLength = 7;
            if (ad_log_username.Text.Length == 7)
            {

                label1.Text = "Username cannot exceed 6 characters";

            }
            if (ad_log_username.Text.Length == 6)
            {

                label1.Text = "";

            }
        }

        private void ad_log_password_TextChanged(object sender, EventArgs e)
        {
            ad_log_password.MaxLength = 9;
            if (ad_log_password.Text.Length == 9)
            {

                label3.Text = "Password cannot exceed 8 characters";

            }
            if (ad_log_password.Text.Length == 8)
            {

                label3.Text = "";

            }
        }

        private void admin_lo1_Load(object sender, EventArgs e)
        {

        }

        private void forgot_Click(object sender, EventArgs e)
        {
            ad_forgot f8 = new ad_forgot();
            f8.Show();
            var f4 = this.ParentForm;
            f4.Close();
        }
    }
}
