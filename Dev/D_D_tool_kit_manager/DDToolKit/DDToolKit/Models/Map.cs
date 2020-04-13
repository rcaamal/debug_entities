namespace DDToolKit.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Map
    {
        public int ID { get; set; }

        [StringLength(128)]
        public string OwnerID { get; set; }

        public int? GameID { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        public int? MapWidth { get; set; }

        public int? MapHeight { get; set; }

        [StringLength(400)]
        public string MapLand { get; set; }

        [StringLength(400)]
        public string MapObjects { get; set; }
    }
}
