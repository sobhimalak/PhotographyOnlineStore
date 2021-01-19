using PhotographyOnlineStore.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhotographyOnlineStore.Models
{
    public class Product : BaseEntity
    {
        [StringLength(20)]//test
        [DisplayName("Product Name")]
        public String Name { get; set; }
        public String Description { get; set; }
        [Range(0, 1000)]
        public Decimal Price { get; set; }
        public String Category { get; set; }
        public String Image { get; set; }
    }
}