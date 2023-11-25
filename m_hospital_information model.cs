﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Hospital_Managment.Models
{
    public class m_hospital_information_model
    {
        public int hospital_id { get; set; }
        public string hospital_name { get; set; }
        public string hospital_address { get; set; }
        public string hospital_email_address { get; set; }
        public string logo { get; set; }
        public string hospital_city { get; set; }
        public string hospital_pan { get; set; }
        public string hospital_gst_number { get; set; }
        public string hospital_contact_number { get; set; }
        public string hospital_contact_number1 { get; set; }
        public string hospital_web_site { get; set; }
        public int created_by { get; set; }
        public DateTime created_date { get; set; }
        public int updated_by { get; set; }
        public DateTime updated_date { get; set; }
        public string flag { get; set; }
    }
}
