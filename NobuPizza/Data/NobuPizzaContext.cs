using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NobuPizza.Models;

namespace NobuPizza.Data
{
    public class NobuPizzaContext : DbContext
    {
        public NobuPizzaContext (DbContextOptions<NobuPizzaContext> options)
            : base(options)
        {
        }

        public DbSet<NobuPizza.Models.Product> Product { get; set; } = default!;
    }
}
