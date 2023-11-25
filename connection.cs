using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment.Connection
{
    public class connection
    {
        string cs = "Data Source =DESKTOP-96VFSU5;Initial Catalog =[Db_Hospital_Managment];Integrated Security=True";
        public SqlConnection Connect()
        {
            SqlConnection Sqlcon = new SqlConnection();
            Sqlcon.Close();
            if (Sqlcon.State == System.Data.ConnectionState.Closed)
            {
                Sqlcon.Open();
            }
            return Sqlcon;
        }
    }
}
