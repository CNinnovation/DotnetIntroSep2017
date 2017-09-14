namespace EFWithCodeFirstScaffolding
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MyBook
    {
        [Key]
        public int BookId { get; set; }

        [StringLength(60)]
        public string Title { get; set; }

        [Required]
        [StringLength(30)]
        public string Publisher { get; set; }
    }
}
