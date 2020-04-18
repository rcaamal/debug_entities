namespace DDToolKit.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BlogPost")]
    public partial class BlogPost
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PostID { get; set; }

        [StringLength(128)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public string Post { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        public bool? Published { get; set; }

        [StringLength(50)]
        public string Created { get; set; }
    }
}
