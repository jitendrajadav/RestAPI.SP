﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestAPI
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class FruitBytesEntities : DbContext
    {
        public FruitBytesEntities()
            : base("name=FruitBytesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<string> uspGetCategory(string cATNAM, Nullable<int> cREATEBY)
        {
            var cATNAMParameter = cATNAM != null ?
                new ObjectParameter("CATNAM", cATNAM) :
                new ObjectParameter("CATNAM", typeof(string));
    
            var cREATEBYParameter = cREATEBY.HasValue ?
                new ObjectParameter("CREATEBY", cREATEBY) :
                new ObjectParameter("CREATEBY", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("uspGetCategory", cATNAMParameter, cREATEBYParameter);
        }
    }
}