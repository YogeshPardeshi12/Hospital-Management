﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment.Models
{
    public class m_item_information_model
    {
        public int item_id { get; set; }
        public string item_code { get; set; }
        public int item_type { get; set; }
        public string item_name { get; set; }
        public string item_manufaction_name { get; set; }
        public int item_pacinking { get; set; }
        public string item_use_name { get; set; }
        public string item_description { get; set; }
        public DateTime item_start_date { get; set; }
        public DateTime item_end_date { get; set; }
        public int item_first_unit { get; set; }
        public int item_second_unit { get; set; }
        public decimal item_conversion_first_factor { get; set; }
        public decimal item_conversion_second_factor { get; set; }
        public string item_is_stockebal { get; set; }
        public string item_quality_check { get; set; }
        public string item_return_policy { get; set; }
        public decimal item_min_qty { get; set; }
        public decimal item_max_qty { get; set; }
        public string item_hsn_code { get; set; }
        public int item_po_type { get; set; }
        public string item_tax_apply { get; set; }
        public decimal item_po_tax_group { get; set; }
        public decimal item_sale_tax_group { get; set; }
        public int created_by { get; set; }
        public DateTime created_date { get; set; }
        public int updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public string activ_flag { get; set; }
        public string attr1 { get; set; }
        public string attr2 { get; set; }
        public string attr3 { get; set; }
        public int attr4 { get; set; }
        public int attr5 { get; set; }
        public int attr6 { get; set; }
        public string flag { get; set; }
    }
}
