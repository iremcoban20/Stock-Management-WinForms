using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StokYönetimTakip2
{
    [Table("Table_User")]
    internal class Users
    {
        [Key]
        public int user_id { get; set; }

        [Required]
        [MaxLength(50)]
        public string user_name { get; set; }

        [Required]
        [MaxLength(10)]
        public string user_phone_number { get; set; }
    }
}
