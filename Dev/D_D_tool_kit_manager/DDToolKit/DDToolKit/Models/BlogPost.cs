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
        public int PostID { get; set; }

        [StringLength(128)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        
        public string Post { get; set; }

        [Column(TypeName = "date")]
        [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? Published { get; set; }
    }
}
