using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
namespace Rfoof_1.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal price { get; set; }
        public Author Author { get; set; }
        [ForeignKey(nameof(Author))]
        public int AuthorId { get; set; }

        public Category Category { get; set; }
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }


        public Reader Reader { get; set; }
        [ForeignKey(nameof(Reader))]
        public int? ReaderId { get; set; }
    }
}
