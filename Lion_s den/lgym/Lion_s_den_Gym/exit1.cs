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
    public partial class exit1 : Form
    {
        public exit1()
        {
            InitializeComponent();
        }

        private void exit_yes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exit_no_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
