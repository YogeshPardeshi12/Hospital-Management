using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment.Models
{
    public class t_medicen_sale_line_model
    {
        public int sale_line_id { get; set; }
        public int sale_hedar_id { get; set; }
        public int purchase_line_id { get; set; }
        public int item_id { get; set; }
        public string item_name { get; set; }
        public string item_batch { get; set; }
        public string item_pckg { get; set; }
        public DateTime item_exp_date { get; set; }
        public string item_mfg { get; set; }
        public decimal item_qty { get; set; }
        public decimal item_mrp { get; set; }
        public decimal item_total_amount { get; set; }
        public decimal discount { get; set; }
        public int paid_unpaid { get; set; }
        public int attr1 { get; set; }
        public decimal attr2 { get; set; }
        public string attr3 { get; set; }
        public int created_by { get; set; }
        public int updated_by { get; set; }
        public DateTime created_date { get; set; }
        public DateTime updated_date { get; set; }
        public string flag { get; set; }
    }
}
