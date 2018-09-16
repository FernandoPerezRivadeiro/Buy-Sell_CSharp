namespace ProjectTeam06TermProject.EF_Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Item()
        {
            Orders = new HashSet<Order>();
            Postings = new HashSet<Posting>();
        }

        [Required]
        [StringLength(50)]
        public string ItemName { get; set; }

        [Column(TypeName = "money")]
        public decimal ItemPrice { get; set; }

        [Required]
        [StringLength(50)]
        public string ItemCategory { get; set; }

        public int ItemId { get; set; }

        public int Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Posting> Postings { get; set; }
    }
}
