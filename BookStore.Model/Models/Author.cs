using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Model.Models
{
    
    [Table("Authors")]
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [MaxLength(256)]
        public string Country { get; set; }

        public virtual IEnumerable<BookAuthor> BookAuthors { get; set; }
    }
}
