﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AkademiPlus_Transportation.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_TransportEntities : DbContext
    {
        public DB_TransportEntities()
            : base("name=DB_TransportEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBL_Category> TBL_Category { get; set; }
        public virtual DbSet<TBL_Customer> TBL_Customer { get; set; }
        public virtual DbSet<TBL_Employee> TBL_Employee { get; set; }
        public virtual DbSet<TBL_Process> TBL_Process { get; set; }
        public virtual DbSet<TBL_Product> TBL_Product { get; set; }
        public virtual DbSet<TBL_Transportation> TBL_Transportation { get; set; }
        public virtual DbSet<TBL_About> TBL_About { get; set; }
        public virtual DbSet<TBL_Admin> TBL_Admin { get; set; }
    }
}
