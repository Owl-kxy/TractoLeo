﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class RFacturaCompletaEntities : DbContext
    {
        public RFacturaCompletaEntities()
            : base("name=RFacturaCompletaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<SP_FacturaCompleta_Result> SP_FacturaCompleta(Nullable<int> idped)
        {
            var idpedParameter = idped.HasValue ?
                new ObjectParameter("idped", idped) :
                new ObjectParameter("idped", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_FacturaCompleta_Result>("SP_FacturaCompleta", idpedParameter);
        }
    }
}
