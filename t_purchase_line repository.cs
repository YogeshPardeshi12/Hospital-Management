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
    public class t_purchase_line_repository
    {
        public void SaveOrUpdate(t_purchase_line_model model)
        {
            SqlCommand sqlcmd = new SqlCommand();
            connection con = new connection();
            try
            {
                SqlConnection sqlcon = con.Connect();
                sqlcmd.CommandText = ("[dbo].[t_purchase_line]");
                sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlcmd.Connection = sqlcon;
                sqlcmd.Parameters.AddWithValue("@purchase_line_id", model.purchase_line_id);
                sqlcmd.Parameters.AddWithValue("@purchase_hedar", model.purchase_hedar);
                sqlcmd.Parameters.AddWithValue("@client_id", model.client_id);
                sqlcmd.Parameters.AddWithValue("@global_id", model.global_id);
                sqlcmd.Parameters.AddWithValue("@item_id", model.item_id);
                sqlcmd.Parameters.AddWithValue("@item_qty", model.item_qty);
                sqlcmd.Parameters.AddWithValue("@item_total_strip_qty", model.item_total_strip_qty);
                sqlcmd.Parameters.AddWithValue("@item_strip_qty", model.item_strip_qty);
                sqlcmd.Parameters.AddWithValue("@item_per_unit_rate", model.item_per_unit_rate);
                sqlcmd.Parameters.AddWithValue("@item_unit", model.item_unit);
                sqlcmd.Parameters.AddWithValue("@item_rate", model.item_rate);
                sqlcmd.Parameters.AddWithValue("@item_packing", model.item_packing);
                sqlcmd.Parameters.AddWithValue("@tax_id", model.tax_id);
                sqlcmd.Parameters.AddWithValue("@godown_id", model.godown_id);
                sqlcmd.Parameters.AddWithValue("@branch_id", model.branch_id);
                sqlcmd.Parameters.AddWithValue("@delivery_date", model.delivery_date);
                sqlcmd.Parameters.AddWithValue("@total_amount", model.total_amount);
                sqlcmd.Parameters.AddWithValue("@tax_type", model.tax_type);
                sqlcmd.Parameters.AddWithValue("@basic_amount", model.basic_amount);
                sqlcmd.Parameters.AddWithValue("@tax_amount", model.tax_amount);
                sqlcmd.Parameters.AddWithValue("@quality_check", model.quality_check);
                sqlcmd.Parameters.AddWithValue("@batch_no", model.batch_no);
                sqlcmd.Parameters.AddWithValue("@batch_date", model.batch_date);
                sqlcmd.Parameters.AddWithValue("@Expire_date", model.Expire_date);
                sqlcmd.Parameters.AddWithValue("@item_mrp", model.item_mrp);
                sqlcmd.Parameters.AddWithValue("@item_discount", model.item_discount);
                sqlcmd.Parameters.AddWithValue("@item_medi_rate", model.item_medi_rate);
                sqlcmd.Parameters.AddWithValue("@medi_Qty", model.medi_Qty);
                sqlcmd.Parameters.AddWithValue("@gst_vat", model.gst_vat);
                sqlcmd.Parameters.AddWithValue("@sgst", model.sgst);
                sqlcmd.Parameters.AddWithValue("@igst", model.igst);
                sqlcmd.Parameters.AddWithValue("@medi_total_amount", model.medi_total_amount);
                sqlcmd.Parameters.AddWithValue("@created_by", model.created_by);
                sqlcmd.Parameters.AddWithValue("@updated_by", model.updated_by);
                sqlcmd.Parameters.AddWithValue("@created_date", model.created_date);
                sqlcmd.Parameters.AddWithValue("@updated_date", model.updated_date);
                sqlcmd.Parameters.AddWithValue("@attr1", model.attr1);
                sqlcmd.Parameters.AddWithValue("@attr2", model.attr2);
                sqlcmd.Parameters.AddWithValue("@attr3", model.attr3);
                sqlcmd.Parameters.AddWithValue("@attr4", model.attr4);
                sqlcmd.Parameters.AddWithValue("@attr5", model.attr5);
                sqlcmd.Parameters.AddWithValue("@attr6", model.attr6);
                sqlcmd.Parameters.AddWithValue("@attr7", model.attr7);
                sqlcmd.Parameters.AddWithValue("@hsn_code", model.hsn_code);
                sqlcmd.Parameters.AddWithValue("@sach_discount", model.sach_discount);
                sqlcmd.Parameters.AddWithValue("@company_name", model.company_name);
                sqlcmd.Parameters.AddWithValue("@free_qty", model.free_qty);
                sqlcmd.Parameters.AddWithValue("@packing_id", model.packing_id);
                sqlcmd.Parameters.AddWithValue("@discount_amount", model.discount_amount);
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
