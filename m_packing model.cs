﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Managment.Models
{
    public class m_packing_model
    {
        public int packing_id { get; set; }
        public string    packing_name { get; set; }
        public int first_packing_convert { get; set; }
        public int second_packing_convert { get; set; }
        public string attr1 { get; set; }
        public string attr2 { get; set; }
        public string flag { get; set; }
    }
}
