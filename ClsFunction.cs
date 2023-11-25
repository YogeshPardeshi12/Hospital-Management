using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_Managment.Connection;
using Hospital_Managment.Models;
using Hospital_Managment.Repository;

namespace Hospital_Managment.Repository
{
    public class ClsFunction
    {
        public void Errorlog(String ClassName, string FunctionName, string ErrorMessage, string ErrorData, string ErrorLine, DateTime ErrorDate)
        {
            connection con = new connection();
            SqlConnection sqlcon = con.Connect();
            SqlCommand sqlcmd = new SqlCommand();
            try
            {
                sqlcmd.CommandText = ("[dbo].[Ado_Sp_m_ErrorLog]");
                sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlcmd.Connection = sqlcon;
                sqlcmd.Parameters.AddWithValue("@ClassName", ClassName);
                sqlcmd.Parameters.AddWithValue("FunctionName", FunctionName);
                sqlcmd.Parameters.AddWithValue("@ErrorMessage", ErrorMessage);
                sqlcmd.Parameters.AddWithValue("@ErrorData", ErrorData);
                sqlcmd.Parameters.AddWithValue("@ErrorLine", ErrorLine);
                sqlcmd.Parameters.AddWithValue("@ErrorDate", ErrorDate);
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                sqlcon.Close();
                sqlcmd.Dispose();
            }
        }
    }
}
