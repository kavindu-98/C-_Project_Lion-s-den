using Lion_s_den_Gym;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gym
{
    public partial class Registration : UserControl
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void select_combox_SelectedIndexChanged(object sender, EventArgs e) //Handles select_combox.SelectedIndexChanged
        {
            string selectedItem = select_combox.Items[select_combox.SelectedIndex].ToString();
            ComboBox.ObjectCollection item = select_combox.Items;
            if (selectedItem == "Member" ){
                mem_reg1.BringToFront();
                label1.Text = ".";
            }

            if (selectedItem == "Coach")
            {
                if (seceruty_login_admin_class.securitylogin == 0)
                {
                    co_reg1.BringToFront();
                    label1.Text = ".";
                }
                else
                {
                    label1.Text = "Coach registration is for admin access only";
                    
                }
              
            }
        }

        private void mem_reg1_Load(object sender, EventArgs e)
        {

        }
    }
}
