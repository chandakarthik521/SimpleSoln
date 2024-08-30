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

        public virtual DbSet<MLevel> MLevels { get; set; }

        public virtual DbSet<MModule> MModules { get; set; }

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

            modelBuilder.Entity<MLevel>(entity =>
            {
                entity.ToTable("M_Level", "User");
                entity.HasKey(x => x.LevelID);
            });

            modelBuilder.Entity<MModule>(entity =>
            {
                entity.ToTable("M_Module", "User");
                entity.HasKey(x => x.ModuleID);
            });
        }
    }
}