using KRModels.Models;
using Microsoft.EntityFrameworkCore;

namespace KRModels.Context
{
    public class KRContext : DbContext
    {
        public KRContext()
        {

        }
        public KRContext(DbContextOptions<KRContext> Options) : base(Options)
        {

        }
        public virtual DbSet<MSkin> MSkinColours { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MSkin>(entity =>
            {
                entity.ToTable("M_Skin", "avatar");
                entity.HasKey(x => x.SkinID);
            });
        }
    }
}