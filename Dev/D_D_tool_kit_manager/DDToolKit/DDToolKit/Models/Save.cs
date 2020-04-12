namespace DDToolKit.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Save
    {
        public int ID { get; set; }

        [Required]
        [StringLength(40)]
        public string Name { get; set; }

        [StringLength(128)]
        public string OwnerID { get; set; }

        [StringLength(500)]
        public string Monsters { get; set; }

        [StringLength(500)]
        public string Spells { get; set; }

    }
}
