using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Model.Models
{
    [Table("BookPublishers")]
    public class BookPublisher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int PublisherID { get; set; }

        public int BookID { get; set; }

        public DateTime? PublishedDate { get; set; }

        [ForeignKey("BookID")]
        public Book Book { get; set; }

        [ForeignKey("PublisherID")]
        public Publisher Publisher { get; set; }
    }
}