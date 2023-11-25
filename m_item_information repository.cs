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
    public class m_item_information_repository
    {
        public void SaveOrUpdate(m_item_information_model model)
        {
            SqlCommand sqlcmd = new SqlCommand();
            connection con = new connection();
            try
            {
                SqlConnection sqlcon = con.Connect();
                sqlcmd.CommandText =("[dbo].[m_item_information]");
                sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlcmd.Connection = sqlcon;
                sqlcmd.Parameters.AddWithValue("@item_id", model.item_id);
                sqlcmd.Parameters.AddWithValue("@item_code", model.item_code);
                sqlcmd.Parameters.AddWithValue("@item_type", model.item_type);
                sqlcmd.Parameters.AddWithValue("@item_name", model.item_name);
                sqlcmd.Parameters.AddWithValue("@item_manufaction_name", model.item_manufaction_name);
                sqlcmd.Parameters.AddWithValue("@item_pacinking", model.item_pacinking);
                sqlcmd.Parameters.AddWithValue("@item_use_name", model.item_use_name);
                sqlcmd.Parameters.AddWithValue("@item_description", model.item_description);
                sqlcmd.Parameters.AddWithValue("@item_start_date", model.item_start_date);
                sqlcmd.Parameters.AddWithValue("@item_end_date", model.item_end_date);
                sqlcmd.Parameters.AddWithValue("@item_first_unit", model.item_first_unit);
                sqlcmd.Parameters.AddWithValue("@item_second_unit", model.item_second_unit);
                sqlcmd.Parameters.AddWithValue("@item_conversion_first_factor", model.item_conversion_first_factor);
                sqlcmd.Parameters.AddWithValue("@item_conversion_second_factor", model.item_conversion_second_factor);
                sqlcmd.Parameters.AddWithValue("@item_is_stockebal", model.item_is_stockebal);
                sqlcmd.Parameters.AddWithValue("@item_quality_check", model.item_quality_check);
                sqlcmd.Parameters.AddWithValue("@item_return_policy", model.item_return_policy);
                sqlcmd.Parameters.AddWithValue("@item_min_qty", model.item_min_qty);
                sqlcmd.Parameters.AddWithValue("@item_max_qty", model.item_max_qty);
                sqlcmd.Parameters.AddWithValue("@item_hsn_code", model.item_hsn_code);
                sqlcmd.Parameters.AddWithValue("@item_po_type", model.item_po_type);
                sqlcmd.Parameters.AddWithValue("@item_tax_apply", model.item_tax_apply);
                sqlcmd.Parameters.AddWithValue("@item_po_tax_group", model.item_po_tax_group);
                sqlcmd.Parameters.AddWithValue("@item_sale_tax_group", model.item_sale_tax_group);
                sqlcmd.Parameters.AddWithValue("@created_by", model.created_by);
                sqlcmd.Parameters.AddWithValue("@created_date", model.created_date);
                sqlcmd.Parameters.AddWithValue("@updated_by", model.updated_by);
                sqlcmd.Parameters.AddWithValue("@updated_date", model.updated_date);
                sqlcmd.Parameters.AddWithValue("@activ_flag", model.activ_flag);
                sqlcmd.Parameters.AddWithValue("@attr1", model.attr1);
                sqlcmd.Parameters.AddWithValue("@attr2", model.attr2);
                sqlcmd.Parameters.AddWithValue("@attr3", model.attr3);
                sqlcmd.Parameters.AddWithValue("@attr4", model.attr4);
                sqlcmd.Parameters.AddWithValue("@attr5", model.attr5);
                sqlcmd.Parameters.AddWithValue("@attr6", model.attr6);
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
