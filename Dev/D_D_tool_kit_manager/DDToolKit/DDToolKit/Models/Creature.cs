namespace DDToolKit.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using DAL;
    public partial class Creature
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(15)]
        public string Size { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string Type { get; set; }

        [StringLength(20)]
        public string SubType { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string Aligment { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ArmorClass { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HitPoints { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(10)]
        public string HitDice { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Strength { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Dexterity { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Constitution { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Intelligence { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Wisdom { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Charisma { get; set; }

        [StringLength(500)]
        public string Languages { get; set; }

        [Key]
        [Column(Order = 14)]
        public double ChallangeRating { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(500)]
        public string Speed { get; set; }

        [StringLength(500)]
        public string Proficiencies { get; set; }

        [StringLength(500)]
        public string DamageResistance { get; set; }

        [StringLength(500)]
        public string DamageVulnerability { get; set; }

        [StringLength(500)]
        public string DamageImmunity { get; set; }

        [StringLength(500)]
        public string ConditionImmunity { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(500)]
        public string Senses { get; set; }

        [StringLength(500)]
        public string SpecialAbility { get; set; }

        public string Actions { get; set; }

        public string LegendaryActions { get; set; }
    }
}
