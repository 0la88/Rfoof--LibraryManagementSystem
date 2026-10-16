using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Rfoof_1.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public string DateOfBirth { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
