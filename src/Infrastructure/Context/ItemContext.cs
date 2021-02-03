using Microsoft.EntityFrameworkCore;
using Domain.Models;

namespace Infrastructure.Context
{
  public class ItemContext : DbContext
  {
    public ItemContext(DbContextOptions options)
      : base(options)
    {
    }
    public DbSet<Item> Items { get; set; }
  }
}