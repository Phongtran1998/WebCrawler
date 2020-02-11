using System;
using Crawler.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Content.Data
{
    public partial class ContentContext : DbContext
    {
        public ContentContext(DbContextOptions<ContentContext> options)
            : base(options)
        {
        }

        #region Generated Properties
        public virtual DbSet<Episode> Episodes { get; set; }

        public virtual DbSet<Page> Pages { get; set; }

        public virtual DbSet<WebToon> WebToons { get; set; }

        #endregion
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlite("Data Source=D:\\WebCrawlerPrj\\Crawler\\DB\\content.db;");
        // }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            modelBuilder.ApplyConfiguration(new Content.Data.Mapping.EpisodeMap());
            modelBuilder.ApplyConfiguration(new Content.Data.Mapping.PageMap());
            modelBuilder.ApplyConfiguration(new Content.Data.Mapping.WebToonMap());
            #endregion
        }
    }
}
