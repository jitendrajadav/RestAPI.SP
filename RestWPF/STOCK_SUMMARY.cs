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
    
    public partial class STOCK_SUMMARY
    {
        public int LOTNO { get; set; }
        public string DEP_CODE { get; set; }
        public Nullable<int> P_CODE { get; set; }
        public byte[] DOC_TYPE { get; set; }
        public Nullable<System.DateTime> REF_DATE { get; set; }
        public Nullable<int> REC_QTY { get; set; }
        public Nullable<int> INT_TRF_IN_QTY { get; set; }
        public Nullable<int> OTH_IN_QTY { get; set; }
        public Nullable<int> SALE_QTY { get; set; }
        public Nullable<int> INT_TRF_OUT_QTY { get; set; }
        public Nullable<int> EXT_TRF_OUT_QTY { get; set; }
        public Nullable<int> OTH_OUT_QTY { get; set; }
        public Nullable<int> BAL_QTY { get; set; }
        public Nullable<int> COST_RATE { get; set; }
        public int DF_SALE_RATE { get; set; }
        public Nullable<int> RT_CHG_DOCNO { get; set; }
        public Nullable<System.DateTime> SALE_UPD_DATE { get; set; }
        public Nullable<System.DateTime> LAST_UPD_DATE { get; set; }
        public Nullable<int> MRP { get; set; }
        public string CO_BATCH_NO { get; set; }
        public Nullable<System.DateTime> EXPIRY_DATE { get; set; }
        public Nullable<int> SUPP_CODE { get; set; }
        public string SALE_TYPE { get; set; }
        public string SCHEME_NARRATION { get; set; }
        public Nullable<int> TAX_CODE { get; set; }
        public Nullable<int> TAX_AMT { get; set; }
        public int CREATE_BY { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public int UPDATE_BY { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public Nullable<byte> IS_ACTIVE { get; set; }
    
        public virtual PRODUCT_MASTER PRODUCT_MASTER { get; set; }
    }
}
