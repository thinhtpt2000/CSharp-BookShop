using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Model.Models
{
    [Table("BookAuthors")]
    public class BookAuthor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int AuthorID { get; set; }

        public int BookID { get; set; }

        public DateTime? CreatedDate { get; set; }

        [ForeignKey("BookID")]
        public Book Book { get; set; }

        [ForeignKey("AuthorID")]
        public Author Author { get; set; }
    }
}