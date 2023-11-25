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
    public class t_medicen_sale_line_repository
    {
        public void SaveOrUpdate(t_medicen_sale_line_model model)
        {
            SqlCommand sqlcmd = new SqlCommand();
            connection con = new connection();
            try
            {
                SqlConnection sqlcon = con.Connect();
                sqlcmd.CommandText = ("[dbo].[t_medicen_sale_line]");
                sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlcmd.Connection = sqlcon;
                sqlcmd.Parameters.AddWithValue("@sale_line_id", model.sale_line_id);
                sqlcmd.Parameters.AddWithValue("@sale_hedar_id", model.sale_hedar_id);
                sqlcmd.Parameters.AddWithValue("@purchase_line_id", model.purchase_line_id);
                sqlcmd.Parameters.AddWithValue("@item_id", model.item_id);
                sqlcmd.Parameters.AddWithValue("@item_name", model.item_name);
                sqlcmd.Parameters.AddWithValue("@item_batch", model.item_batch);
                sqlcmd.Parameters.AddWithValue("@item_pckg", model.item_pckg);
                sqlcmd.Parameters.AddWithValue("@item_exp_date", model.item_exp_date);
                sqlcmd.Parameters.AddWithValue("@item_mfg", model.item_mfg);
                sqlcmd.Parameters.AddWithValue("@item_qty", model.item_qty);
                sqlcmd.Parameters.AddWithValue("@item_mrp", model.item_mrp);
                sqlcmd.Parameters.AddWithValue("@item_total_amount", model.item_total_amount);
                sqlcmd.Parameters.AddWithValue("@discount", model.discount);
                sqlcmd.Parameters.AddWithValue("@paid_unpaid", model.paid_unpaid);
                sqlcmd.Parameters.AddWithValue("@attr1", model.attr1);
                sqlcmd.Parameters.AddWithValue("@attr2", model.attr2);
                sqlcmd.Parameters.AddWithValue("@attr3", model.attr3);
                sqlcmd.Parameters.AddWithValue("@created_by", model.created_by);
                sqlcmd.Parameters.AddWithValue("@updated_by", model.updated_by);
                sqlcmd.Parameters.AddWithValue("@created_date", model.created_date);
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
