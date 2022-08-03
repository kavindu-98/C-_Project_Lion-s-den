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
    public partial class login : Form
    {
        databaseclass db1 = new databaseclass();
        public login()
        {
            InitializeComponent();

            SqlConnection con = db1.getconnection();
            try
            {
                con.Open();
                label4.Text = "Connection-OK";
                con.Close();

            }
            catch
            {
                label4.Text = "Connection-Error";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Signup_Click(object sender, EventArgs e)
        {
            // menu f1 = new menu();
            //f1.Show();
            //login l1 = new login();
            //l1.Close();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            admin_login f1 = new admin_login();
            f1.Show();
            this.Hide();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            user_login f2 = new user_login();
            f2.Show();
            this.Hide();

        }

        private void Close_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            exit1 e1 = new exit1();
            e1.Show();

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
