using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment.Models
{
    public class t_purchase_line_model
    {
        public int purchase_line_id { get; set; }
        public int purchase_hedar { get; set; }
        public int client_id { get; set; }
        public int global_id { get; set; }
        public int item_id { get; set; }
        public int item_qty { get; set; }
        public decimal item_total_strip_qty { get; set; }
        public decimal item_strip_qty { get; set; }
        public decimal item_per_unit_rate { get; set; }
        public int item_unit { get; set; }
        public decimal item_rate { get; set; }
        public int item_packing { get; set; }
        public int tax_id { get; set; }
        public int godown_id { get; set; }
        public int branch_id { get; set; }
        public DateTime delivery_date { get; set; }
        public decimal total_amount { get; set; }
        public int tax_type { get; set; }
        public decimal basic_amount { get; set; }
        public decimal tax_amount { get; set; }
        public string quality_check { get; set; }
        public string batch_no { get; set; }
        public DateTime batch_date { get; set; }
        public DateTime Expire_date { get; set; }
        public decimal item_mrp { get; set; }
        public decimal item_discount { get; set; }
        public decimal item_medi_rate { get; set; }
        public decimal medi_Qty { get; set; }
        public decimal gst_vat { get; set; }
        public decimal sgst { get; set; }
        public decimal igst { get; set; }
        public decimal medi_total_amount { get; set; }
        public int created_by { get; set; }
        public DateTime updated_by { get; set; }
        public DateTime created_date { get; set; }
        public DateTime updated_date { get; set; }
        public string attr1 { get; set; }
        public string attr2 { get; set; }
        public decimal attr3 { get; set; }
        public decimal attr4 { get; set; }
        public decimal attr5 { get; set; }
        public int attr6 { get; set; }
        public int attr7 { get; set; }
        public string hsn_code { get; set; }
        public decimal sach_discount { get; set; }
        public string company_name { get; set; }
        public int free_qty { get; set; }
        public int packing_id { get; set; }
        public decimal discount_amount { get; set; }
        public string flag { get; set; }
    }
}
