﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OgrenciNotMvcProject.Models.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbMvcOkulEntities : DbContext
    {
        public DbMvcOkulEntities()
            : base("name=DbMvcOkulEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_Dersler> Tbl_Dersler { get; set; }
        public virtual DbSet<Tbl_Kulup> Tbl_Kulup { get; set; }
        public virtual DbSet<Tbl_Notlar> Tbl_Notlar { get; set; }
        public virtual DbSet<Tbl_Ogrenci> Tbl_Ogrenci { get; set; }
    }
}