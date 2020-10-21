using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }

        public int CustomerID { get; set; }

        [Required]
        [MaxLength(256)]
        public string CustomerName { get; set; }

        [Required]
        [MaxLength(256)]
        public string CustomerAddress { get; set; }

        [Required]
        [MaxLength(10)]
        [Column(TypeName = "varchar")]
        public string CustomerPhone { get; set; }

        [MaxLength(256)]
        public string CustomerNote { get; set; }

        public DateTime? CreatedDate { get; set; }

        [Required]
        public long Total { get; set; }

        public int PaymentMethodID { get; set; }

        [ForeignKey("PaymentMethodID")]
        public virtual PaymentMethod PaymentMethod { get; set; }

        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}