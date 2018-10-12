using System;
using Microsoft.EntityFrameworkCore;

namespace stocks.Models
{
    public class MvcStocksContext : DbContext
    {
        public MvcStocksContext(DbContextOptions<MvcStocksContext> options)
            : base(options)
        {
        }

        public DbSet<Stock> Stock { get; set; }
    }
}