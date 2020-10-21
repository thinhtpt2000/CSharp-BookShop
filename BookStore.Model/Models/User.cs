using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Model.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public string Email { get; set; }

        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public string Password { get; set; }

        [Required]
        [MaxLength(256)]
        public string FullName { get; set; }

        public int RoleID { get; set; }

        [Required]
        [MaxLength(10)]
        [Column(TypeName = "varchar")]
        public string Phone { get; set; }

        [Required]
        [MaxLength(256)]
        public string Address { get; set; }

        public bool? Status { get; set; }

        [ForeignKey("RoleID")]
        public virtual Role Role { get; set; }
    }
}