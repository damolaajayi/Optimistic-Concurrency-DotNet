using System.ComponentModel.DataAnnotations;

namespace Optimistic_Concurrency.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Guid Version { get; set; }
    }
}
