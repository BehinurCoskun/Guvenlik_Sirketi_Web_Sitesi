﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace temagiydirme2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GuvenlikDbEntities3 : DbContext
    {
        public GuvenlikDbEntities3()
            : base("name=GuvenlikDbEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<GKatagori> GKatagori { get; set; }
        public virtual DbSet<GMusteri> GMusteri { get; set; }
        public virtual DbSet<GPersonel> GPersonel { get; set; }
        public virtual DbSet<GSiparis> GSiparis { get; set; }
    }
}
