using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhotoographyOnlineStore.Models
{
    public class Products : BaseEntity
    {
        [StringLength(20)]
        [DisplayName("Product Name")]
        public string Name { get; set; }

        public string Description { get; set; }
        [Range(0, 1000)]
        public Decimal Price { get; set; }

        public string Category { get; set; }

        public string Image { get; set; }
    }
}