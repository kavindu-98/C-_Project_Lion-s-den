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
    public partial class reports : UserControl
    {
        public reports()
        {
            InitializeComponent();
            income_reports1.BringToFront();
        }

        private void select_combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = select_combox.Items[select_combox.SelectedIndex].ToString();
            ComboBox.ObjectCollection item = select_combox.Items;
            if (selectedItem == "Income Reports")
            {
                income_reports1.BringToFront();
            }
            if (selectedItem == "Reminder")
            {
                reminder1.BringToFront();
            }
            if (selectedItem == "Bill Report")
            { //pending payment as a bill report
                pending_Payments1.BringToFront();
            }
            if (selectedItem == "Special Notes")
            {
                special_notes1.BringToFront();
            }
            if (selectedItem == "Suppliment Report")
            {
                //   completed_Payments1.BringToFront();
                Suppliment_Repot1.BringToFront();

            }
            if (selectedItem == "Members Report")
            {
                members_list1.BringToFront();
            }
            if (selectedItem == "Coach Report")
            {
                coach_list1.BringToFront();
            }
        }
    }
}
