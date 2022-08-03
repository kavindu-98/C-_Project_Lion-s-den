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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            _ = Slidebar.Height == Home.Height;
            Slidebar.Top = Home.Top;
            home1.BringToFront();
           
        }

        private void Home_Click(object sender, EventArgs e)
        {
            _ =Slidebar.Height == Home.Height;
            Slidebar.Top = Home.Top;
            home1.BringToFront();
            label1.Text = "";
        }

        private void registration_Click(object sender, EventArgs e)
        {
            _ = Slidebar.Height == registration.Height;
            Slidebar.Top = registration.Top;
            registration1.BringToFront();
            label1.Text = "";
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            
          
            logout l3 = new logout();
            l3.Show();
            //Opacity( menu , 50);
        }

        private void Equipment_Click(object sender, EventArgs e)
        {
            _ = Slidebar.Height == Equipment.Height;
            Slidebar.Top = Equipment.Top;
            equipment1.BringToFront();
            label1.Text = "";
        }

        private void Suppliment_Click(object sender, EventArgs e)
        {
            _ = Slidebar.Height == Suppliment.Height;
            Slidebar.Top = Suppliment.Top;
            supplement1.BringToFront();
            label1.Text = "";
        }

        private void Schedules_Click(object sender, EventArgs e)
        {
            _ = Slidebar.Height == Schedules.Height;
            Slidebar.Top = Schedules.Top;
            schedule1.BringToFront();
            label1.Text = "";
        }

        private void Payment_Click(object sender, EventArgs e)
        {
            _ = Slidebar.Height == Payment.Height;
            Slidebar.Top = Payment.Top;
            payment1.BringToFront();
            label1.Text = "";
        }

     

        private void report(object sender, EventArgs e)
        {
            if (seceruty_login_admin_class.securitylogin == 0)
            {
                _ = Slidebar.Height == Reports.Height;
                Slidebar.Top = Reports.Top;
                reports1.BringToFront();
            }
            else
            {
                label1.Text = "Admin Access Only";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("HH:mm:ss");
            //label3.Text = DateTime.Now.ToString("dddd, MMMM d");
        }

        private void equipment1_Load(object sender, EventArgs e)
        {

        }

        private void home1_Load(object sender, EventArgs e)
        {

        }
    }
}
