using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment.Models
{
    public class a_m_lookup_hedar_model
    {
        public int lookup_id { get; set; }
        public int client_id { get; set; }
        public int global_id { get; set; }
        public string lookup_name { get; set; }
        public string lookup_description { get; set; }
        public int created_by { get; set; }
        public DateTime created_date { get; set; }
        public int updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public string active_flag { get; set; }
        public string flag { get; set; }
    }
}
