using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Viman_Robert_lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
        [ForeignKey("Author")] public int authorID { get; set; }

        public required string Title { get; set; }
        public required string Author { get; set; }
        public required decimal Price { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
