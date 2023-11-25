using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment.Models
{
    public class t_medicen_sale_hedar_model
    {
        public int sale_hedar_id { get; set; }
        public DateTime sale_date { get; set; }
        public int client_id { get; set; }
        public int global_id { get; set; }
        public string sale_document_number { get; set; }
        public string customer_name { get; set; }
        public decimal discount_percentage { get; set; }
        public decimal dicount_in_rupees { get; set; }
        public decimal discount_amount_percentage { get; set; }
        public decimal discount_amount_roupees { get; set; }
        public decimal total_amoun { get; set; }
        public string contact_no { get; set; }
        public string dr_name { get; set; }
        public string address { get; set; }
        public decimal attr1 { get; set; }
        public string attr2 { get; set; }
        public DateTime created_date { get; set; }
        public DateTime updated_date { get; set; }
        public int created_by { get; set; }
        public int updated_by { get; set; }
        public string flag { get; set; }
    }
}
