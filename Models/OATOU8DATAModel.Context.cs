﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OAtoU8DATAEntities : DbContext
    {
        public OAtoU8DATAEntities()
            : base("name=OAtoU8DATAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<triggerSummary> triggerSummary { get; set; }
        public virtual DbSet<producehelp> producehelp { get; set; }
        public virtual DbSet<userInfo> userInfo { get; set; }
        public virtual DbSet<contrast> contrast { get; set; }
        public virtual DbSet<RecordTable> RecordTable { get; set; }
    }
}
