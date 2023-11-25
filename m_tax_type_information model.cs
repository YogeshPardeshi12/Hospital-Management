using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment.Models
{
    public class m_tax_type_information_model
    {
        public int tax_id { get; set; }
        public string tax_name { get; set; }
        public decimal tax_percent { get; set; }
        public int tax_group_id { get; set; }
        public string flag { get; set; }
    }
}
