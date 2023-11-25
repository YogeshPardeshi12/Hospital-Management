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
    public class m_client_registration_repository
    {
        public void SaveOrUpdate(m_client_registration_model model)
        {
            SqlCommand sqlcmd = new SqlCommand();
            connection con = new connection();
            try
            {
                SqlConnection sqlcon = con.Connect();
                sqlcmd.CommandText = ("[dbo].[m_client_registration]");
                sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlcmd.Connection = sqlcon;
                sqlcmd.Parameters.AddWithValue("@client_id", model.client_id);
                sqlcmd.Parameters.AddWithValue("@client_code", model.client_code);
                sqlcmd.Parameters.AddWithValue("@client_global_id", model.client_global_id);
                sqlcmd.Parameters.AddWithValue("@client_name", model.client_name);
                sqlcmd.Parameters.AddWithValue("@client_address", model.client_address);
                sqlcmd.Parameters.AddWithValue("@client_phone", model.client_phone);
                sqlcmd.Parameters.AddWithValue("@client_city", model.client_city);
                sqlcmd.Parameters.AddWithValue("@busniess_name", model.busniess_name);
                sqlcmd.Parameters.AddWithValue("@client_pan", model.client_pan);
                sqlcmd.Parameters.AddWithValue("@client_registration_no", model.client_registration_no);
                sqlcmd.Parameters.AddWithValue("@client_gst", model.client_gst);
                sqlcmd.Parameters.AddWithValue("@client_logo", model.client_logo);
                sqlcmd.Parameters.AddWithValue("@client_email", model.client_email);
                sqlcmd.Parameters.AddWithValue("@password", model.password);
                sqlcmd.Parameters.AddWithValue("@user_name", model.user_name);
                sqlcmd.Parameters.AddWithValue("@created_by", model.created_by);
                sqlcmd.Parameters.AddWithValue("@created_date", model.created_date);
                sqlcmd.Parameters.AddWithValue("@updated_date", model.updated_date);
                sqlcmd.Parameters.AddWithValue("@active_flag", model.active_flag);
                sqlcmd.Parameters.AddWithValue("@attr1", model.attr1);
                sqlcmd.Parameters.AddWithValue("@attr2", model.attr2);
                sqlcmd.Parameters.AddWithValue("@attr3", model.attr3);
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
