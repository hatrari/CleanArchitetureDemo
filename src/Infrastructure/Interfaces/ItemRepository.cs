using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Interfaces
{
  public class ItemRepository : IItemRepository
  {
    private readonly ItemContext _context;

    public ItemRepository(ItemContext context)
    {
      _context = context;
    }

    public async Task<IEnumerable<Item>> GetAll()
    {
      return await _context.Items.ToListAsync();
    }

    public async Task<Item> GetById(Guid id)
    {
      return await _context.Items.FirstOrDefaultAsync(i => i.Id == id);
    }
    
    public async Task Add(Item item)
    {
      _context.Add(item);
      await _context.SaveChangesAsync();
    }

    public async Task Delete(Guid id)
    {
      Item item = await GetById(id);
      _context.Remove(item);
      await _context.SaveChangesAsync();
    }
  }
}