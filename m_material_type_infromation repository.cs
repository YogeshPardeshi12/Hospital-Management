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
    public class m_material_type_infromation_repository
    {
        public void SaveOrUpdate(m_material_type_infromation_model model)
        {
            SqlCommand sqlcmd = new SqlCommand();
            connection con = new connection();
            try
            {
                SqlConnection sqlcon = con.Connect();
                sqlcmd.CommandText = ("[dbo].[m_material_type_infromation]");
                sqlcmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlcmd.Connection = sqlcon;
                sqlcmd.Parameters.AddWithValue("@material_type_id", model.material_type_id);
                sqlcmd.Parameters.AddWithValue("@material_type", model.material_type);
                sqlcmd.Parameters.AddWithValue("@global_id", model.global_id);
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
