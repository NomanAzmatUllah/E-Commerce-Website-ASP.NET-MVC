using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_commerce.Models.view_models
{
    public class userorderviewmodel
    {
        public int or_id { get; set; }
        public string o_usename { get; set; }
        public string o_phone { get; set; }
        public string o_email { get; set; }
        public Nullable<System.DateTime> o_createon { get; set; }
        public Nullable<bool> o_approved { get; set; }
    }
}