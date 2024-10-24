namespace MasterFloor.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public int id { get; set; }

        public int type_product_id { get; set; }

        [Required]
        [StringLength(255)]
        public string product_name { get; set; }

        public int article { get; set; }

        public double min_coast { get; set; }

        public virtual ProductType ProductType { get; set; }
    }
}
