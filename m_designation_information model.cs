using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment.Models
{
    public class m_designation_information_model
    {
        public int designation_id { get; set; }
        public string designation_code { get; set; }
        public string designation_name { get; set; }
        public string designation_qualification { get; set; }
        public string designation_description { get; set; }
        public DateTime created_date { get; set; }
        public DateTime updated_date { get; set; }
        public int created_by { get; set; }
        public int updated_by { get; set; }
        public string ac_flag { get; set; }
        public string flag { get; set; }
    }
}
