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
    
    public partial class POS_HEADER
    {
        public int POS_HEADER_ID { get; set; }
        public Nullable<int> V_NO { get; set; }
        public string DEP_CODE { get; set; }
        public Nullable<System.DateTime> V_DATE { get; set; }
        public string MAC_ID { get; set; }
        public Nullable<int> TOT_LINE_ITEMS { get; set; }
        public Nullable<decimal> ROUNDOFF { get; set; }
        public Nullable<int> CUSTID { get; set; }
        public Nullable<int> DISCOUNT { get; set; }
        public Nullable<decimal> BILL_AMT { get; set; }
        public int CREATE_BY { get; set; }
        public Nullable<System.DateTime> CREATE_DATE { get; set; }
        public int UPDATE_BY { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public string STAFF { get; set; }
        public string STAFF_NAME { get; set; }
        public string IN_INV { get; set; }
        public Nullable<int> CUST { get; set; }
        public string HOME_DELIVERY { get; set; }
        public Nullable<int> TAX_CODE { get; set; }
        public Nullable<decimal> TAXABLE_AMT { get; set; }
        public Nullable<decimal> TAX_AMT { get; set; }
        public Nullable<decimal> TOT_AMT { get; set; }
        public Nullable<decimal> SC_AMT { get; set; }
        public Nullable<decimal> AMT_RECD { get; set; }
        public Nullable<int> TOT_QTY { get; set; }
        public Nullable<int> ORD_ID { get; set; }
        public string SALESMAN_ID { get; set; }
        public Nullable<double> SCHEME_DISC { get; set; }
        public Nullable<double> BILL_SCH_DISC { get; set; }
        public string TOKEN_NO { get; set; }
        public string DISC_U_CODE { get; set; }
        public string DELIV_UCODE { get; set; }
        public Nullable<System.DateTime> DELIV_DATE { get; set; }
        public string NARRATION { get; set; }
        public byte IS_ACTIVE { get; set; }
    }
}