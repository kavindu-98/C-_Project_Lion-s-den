using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lion_s_den_Gym
{
   public  class databaseclass
    {
        public SqlConnection getconnection()
        {
            
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Lion's den-9\Lion_s den-9\Lion_s den\lgym\Lion_s_den_Gym\jim_database-1.mdf;Integrated Security=True");
           
            return con;
          
        }
    }
}
