﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CicOData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CicDBEntities : DbContext
    {
        public CicDBEntities()
            : base("name=CicDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<InteractionSegmentDetail> InteractionSegmentDetail { get; set; }
        public DbSet<InteractionSummary> InteractionSummary { get; set; }
        public DbSet<AgentStat> AgentStats { get; set; }
        public DbSet<CallHistory> CallHistories { get; set; }
        public DbSet<CampaignStat> CampaignStats { get; set; }
        public DbSet<IAgentQueueStats> IAgentQueueStats { get; set; }
        public DbSet<IWrkgrpQueueStats> IWrkgrpQueueStats { get; set; }
    }
}
