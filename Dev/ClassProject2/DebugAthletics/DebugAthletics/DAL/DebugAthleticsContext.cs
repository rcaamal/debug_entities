namespace DebugAthletics.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DebugAthleticsContext : DbContext
    {
        public DebugAthleticsContext()
            : base("name=DebugAthletics")
        {
        }

        public virtual DbSet<Administrator> Administrators { get; set; }
        public virtual DbSet<Athlete> Athletes { get; set; }
        public virtual DbSet<Coach> Coaches { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Athlete>()
                .HasMany(e => e.Results)
                .WithRequired(e => e.Athlete)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Coach>()
                .HasMany(e => e.Athletes)
                .WithRequired(e => e.Coach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Administrators)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.UserInfo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Coaches)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.UserInfo)
                .WillCascadeOnDelete(false);
        }
    }
}
