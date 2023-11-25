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
    public class t_medicen_sale_hedar_repository
    {
        public void SaveOrUpdate(t_medicen_sale_hedar_model model)
        {
            SqlCommand sqlcmd = new SqlCommand();
            connection con = new connection();
            try
            {
                SqlConnection sqlcon = con.Connect();
                sqlcmd.CommandText = ("[dbo].[t_medicen_sale_hedar]");
                sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlcmd.Connection = sqlcon;
                sqlcmd.Parameters.AddWithValue("@sale_hedar_id", model.sale_hedar_id);
                sqlcmd.Parameters.AddWithValue("@sale_date", model.sale_date);
                sqlcmd.Parameters.AddWithValue("@client_id", model.client_id);
                sqlcmd.Parameters.AddWithValue("@global_id", model.global_id);
                sqlcmd.Parameters.AddWithValue("@sale_document_number", model.sale_document_number);
                sqlcmd.Parameters.AddWithValue("@customer_name", model.customer_name);
                sqlcmd.Parameters.AddWithValue("@discount_percentage", model.discount_percentage);
                sqlcmd.Parameters.AddWithValue("@dicount_in_rupees", model.dicount_in_rupees);
                sqlcmd.Parameters.AddWithValue("@discount_amount_percentage", model.discount_amount_percentage);
                sqlcmd.Parameters.AddWithValue("@discount_amount_roupees", model.discount_amount_roupees);
                sqlcmd.Parameters.AddWithValue("@total_amoun", model.total_amoun);
                sqlcmd.Parameters.AddWithValue("@contact_no", model.contact_no);
                sqlcmd.Parameters.AddWithValue("@dr_name", model.dr_name);
                sqlcmd.Parameters.AddWithValue("@address", model.address);
                sqlcmd.Parameters.AddWithValue("@attr1", model.attr1);
                sqlcmd.Parameters.AddWithValue("@attr2", model.attr2);
                sqlcmd.Parameters.AddWithValue("@created_date", model.created_date);
                sqlcmd.Parameters.AddWithValue("@updated_date", model.updated_date);
                sqlcmd.Parameters.AddWithValue("@created_by", model.created_by);
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
