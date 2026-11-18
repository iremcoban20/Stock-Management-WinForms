using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StokYönetimTakip2
{
    [Table("Table_Product")]
    internal class Product
    {
        [Key]
        public int product_id { get; set; }

        [Required, MaxLength(50)]
        public string product_name { get; set; }

        [ForeignKey("Category")]
        public int Category_id { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
