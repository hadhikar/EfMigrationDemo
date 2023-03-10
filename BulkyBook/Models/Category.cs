using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BulkyBook.Models
{
    [Table("category")]
    public class Category
    {
        [Column("category_id")]
        public int CategoryId { get; set; }

        [Column("name")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Column("display_order")]
        public int DisplayOrder { get; set; }

        [Column("created_date_time")]
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}

