using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StokYönetimTakip2
{
    [Table("Table_Category")]
    internal class Category
    {
        [Key]
        public int Category_id { get; set; }

        [Required, MaxLength(50)]
        public string Category_name { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}
