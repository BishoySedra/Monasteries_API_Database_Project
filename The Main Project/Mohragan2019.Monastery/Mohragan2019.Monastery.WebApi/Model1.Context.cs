//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mohragan2019.Monastery.WebApi
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MonasteryEntities : DbContext
    {
        public MonasteryEntities()
            : base("name=MonasteryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Father> Fathers { get; set; }
        public virtual DbSet<FathersIntro> FathersIntroes { get; set; }
        public virtual DbSet<History> Histories { get; set; }
        public virtual DbSet<HistoryContent> HistoryContents { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Monastery> Monasteries { get; set; }
        public virtual DbSet<Place> Places { get; set; }
        public virtual DbSet<SaintParagraph> SaintParagraphs { get; set; }
        public virtual DbSet<SaintTitle> SaintTitles { get; set; }
        public virtual DbSet<SaintVideo> SaintVideos { get; set; }
        public virtual DbSet<StoryParagraph> StoryParagraphs { get; set; }
        public virtual DbSet<StoryTitle> StoryTitles { get; set; }
        public virtual DbSet<Video> Videos { get; set; }
    }
}
