﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApplication8
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Database1Entities1 : DbContext
    {
        public Database1Entities1()
            : base("name=Database1Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<employee> employee { get; set; }
        public virtual DbSet<employee_type> employee_type { get; set; }
        public virtual DbSet<Expends_Report> Expends_Report { get; set; }
        public virtual DbSet<Expends_Type> Expends_Type { get; set; }
        public virtual DbSet<Factory_Occupation> Factory_Occupation { get; set; }
        public virtual DbSet<Machines> Machines { get; set; }
        public virtual DbSet<Order_Details> Order_Details { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Postal_Code_Worker> Postal_Code_Worker { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Provided_Product> Provided_Product { get; set; }
        public virtual DbSet<Provider_Details> Provider_Details { get; set; }
        public virtual DbSet<Provider_Name> Provider_Name { get; set; }
        public virtual DbSet<Work_Shifts> Work_Shifts { get; set; }
    }
}
