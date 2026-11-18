using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StokYönetimTakip2
{
    [Table("Table_Product_User")]
    internal class ProductUser
    {
        [Key]
        public int Product_User_id { get; set; }

        [ForeignKey("Users")]
        public int user_id { get; set; }

        [ForeignKey("Product")]
        public int product_id { get; set; }

        [ForeignKey("Category")]
        public int Category_id { get; set; }

        [Required]
        public int Quantity_taken { get; set; }

        public virtual Users Users { get; set; }
        public virtual Product Product { get; set; }

        public virtual Category Category { get; set; }
    }
}
