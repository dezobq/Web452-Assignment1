using Microsoft.EntityFrameworkCore;
using Assignment1.Models;
using System.Collections.Generic;

namespace Assignment1.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        {
        }

        public DbSet<Candy> Candy { get; set; }
    }
}
