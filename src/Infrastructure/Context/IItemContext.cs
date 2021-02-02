using Microsoft.EntityFrameworkCore;
using Domain.Models;

namespace Infrastructure.Context
{
  public class IItemContext : DbContext
  {
    public IItemContext(DbContextOptions options)
      : base(options)
    {
    }
    public DbSet<Item> Items { get; set; }
  }
}