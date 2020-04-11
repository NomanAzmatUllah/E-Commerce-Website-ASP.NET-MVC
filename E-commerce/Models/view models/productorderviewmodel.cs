using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_commerce.Models.view_models
{
    public class productorderviewmodel
    {
        public int op_id { get; set; }
        public Nullable<int> op_fk_id { get; set; }
        public Nullable<int> op_quantity { get; set; }
        public Nullable<double> op_uniprice { get; set; }
        public Nullable<double> op_total { get; set; }
        public Nullable<int> op_fk_orid_id { get; set; }
    }
}