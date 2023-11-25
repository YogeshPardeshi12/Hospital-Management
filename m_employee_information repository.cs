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
    public class m_employee_information_repository
    {
        public void SaveOrUpdate(m_employee_information_model model)
        {
            SqlCommand sqlcmd = new SqlCommand();
            connection con = new connection();
            try
            {
                SqlConnection sqlcon = con.Connect();
                sqlcmd.CommandText = ("[dbo].[m_employee_information]");
                sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlcmd.Connection = sqlcon;
                sqlcmd.Parameters.AddWithValue("@employee_id", model.employee_id);
                sqlcmd.Parameters.AddWithValue("@employee_code", model.employee_code);
                sqlcmd.Parameters.AddWithValue("@employee_title", model.employee_title);
                sqlcmd.Parameters.AddWithValue("@employee_gender", model.employee_gender);
                sqlcmd.Parameters.AddWithValue("@employee_name", model.employee_name);
                sqlcmd.Parameters.AddWithValue("@employye_designation", model.employye_designation);
                sqlcmd.Parameters.AddWithValue("@employee_department", model.employee_department);
                sqlcmd.Parameters.AddWithValue("@employee_dob", model.employee_dob);
                sqlcmd.Parameters.AddWithValue("@employee_joing_date", model.employee_joing_date);
                sqlcmd.Parameters.AddWithValue("@employee_Address", model.employee_Address);
                sqlcmd.Parameters.AddWithValue("@employee_Address1", model.employee_Address1);
                sqlcmd.Parameters.AddWithValue("@employee_city", model.employee_city);
                sqlcmd.Parameters.AddWithValue("@employee_pan", model.employee_pan);
                sqlcmd.Parameters.AddWithValue("@employee_adharchard", model.employee_adharchard);
                sqlcmd.Parameters.AddWithValue("@employee_alternet_no", model.employee_alternet_no);
                sqlcmd.Parameters.AddWithValue("@employee_mobile", model.employee_mobile);
                sqlcmd.Parameters.AddWithValue("@employee_email_id", model.employee_email_id);
                sqlcmd.Parameters.AddWithValue("@employee_bank_name", model.employee_bank_name);
                sqlcmd.Parameters.AddWithValue("@employee_account_no", model.employee_account_no);
                sqlcmd.Parameters.AddWithValue("@employee_ifsc_code", model.employee_ifsc_code);
                sqlcmd.Parameters.AddWithValue("@employee_branch", model.employee_branch);
                sqlcmd.Parameters.AddWithValue("@employee_photo", model.employee_photo);
                sqlcmd.Parameters.AddWithValue("@created_by", model.created_by);
                sqlcmd.Parameters.AddWithValue("@updated_by", model.updated_by);
                sqlcmd.Parameters.AddWithValue("@created_date", model.created_date);
                sqlcmd.Parameters.AddWithValue("@updated_date", model.updated_date);
                sqlcmd.Parameters.AddWithValue("@active_flag", model.active_flag);
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
            };
        }
    }
}
