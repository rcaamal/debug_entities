namespace DDToolKit.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PostModel : DbContext
    {
        public PostModel()
         // : base("name=Monsters")


        : base("name=DDToolContext_Azure")


        {
        }

        public virtual DbSet<BlogPost> BlogPosts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

     
    }
}
