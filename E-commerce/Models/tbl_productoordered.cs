//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_commerce.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_productoordered
    {
        public int op_id { get; set; }
        public Nullable<int> op_fk_id { get; set; }
        public Nullable<int> op_quantity { get; set; }
        public Nullable<double> op_uniprice { get; set; }
        public Nullable<double> op_total { get; set; }
        public Nullable<int> op_fk_orid_id { get; set; }
    
        public virtual product product { get; set; }
        public virtual tbl_userorder tbl_userorder { get; set; }
    }
}
