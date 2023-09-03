using Microsoft.EntityFrameworkCore;
using Optimistic_Concurrency.Models;
using System.Collections.Generic;

namespace Optimistic_Concurrency.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
        : base(options)
        {
        }

        public virtual DbSet<Product> Product { get; set; } = default!;
    }
}
