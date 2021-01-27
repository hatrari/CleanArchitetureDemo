using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;
using Application.Interfaces;

namespace Application.Services
{
  public class ItemService : IItemService
  {
    public Task Add(Item item)
    {
      throw new NotImplementedException();
    }

    public Task Delete(Guid id)
    {
      throw new NotImplementedException();
    }

    public Task<IEnumerable<Item>> GetAll()
    {
      throw new NotImplementedException();
    }

    public Task<Item> GetById(Guid id)
    {
      throw new NotImplementedException();
    }
  }
}