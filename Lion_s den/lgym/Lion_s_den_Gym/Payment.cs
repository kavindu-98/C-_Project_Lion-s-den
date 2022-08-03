using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gym
{
    public partial class Payment : UserControl
    {
        public Payment()
        {
            InitializeComponent();

           mem_fee1.BringToFront();
        }

        private void select_combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = select_combox.Items[select_combox.SelectedIndex].ToString();
            ComboBox.ObjectCollection item = select_combox.Items;
            if (selectedItem == "Member Fee")
            {
               mem_fee1.BringToFront();
            }

            if (selectedItem == "Supplyment Payments")
            {
                sup_payments1.BringToFront();
            }
            if (selectedItem == "Bills")
            {
                bill_payments1.BringToFront();
            }
            if (selectedItem == "Coaches Fee")
            {
                coach_payments1.BringToFront();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
