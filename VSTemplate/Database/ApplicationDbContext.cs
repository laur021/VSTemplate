using Microsoft.EntityFrameworkCore;
using VSTemplate.Features.BookFeature;
namespace VSTemplate.Database;

public class ApplicationDbContext(DbContextOptions options)
 : DbContext(options)
{
    public DbSet<Book> Books { get; set; } = null!;
}

