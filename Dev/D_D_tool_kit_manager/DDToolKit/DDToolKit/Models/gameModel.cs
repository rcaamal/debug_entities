namespace DDToolKit.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public partial class gameModel : DbContext
    {
        public gameModel()

          : base("name=Monsters")


        //: base("name=DDToolContext_Azure")

        {
        }

        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Save> Saves { get; set; }

        public virtual DbSet<Magic> Magics { get; set; }
        public virtual DbSet<Equipment> Equipments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public System.Data.Entity.DbSet<DDToolKit.Models.Map> Maps { get; set; }

        public System.Data.Entity.DbSet<DDToolKit.Models.BlogPost> BlogPosts { get; set; }
    }
}
