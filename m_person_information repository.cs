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
    public class m_person_information_repository
    {
        public void SaveOrUpdate(m_person_information_model model)
        {
            SqlCommand sqlcmd = new SqlCommand();
            connection con = new connection();
            try
            {
                SqlConnection sqlcon = con.Connect();
                sqlcmd.CommandText = ("[dbo].[m_person_information]");
                sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlcmd.Connection = sqlcon;
                sqlcmd.Parameters.AddWithValue("@person_id", model.person_id);
                sqlcmd.Parameters.AddWithValue("@client_id", model.client_id);
                sqlcmd.Parameters.AddWithValue("@global_id", model.global_id);
                sqlcmd.Parameters.AddWithValue("@module_id", model.module_id);
                sqlcmd.Parameters.AddWithValue("@person_code", model.person_code);
                sqlcmd.Parameters.AddWithValue("@person_type", model.person_type);
                sqlcmd.Parameters.AddWithValue("@person_name", model.person_name);
                sqlcmd.Parameters.AddWithValue("@person_address", model.person_address);
                sqlcmd.Parameters.AddWithValue("@person_email_id", model.person_email_id);
                sqlcmd.Parameters.AddWithValue("@person_contact_number", model.person_contact_number);
                sqlcmd.Parameters.AddWithValue("@person_bussness_name", model.person_bussness_name);
                sqlcmd.Parameters.AddWithValue("@person_office_number", model.person_office_number);
                sqlcmd.Parameters.AddWithValue("@person_pan_card", model.person_pan_card);
                sqlcmd.Parameters.AddWithValue("@person_city", model.person_city);
                sqlcmd.Parameters.AddWithValue("@person_bank_name", model.person_bank_name);
                sqlcmd.Parameters.AddWithValue("@person_account_number", model.person_account_number);
                sqlcmd.Parameters.AddWithValue("@person_gst_number", model.person_gst_number);
                sqlcmd.Parameters.AddWithValue("@payment_terms", model.payment_terms);
                sqlcmd.Parameters.AddWithValue("@created_by", model.created_by);
                sqlcmd.Parameters.AddWithValue("@created_date", model.created_date);
                sqlcmd.Parameters.AddWithValue("@updated_by", model.updated_by);
                sqlcmd.Parameters.AddWithValue("@updated_date", model.updated_date);
                sqlcmd.Parameters.AddWithValue("@active_flag", model.active_flag);
                sqlcmd.Parameters.AddWithValue("@attr1", model.attr1);
                sqlcmd.Parameters.AddWithValue("@attr2", model.attr2);
                sqlcmd.Parameters.AddWithValue("@attr3", model.attr3);
                sqlcmd.Parameters.AddWithValue("@attr4", model.attr4);
                sqlcmd.Parameters.AddWithValue("@attr5", model.attr5);
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
