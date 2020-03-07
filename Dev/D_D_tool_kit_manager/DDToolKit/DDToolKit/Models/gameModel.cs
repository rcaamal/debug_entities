namespace DDToolKit.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class gameModel : DbContext
    {
        public gameModel()
<<<<<<< HEAD
<<<<<<< HEAD
            : base("name=Monsters")
            //: base("name=DDToolContext_Azure")
=======
            //: base("name=Monsters")
             : base("name=DDToolContext_Azure")
>>>>>>> 80c70d4a08d1633fcc47292ad0feaaa2dea6ec0b
=======
            : base("name=Monsters")
             //: base("name=DDToolContext_Azure")
>>>>>>> feature3
        {
        }

        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Save> Saves { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
