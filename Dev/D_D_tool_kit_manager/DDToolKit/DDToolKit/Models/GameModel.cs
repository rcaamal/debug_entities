namespace DDToolKit.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GameModel : DbContext
    {
        public GameModel()
            : base("name=GameModel_Azure")
        {
        }

        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Save> Saves { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
