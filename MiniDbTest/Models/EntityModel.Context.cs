﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiniDbTest.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class aeghealthEntities : DbContext
    {
        public aeghealthEntities()
            : base("name=aeghealthEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblAnswer> tblAnswers { get; set; }
        public virtual DbSet<tblConsumer> tblConsumers { get; set; }
        public virtual DbSet<tblConsumerHistory> tblConsumerHistories { get; set; }
    }
}
