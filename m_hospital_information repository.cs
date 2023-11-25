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
    public class m_hospital_information_repository
    {
        public void SaveOrUpdate(m_hospital_information_model model)
        {
            SqlCommand sqlcmd = new SqlCommand();
            connection con = new connection();
            try
            {
                SqlConnection sqlcon = con.Connect();
                sqlcmd.CommandText = ("[dbo].[m_hospital_information]");
                sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlcmd.Connection = sqlcon;
                sqlcmd.Parameters.AddWithValue("@hospital_id", model.hospital_id);
                sqlcmd.Parameters.AddWithValue("@hospital_name", model.hospital_name);
                sqlcmd.Parameters.AddWithValue("@hospital_address", model.hospital_address);
                sqlcmd.Parameters.AddWithValue("@hospital_email_address", model.hospital_email_address);
                sqlcmd.Parameters.AddWithValue("@logo", model.logo);
                sqlcmd.Parameters.AddWithValue("@hospital_city", model.hospital_city);
                sqlcmd.Parameters.AddWithValue("@hospital_pan", model.hospital_pan);
                sqlcmd.Parameters.AddWithValue("@hospital_gst_number", model.hospital_gst_number);
                sqlcmd.Parameters.AddWithValue("@hospital_contact_number", model.hospital_contact_number);
                sqlcmd.Parameters.AddWithValue("@hospital_contact_number1", model.hospital_contact_number1);
                sqlcmd.Parameters.AddWithValue("@hospital_web_site", model.hospital_web_site);
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
