using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.Data;

public class DataContext : DbContext
{
    public DataContext (DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Product { get; set; } = default!;
}
