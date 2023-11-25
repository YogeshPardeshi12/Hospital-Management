using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment.Models
{
    public class t_purchase_hedar_model
    {
        public int purchase_hedar_id { get; set; }
        public int client_id { get; set; }
        public int global_id { get; set; }
        public string purchase_document_no { get; set; }
        public int purchase_status { get; set; }
        public int purchase_approv_by { get; set; }
        public DateTime approve_date { get; set; }
        public DateTime purchase_date { get; set; }
        public decimal purchase_total_amount { get; set; }
        public int purchase_type { get; set; }
        public int supplier_id { get; set; }
        public int pay_terms { get; set; }
        public int agent_id { get; set; }
        public decimal commision { get; set; }
        public decimal commision_Amount { get; set; }
        public decimal total_purchase_amount_hedar { get; set; }
        public string remark { get; set; }
        public int created_by { get; set; }
        public DateTime created_date { get; set; }
        public DateTime updated_date { get; set; }
        public int updated_by { get; set; }
        public string attr1 { get; set; }
        public string attr2 { get; set; }
        public string attr3 { get; set; }
        public string attr4 { get; set; }
        public string attr5 { get; set; }
        public decimal attr6 { get; set; }
        public decimal attr7 { get; set; }
        public int attr8 { get; set; }
        public string flag { get; set; }
    }
}
