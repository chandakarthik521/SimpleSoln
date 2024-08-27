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
        public virtual DbSet<MHair> MHairColours{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MSkin>(entity =>
            {
                entity.ToTable("M_Skin", "avatar");
                entity.HasKey(x => x.SkinID);
            });

            modelBuilder.Entity<MHair>(entity =>
            {
                entity.ToTable("M_Hair", "avatar");
                entity.HasKey(x => x.HairId);
            });
        }
    }
}