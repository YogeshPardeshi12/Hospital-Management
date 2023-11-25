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
    public class a_m_lookup_hedar_repository
    {
        public void SaveOrUpdate(a_m_lookup_hedar_model model)
        {
            SqlCommand Sqlcmd = new SqlCommand();
            connection con = new connection();
            SqlConnection Sqlcon = con.Connect();
            try
            {
                Sqlcmd.CommandText = ("[dbo].[a_m_lookup_hedar]");
                Sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
                Sqlcmd.Connection = Sqlcon;
                Sqlcmd.Parameters.AddWithValue("@lookup_id", model.lookup_id);
                Sqlcmd.Parameters.AddWithValue("@client_id", model.client_id);
                Sqlcmd.Parameters.AddWithValue("@global_id", model.global_id);
                Sqlcmd.Parameters.AddWithValue("@lookup_name", model.lookup_name);
                Sqlcmd.Parameters.AddWithValue("@lookup_description", model.lookup_description);
                Sqlcmd.Parameters.AddWithValue("@created_by", model.created_by);
                Sqlcmd.Parameters.AddWithValue("@created_date", model.created_date);
                Sqlcmd.Parameters.AddWithValue("@updated_by", model.updated_by);
                Sqlcmd.Parameters.AddWithValue("@updated_date", model.updated_date);
                Sqlcmd.Parameters.AddWithValue("@active_flag", model.active_flag);
                Sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
                ClsFunction cls = new ClsFunction();

            }
            finally
            {
                Sqlcmd.Dispose();
                Sqlcon.Close();
            }
        }
    }
}
