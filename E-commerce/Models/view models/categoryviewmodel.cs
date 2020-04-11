using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_commerce.Models.view_models
{
    public class categoryviewmodel
    {
        public int cat_id { get; set; }
        public string cat_name { get; set; }
        public Nullable<System.DateTime> cat_createon { get; set; }
        public string cat_colour { get; set; }
        public string cat_icon { get; set; }
        public Nullable<int> cat_fk_ad_id { get; set; }
    }
}