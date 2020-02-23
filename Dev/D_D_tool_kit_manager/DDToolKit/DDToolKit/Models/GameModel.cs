namespace DDToolKit.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GameModel : DbContext
    {
        public GameModel()
            : base("name=GameModel")
        {
        }

        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Save> Saves { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Save>()
                .HasMany(e => e.Players)
                .WithRequired(e => e.Save)
                .HasForeignKey(e => e.GameID)
                .WillCascadeOnDelete(false);
        }
    }
}
