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
    public class m_department_information_repository
    {
        public void SaveOrUpdate(m_department_information_model model)
        {
            SqlCommand sqlcmd = new SqlCommand();
            connection con = new connection();
            try
            {
                SqlConnection sqlcon = con.Connect();
                sqlcmd.CommandText = ("[dbo].[m_department_information]");
                sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlcmd.Connection = sqlcon;
                sqlcmd.Parameters.AddWithValue("@department_id", model.department_id);
                sqlcmd.Parameters.AddWithValue("@department_start_date", model.department_start_date);
                sqlcmd.Parameters.AddWithValue("@department_code", model.department_code);
                sqlcmd.Parameters.AddWithValue("@department_name", model.department_name);
                sqlcmd.Parameters.AddWithValue("@deparment_address", model.deparment_address);
                sqlcmd.Parameters.AddWithValue("@deparment_description", model.deparment_description);
                sqlcmd.Parameters.AddWithValue("@hospital_id", model.hospital_id);
                sqlcmd.Parameters.AddWithValue("@created_by", model.created_by);
                sqlcmd.Parameters.AddWithValue("@created_date", model.created_date);
                sqlcmd.Parameters.AddWithValue("@updated_date", model.updated_date);
                sqlcmd.Parameters.AddWithValue("@updated_by", model.updated_by);
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
