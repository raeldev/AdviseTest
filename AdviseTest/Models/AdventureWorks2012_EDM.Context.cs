﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdviseTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class AdventureWorks2012Entities : DbContext
    {
        public AdventureWorks2012Entities()
            : base("name=AdventureWorks2012Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductModel> ProductModel { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<ProductSubcategory> ProductSubcategory { get; set; }
        public DbSet<UnitMeasure> UnitMeasure { get; set; }
    
        public virtual List<uspGetProducts_Result> uspGetProducts(Nullable<System.DateTime> pSellStartDate, Nullable<int> pPage, Nullable<int> pRowsPage, Nullable<bool> pOrderByName, Nullable<bool> pOrderLastFirst)
        {
            var pSellStartDateParameter = pSellStartDate.HasValue ?
                new ObjectParameter("pSellStartDate", pSellStartDate) :
                new ObjectParameter("pSellStartDate", typeof(System.DateTime));
    
            var pPageParameter = pPage.HasValue ?
                new ObjectParameter("pPage", pPage) :
                new ObjectParameter("pPage", typeof(int));
    
            var pRowsPageParameter = pRowsPage.HasValue ?
                new ObjectParameter("pRowsPage", pRowsPage) :
                new ObjectParameter("pRowsPage", typeof(int));
    
            var pOrderByNameParameter = pOrderByName.HasValue ?
                new ObjectParameter("pOrderByName", pOrderByName) :
                new ObjectParameter("pOrderByName", typeof(bool));
    
            var pOrderLastFirstParameter = pOrderLastFirst.HasValue ?
                new ObjectParameter("pOrderLastFirst", pOrderLastFirst) :
                new ObjectParameter("pOrderLastFirst", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<uspGetProducts_Result>("uspGetProducts", pSellStartDateParameter, pPageParameter, pRowsPageParameter, pOrderByNameParameter, pOrderLastFirstParameter).ToList();
        }
    }
}