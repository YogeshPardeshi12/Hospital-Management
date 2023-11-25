using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment.Models
{
    public class a_m_lookup_line_model
    {
        public int line_id { get; set; }
        public int client_id { get; set; }
        public int gloabl_id { get; set; }
        public int lookup_id { get; set; }
        public string line_name { get; set; }
        public string line_description { get; set; }
        public int created_by { get; set; }
        public DateTime created_date { get; set; }
        public int updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public string flag { get; set; }
    }
}
