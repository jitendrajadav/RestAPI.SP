//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestWPF
{
    using System;
    using System.Collections.Generic;
    
    public partial class SUPPLIER_RATE_MASTER
    {
        public int SUPP_RATE_ID { get; set; }
        public Nullable<int> SUPP_CODE { get; set; }
        public int P_CODE { get; set; }
        public string SUPP_PRODUC_CODE { get; set; }
        public string NORMAL_LEAD_TIME { get; set; }
        public Nullable<int> MAX_LEAD_TIME { get; set; }
        public int BATCH_QTY { get; set; }
        public int MIN_ORDER_BATCH { get; set; }
        public decimal RATE { get; set; }
        public decimal MRP { get; set; }
        public Nullable<System.DateTime> ST_DATE { get; set; }
        public Nullable<System.DateTime> END_DATE { get; set; }
        public int CREATE_BY { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public Nullable<int> UPDATE_BY { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public byte IS_ACTIVE { get; set; }
        public string NARRATION { get; set; }
    
        public virtual PRODUCT_MASTER PRODUCT_MASTER { get; set; }
    }
}
