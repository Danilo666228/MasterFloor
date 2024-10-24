namespace MasterFloor.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaterialType")]
    public partial class MaterialType
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string material_name { get; set; }

        public double defect_rate { get; set; }
    }
}
