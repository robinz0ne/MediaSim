using Admin.DAL.Models;
using Admin.DAL.Models.Base;
using Admin.DAL.Models.ManyToMany;
using Microsoft.EntityFrameworkCore;

namespace Admin.DAL.Contexts
{
    public class TargetingGroupContext : DbContext
    {
        public TargetingGroupContext(DbContextOptions<TargetingGroupContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Hobby> Hobbies { get; set; }

        public DbSet<People> Peoples { get; set; }

        public DbSet<Profession> Professions { get; set; }

        public DbSet<SportCategory> SportCategories { get; set; }

        public DbSet<Interest> Interests { get; set; }

        public DbSet<InterestHobby> InterestHobby { get; set; }

        public DbSet<InterestProfession> InterestProfession { get; set; }

        public DbSet<InterestSportCategory> InterestSportCategory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hobby>().ToTable("Hobby");
            modelBuilder.Entity<People>().ToTable("People");
            modelBuilder.Entity<Profession>().ToTable("Profession");
            modelBuilder.Entity<SportCategory>().ToTable("SportCategory");
            modelBuilder.Entity<Interest>().ToTable("Interest");

            modelBuilder.Entity<InterestHobby>()
                .HasKey(bc => new { bc.InterestId, bc.HobbyId });

            modelBuilder.Entity<InterestHobby>()
                .HasOne(bc => bc.Interest)
                .WithMany(b => b.Hobbies)
                .HasForeignKey(bc => bc.InterestId);

            modelBuilder.Entity<InterestHobby>()
                .HasOne(bc => bc.Hobby)
                .WithMany(c => c.Interests)
                .HasForeignKey(bc => bc.HobbyId);

            modelBuilder.Entity<InterestProfession>()
                .HasKey(bc => new { bc.InterestId, bc.ProfessionId });

            modelBuilder.Entity<InterestProfession>()
                .HasOne(bc => bc.Interest)
                .WithMany(b => b.Professions)
                .HasForeignKey(bc => bc.InterestId);

            modelBuilder.Entity<InterestProfession>()
                .HasOne(bc => bc.Profession)
                .WithMany(c => c.Interests)
                .HasForeignKey(bc => bc.ProfessionId);

            modelBuilder.Entity<InterestSportCategory>()
                .HasKey(bc => new { bc.InterestId, bc.SportCategoryId });

            modelBuilder.Entity<InterestSportCategory>()
                .HasOne(bc => bc.Interest)
                .WithMany(b => b.SportCategories)
                .HasForeignKey(bc => bc.InterestId);

            modelBuilder.Entity<InterestSportCategory>()
                .HasOne(bc => bc.SportCategory)
                .WithMany(c => c.Interests)
                .HasForeignKey(bc => bc.SportCategoryId);
        }
    }
}
