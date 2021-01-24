using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;

namespace Application.Interfaces
{
  public interface IItemService
  {
    Task<IEnumerable<Item>> GetAll();
    Task<Item> GetById(Guid id);
    Task Add(Item item);
    Task Delete(Guid id);
  }
}