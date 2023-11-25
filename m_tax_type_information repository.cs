using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_Managment.Models;
using Hospital_Managment.Connection;
using System.Data.SqlClient;
using Hospital_Managment.Repository;
using System.ComponentModel.Design;
using System.Data.SqlTypes;
using System.Reflection;


namespace Hospital_Managment.Repository
{
    public class m_tax_type_information_repository
    {
        public void SaveOrUpdate(m_tax_type_information_model model)
        {
            SqlCommand sqlcmd = new SqlCommand();
            connection con = new connection();
            try
            {
                SqlConnection sqlcon = con.Connect();
                sqlcmd.CommandText = ("[dbo].[m_tax_type_information]");
                sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlcmd.Connection = sqlcon;
                sqlcmd.Parameters.AddWithValue("@tax_id", model.tax_id);
                sqlcmd.Parameters.AddWithValue("@tax_name", model.tax_name);
                sqlcmd.Parameters.AddWithValue("@tax_percent", model.tax_percent);
                sqlcmd.Parameters.AddWithValue("@tax_group_id", model.tax_group_id);
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                sqlcmd.Dispose();
            }
        }
    }
}
