﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Periodico2.Persistencia.Conexion
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PeriodicoEntities : DbContext
    {
        public PeriodicoEntities()
            : base("name=PeriodicoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AUTOR> AUTOR { get; set; }
        public DbSet<NOTICIA> NOTICIA { get; set; }
        public DbSet<TEMA> TEMA { get; set; }
    }
}