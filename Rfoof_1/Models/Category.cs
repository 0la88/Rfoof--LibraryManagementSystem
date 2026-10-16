using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Rfoof_1.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
