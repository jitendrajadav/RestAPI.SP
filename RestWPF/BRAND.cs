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
    
    public partial class BRAND
    {
        public int BRAND_CODE { get; set; }
        public string BRAND_NAME { get; set; }
        public int MANU_CODE { get; set; }
        public string DESCRIPTION { get; set; }
        public int CREATE_BY { get; set; }
        public System.DateTime CREATE_DATE { get; set; }
        public int UPDATE_BY { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public byte IS_ACTIVE { get; set; }
    
        public virtual MANUFACT MANUFACT { get; set; }
    }
}
