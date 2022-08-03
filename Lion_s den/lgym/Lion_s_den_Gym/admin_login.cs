using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lion_s_den_Gym
{
    public partial class admin_login : Form
    {
        public admin_login()
        {
            InitializeComponent();
            admin_lo1.BringToFront();
        }

     

        private void admin_login_Load(object sender, EventArgs e)
        {

        }

       

        private void ad_sign_lo_btn_Click(object sender, EventArgs e)
        {
            //admin_lo1.BringToFront();
            
        }

        private void ad_log_sign_btn_Click_1(object sender, EventArgs e)
        {
            admin_sign1.BringToFront();
            


        }

        private void ad_log_sign_btn_hover(object sender, EventArgs e)
        {
            //ad_log_sign_btn.Size = new System.Drawing.Size(180, 45);
            //ad_log_sign_btn.Height = 45;
            //ad_log_sign_btn.Top = 28;
            ad_log_sign_btn.Location =  new System.Drawing.Point(320, 21);
        }

        private void d_log_sign_btn_m_leave(object sender, EventArgs e)
        {
            //ad_log_sign_btn.Size = new System.Drawing.Size(180,45);
            ad_log_sign_btn.Location = new System.Drawing.Point(398, 21);
        }

        private void add_signup(object sender, EventArgs e)
        {
           
        }

        private void ad_log_sign_btn_LocationChanged(object sender, EventArgs e)
        {
         
        }

      

        private void ad_log_back_btn_Click(object sender, EventArgs e)
        {
            login f7 = new login();
            f7.Show();
            this.Hide();
        }

        private void ad_sign_log_btn_Click(object sender, EventArgs e)
        {
            admin_lo1.BringToFront();
        }

        private void ad_sign_log_btn_hover(object sender, EventArgs e)
        {
            ad_sign_log_btn.Location = new System.Drawing.Point(320, 67);
        }

        private void ad_sign_log_btn_m_leave(object sender, EventArgs e)
        {
            ad_sign_log_btn.Location = new System.Drawing.Point(398, 67);
        }
    }
}
