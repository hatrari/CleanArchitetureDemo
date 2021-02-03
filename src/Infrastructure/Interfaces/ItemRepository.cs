using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Context;

namespace Infrastructure.Interfaces
{
  public class ItemRepository : IItemRepository
  {
    private readonly ItemContext _context;

    public ItemRepository(ItemContext context)
    {
      _context = context;
    }

    public Task<IEnumerable<Item>> GetAll()
    {
      return await _context.Items.ToListAsync();
    }

    public Task<Item> GetById(Guid id)
    {
      return await _context.Items.FirstOrDefaultAsync(i => i.Id == id);
    }
    
    public Task Add(Item item)
    {
      
    }

    public Task Delete(Guid id)
    {

    }
  }
}