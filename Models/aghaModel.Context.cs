﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace aghaApi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class finalEntities : DbContext
    {
        public finalEntities()
            : base("name=finalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<admin> admins { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<promotion> promotions { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<Availability_Slots> Availability_Slots { get; set; }
        public virtual DbSet<request> requests { get; set; }
        public virtual DbSet<service> services { get; set; }
        public virtual DbSet<user_request> user_request { get; set; }
        public virtual DbSet<worker_Portfolio> worker_Portfolio { get; set; }
    }
}
