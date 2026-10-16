using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Rfoof_1.Models
{
    public class Reader
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
