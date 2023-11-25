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
    public class m_user_Login_information_repository
    {
        public void SaveOrUpdate(m_user_Login_information_model model)
        {
            SqlCommand sqlcmd = new SqlCommand();
            connection con = new connection();
            try
            {
                SqlConnection sqlcon = con.Connect();
                sqlcmd.CommandText = ("[dbo].[m_user_Login_information]");
                sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlcmd.Connection = sqlcon;
                sqlcmd.Parameters.AddWithValue("@user_id", model.user_id);
                sqlcmd.Parameters.AddWithValue("@user_name", model.user_name);
                sqlcmd.Parameters.AddWithValue("@user_password", model.user_password);
                sqlcmd.Parameters.AddWithValue("@user_confirm_password", model.user_confirm_password);
                sqlcmd.Parameters.AddWithValue("@Employee_id", model.Employee_id);
                sqlcmd.Parameters.AddWithValue("@created_by", model.created_by);
                sqlcmd.Parameters.AddWithValue("@created_date", model.created_date);
                sqlcmd.Parameters.AddWithValue("@updated_by", model.updated_by);
                sqlcmd.Parameters.AddWithValue("@update_date", model.update_date);
                sqlcmd.Parameters.AddWithValue("@attr1", model.attr1);
                sqlcmd.Parameters.AddWithValue("@attr2", model.attr2);
                sqlcmd.Parameters.AddWithValue("@attr3", model.attr3);
                sqlcmd.Parameters.AddWithValue("@attr4", model.attr4);
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
