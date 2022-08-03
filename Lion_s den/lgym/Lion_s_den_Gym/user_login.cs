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
    public partial class user_login : Form
    {
        public user_login()
        {
            InitializeComponent();
            user_lo1.BringToFront();
        }

        private void user_sign_btn_hover(object sender, EventArgs e)
        {
             user_sign_btn.Location =  new System.Drawing.Point(320, 21);
        }

        private void user_sign_btn_Click(object sender, EventArgs e)
        {
            user_sign1.BringToFront();
        }

        private void user_sign_log_btn_m_leave(object sender, EventArgs e)
        {
            user_sign_log_btn.Location = new System.Drawing.Point(398, 67);
        }

        private void user_sign_log_btn_hover(object sender, EventArgs e)
        {
            user_sign_log_btn.Location = new System.Drawing.Point(320, 67);
        }

        private void user_log_sign_btn_m_leave(object sender, EventArgs e)
        {
            user_sign_btn.Location = new System.Drawing.Point(398, 21);
        }

        private void user_sign_log_btn_Click(object sender, EventArgs e)
        {
            user_lo1.BringToFront();
        }

        private void ad_log_back_btn_Click(object sender, EventArgs e)
        {
            login f8 = new login();
            f8.Show();
            this.Hide();
        }
    }
}
