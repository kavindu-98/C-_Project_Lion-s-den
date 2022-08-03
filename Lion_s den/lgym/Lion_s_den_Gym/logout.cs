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
    public partial class logout : Form
    {
        public logout()
        {
            InitializeComponent();
        }

        private void logout_yes_Click(object sender, EventArgs e)
        {
            login l2 = new login();
            l2.Show();
            this.Close();
            //var f3 = this.ParentForm;
            //f3.Close();
            Application.OpenForms["menu"].Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
