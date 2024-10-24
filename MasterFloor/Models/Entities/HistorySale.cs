namespace MasterFloor.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HistorySale
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string product_name { get; set; }

        public int partner_id { get; set; }

        public double quantity_product { get; set; }

        public DateTime date_sales { get; set; }

        public virtual Partner Partner { get; set; }
    }
}
