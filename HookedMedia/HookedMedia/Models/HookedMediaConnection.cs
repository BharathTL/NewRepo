namespace HookedMedia.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HookedMediaConnection : DbContext
    {
        public HookedMediaConnection()
            : base("name=HookedMediaConnection")
        {
        }

        public virtual DbSet<Campaign> Campaigns { get; set; }
        public virtual DbSet<CampaignMaster> CampaignMasters { get; set; }
        public virtual DbSet<Creative> Creatives { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Campaign>()
                .Property(e => e.campaign_code)
                .IsUnicode(false);

            modelBuilder.Entity<Campaign>()
                .Property(e => e.advertiser_id)
                .IsUnicode(false);

            modelBuilder.Entity<Campaign>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<Campaign>()
                .Property(e => e.ad_domain)
                .IsUnicode(false);

            modelBuilder.Entity<Campaign>()
                .Property(e => e.campaign_type)
                .IsUnicode(false);

            modelBuilder.Entity<Campaign>()
                .Property(e => e.goal)
                .IsUnicode(false);

            modelBuilder.Entity<Campaign>()
                .Property(e => e.timezone)
                .IsUnicode(false);

            modelBuilder.Entity<Campaign>()
                .Property(e => e.campaign_status)
                .IsUnicode(false);

            modelBuilder.Entity<Campaign>()
                .HasMany(e => e.Creatives)
                .WithRequired(e => e.Campaign)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CampaignMaster>()
                .Property(e => e.keys)
                .IsUnicode(false);

            modelBuilder.Entity<CampaignMaster>()
                .Property(e => e.groups)
                .IsUnicode(false);

            modelBuilder.Entity<Creative>()
                .Property(e => e.campaign_code)
                .IsUnicode(false);
        }
    }
}
