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
    public class t_purchase_hedar_repository
    {
        public void SaveOrUpdate(t_purchase_hedar_model model)
        {
            SqlCommand sqlcmd = new SqlCommand();
            connection con = new connection();
            try
            {
                SqlConnection sqlcon = con.Connect();
                sqlcmd.CommandText = ("[dbo].[t_purchase_hedar]");
                sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlcmd.Connection = sqlcon;
                sqlcmd.Parameters.AddWithValue("@purchase_hedar_id", model.purchase_hedar_id);
                sqlcmd.Parameters.AddWithValue("@client_id", model.client_id);
                sqlcmd.Parameters.AddWithValue("@global_id", model.global_id);
                sqlcmd.Parameters.AddWithValue("@purchase_document_no", model.purchase_document_no);
                sqlcmd.Parameters.AddWithValue("@purchase_status", model.purchase_status);
                sqlcmd.Parameters.AddWithValue("@purchase_approv_by", model.purchase_approv_by);
                sqlcmd.Parameters.AddWithValue("@approve_date", model.approve_date);
                sqlcmd.Parameters.AddWithValue("@purchase_date", model.purchase_date);
                sqlcmd.Parameters.AddWithValue("@purchase_total_amount", model.purchase_total_amount);
                sqlcmd.Parameters.AddWithValue("@purchase_type", model.purchase_type);
                sqlcmd.Parameters.AddWithValue("@supplier_id", model.supplier_id);
                sqlcmd.Parameters.AddWithValue("@pay_terms", model.pay_terms);
                sqlcmd.Parameters.AddWithValue("@agent_id", model.agent_id);
                sqlcmd.Parameters.AddWithValue("@commision", model.commision);
                sqlcmd.Parameters.AddWithValue("@commision_Amount", model.commision_Amount);
                sqlcmd.Parameters.AddWithValue("@total_purchase_amount_hedar", model.total_purchase_amount_hedar);
                sqlcmd.Parameters.AddWithValue("@remark", model.remark);
                sqlcmd.Parameters.AddWithValue("@created_by", model.created_by);
                sqlcmd.Parameters.AddWithValue("@created_date", model.created_date);
                sqlcmd.Parameters.AddWithValue("@updated_date", model.updated_date);
                sqlcmd.Parameters.AddWithValue("@updated_by", model.updated_by);
                sqlcmd.Parameters.AddWithValue("@attr1", model.attr1);
                sqlcmd.Parameters.AddWithValue("@attr2", model.attr2);
                sqlcmd.Parameters.AddWithValue("@attr3", model.attr3);
                sqlcmd.Parameters.AddWithValue("@attr4", model.attr4);
                sqlcmd.Parameters.AddWithValue("@attr5", model.attr5);
                sqlcmd.Parameters.AddWithValue("@attr6", model.attr6);
                sqlcmd.Parameters.AddWithValue("@attr7", model.attr7);
                sqlcmd.Parameters.AddWithValue("@attr8", model.attr8);
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
