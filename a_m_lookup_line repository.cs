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
    public class a_m_lookup_line_repository
    {
        public void SaveOrUpdate(a_m_lookup_line_model model)
        {
            SqlCommand sqlcmd = new SqlCommand();
            connection con = new connection();
            try
            {
                SqlConnection sqlcon = con.Connect();
                sqlcmd.CommandText = ("[dbo].[a_m_lookup_line]");
                sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlcmd.Connection = sqlcon;
                sqlcmd.Parameters.AddWithValue("@line_id", model.line_id);
                sqlcmd.Parameters.AddWithValue("@client_id", model.client_id);
                sqlcmd.Parameters.AddWithValue("@gloabl_id", model.gloabl_id);
                sqlcmd.Parameters.AddWithValue("@lookup_id", model.lookup_id);
                sqlcmd.Parameters.AddWithValue("@line_name", model.line_name);
                sqlcmd.Parameters.AddWithValue("@line_description", model.line_description);
                sqlcmd.Parameters.AddWithValue("@created_by", model.created_by);
                sqlcmd.Parameters.AddWithValue("@created_date", model.created_date);
                sqlcmd.Parameters.AddWithValue("@updated_by", model.updated_by);
                sqlcmd.Parameters.AddWithValue("@updated_date", model.updated_date);
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
