﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReportDocumentationConsole.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MSBDWEntities : DbContext
    {
        public MSBDWEntities()
            : base("name=MSBDWEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ReportChangeLog> ReportChangeLogs { get; set; }
        public virtual DbSet<ReportLinkage> ReportLinkages { get; set; }
        public virtual DbSet<ReportSP> ReportSPs { get; set; }
        public virtual DbSet<ReportSPParameter> ReportSPParameters { get; set; }
        public virtual DbSet<SsrsReport> SsrsReports { get; set; }
        public virtual DbSet<enduser> endusers { get; set; }
    }
}