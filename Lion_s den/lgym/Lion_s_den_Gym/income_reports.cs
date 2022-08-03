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
    public partial class income_reports : UserControl
    {
        //database class object create to acsess database connection
        databaseclass db1 = new databaseclass();
        SqlDataAdapter adapt;
        int s3 = 0;
        String ch1, ch2, ch3, ch4,ch5, ch6, ch7, ch8;

        public income_reports()
        {
            InitializeComponent();

            chart();


        }

        public void chart()
        {      //1
            SqlConnection con1 = db1.getconnection();
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("report_chart");
            cmd1.Parameters.AddWithValue("@StatementType","total_bill_pay");
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Connection = con1;
            SqlDataReader DR1 = cmd1.ExecuteReader();
           
            if (DR1.Read())
            {
                ch1 = DR1.GetValue(0).ToString();
            }
            con1.Close();
               //2
            SqlConnection con2 = db1.getconnection();
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("report_chart");
            cmd2.Parameters.AddWithValue("@StatementType", "total_coach_pay");
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Connection = con2;
            SqlDataReader DR2 = cmd2.ExecuteReader();

            if (DR2.Read())
            {
                ch2 = DR2.GetValue(0).ToString();
            }
            con2.Close();

            //3
            SqlConnection con3 = db1.getconnection();
            con3.Open();
            SqlCommand cmd3 = new SqlCommand("report_chart");
            cmd3.Parameters.AddWithValue("@StatementType", "total_member_pay");
            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.Connection = con3;
            SqlDataReader DR3 = cmd3.ExecuteReader();

            if (DR3.Read())
            {
                ch3 = DR3.GetValue(0).ToString();
            }
            con3.Close();

            //4
            SqlConnection con4 = db1.getconnection();
            con4.Open();
            SqlCommand cmd4 = new SqlCommand("report_chart");
            cmd4.Parameters.AddWithValue("@StatementType", "total_suppliment_pay");
            cmd4.CommandType = CommandType.StoredProcedure;
            cmd4.Connection = con4;
            SqlDataReader DR4 = cmd4.ExecuteReader();

            if (DR4.Read())
            {
                ch4 = DR4.GetValue(0).ToString();
            }
            con4.Close();



        //    chart2.Titles.Add("Total Budget");
            chart2.Series["C1"].Points.AddXY("Bill",ch1);
            chart2.Series["C1"].Points.AddXY("Coach",ch2);
            chart2.Series["C1"].Points.AddXY("Member",ch3);
            chart2.Series["C1"].Points.AddXY("Supplement",ch4);
            label2.Text = "Total Bill Payment : Rs " + ch1;
            label3.Text = "Total Coach Payment : Rs " + ch2;
            label4.Text = "Total Member Payment : Rs " + ch3;
            label5.Text = "Total Supplement Payment : Rs " + ch4;



            //  c3 monthly
            SqlConnection con5 = db1.getconnection();
            con1.Open();
            SqlCommand cmd5 = new SqlCommand("report_chart");
            cmd5.Parameters.AddWithValue("@StatementType", "bill_pay_month");
            cmd5.CommandType = CommandType.StoredProcedure;
            cmd5.Connection = con5;
            SqlDataReader DR5 = cmd1.ExecuteReader();

            if (DR5.Read())
            {
                ch5 = DR5.GetValue(0).ToString();
            }
            con1.Close();
            //2
            SqlConnection con6 = db1.getconnection();
            con6.Open();
            SqlCommand cmd6 = new SqlCommand("report_chart");
            cmd6.Parameters.AddWithValue("@StatementType", "coach_pay_month");
            cmd6.CommandType = CommandType.StoredProcedure;
            cmd6.Connection = con6;
            SqlDataReader DR6 = cmd6.ExecuteReader();

            if (DR6.Read())
            {
                ch6 = DR6.GetValue(0).ToString();
            }
            con6.Close();

            //3
            SqlConnection con7 = db1.getconnection();
            con7.Open();
            SqlCommand cmd7 = new SqlCommand("report_chart");
            cmd7.Parameters.AddWithValue("@StatementType", "member_pay_month");
            cmd7.CommandType = CommandType.StoredProcedure;
            cmd7.Connection = con7;
            SqlDataReader DR7= cmd7.ExecuteReader();

            if (DR7.Read())
            {
                ch7 = DR7.GetValue(0).ToString();
            }
            con7.Close();

            //4
            SqlConnection con8 = db1.getconnection();
            con4.Open();
            SqlCommand cmd8 = new SqlCommand("report_chart");
            cmd8.Parameters.AddWithValue("@StatementType", "suppliment_pay_month");
            cmd8.CommandType = CommandType.StoredProcedure;
            cmd8.Connection = con8;
            SqlDataReader DR8 = cmd4.ExecuteReader();

            if (DR8.Read())
            {
                ch8 = DR8.GetValue(0).ToString();
            }
            con8.Close();



        //    chart1.Titles.Add("Total Budget");
            chart1.Series["C3"].Points.AddXY("Bill", ch5);
            chart1.Series["C3"].Points.AddXY("Coach", ch6);
            chart1.Series["C3"].Points.AddXY("Member", ch7);
            chart1.Series["C3"].Points.AddXY("Supplement", ch8);
            label6.Text = "Last Month Bill Payment : Rs " + ch5;
            label7.Text = "Last Month Coach Payment : Rs " + ch6;
            label8.Text = "Last Month Member Payment : Rs " + ch7;
            label9.Text = "Last Month Supplement Payment : Rs " + ch8;
        }
        private void chart2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        //    chart1.Series[abc1].Points.AddXY("MyPointName", value1);
         //   chart1.Series[seriesname].Points.AddXY("MyPointName1", value2);
         //   chart1.Series[seriesname].Points.AddXY("MyPointName2", value3);
        }

        private void income_reports_Load(object sender, EventArgs e)
        {

        }

        private void chart2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
