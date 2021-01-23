using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Interfaces
{
  public interface IItemRepository
  {
    Task<IEnumerable<Item>> GetAll();
    Task<Item> GetById(Guid id);
    Task Add(Item item);
    Task Delete(Guid id);
  }
}