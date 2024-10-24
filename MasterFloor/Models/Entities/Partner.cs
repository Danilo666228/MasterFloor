namespace MasterFloor.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Partner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Partner()
        {
            HistorySales = new HashSet<HistorySale>();
        }

        public int id { get; set; }

        public int partner_type_id { get; set; }

        [Required]
        [StringLength(255)]
        public string partner_name { get; set; }

        [Required]
        [StringLength(255)]
        public string director { get; set; }

        [Required]
        [StringLength(255)]
        public string email { get; set; }

        [Required]
        [StringLength(255)]
        public string phone { get; set; }

        [Required]
        [StringLength(255)]
        public string address { get; set; }

        [Required]
        [StringLength(100)]
        public string inn { get; set; }

        public int rating { get; set; }

        public int discount_id { get; set; }

        public virtual DiscountPartner DiscountPartner { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistorySale> HistorySales { get; set; }

        public virtual PartnerType PartnerType { get; set; }
    }
}
