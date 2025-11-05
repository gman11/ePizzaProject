using System;
using ePizza.Application.DTOs;

namespace ePizza.Application.Contracts;

public interface IItemService
{
  Task<IEnumerable<ItemResponseDto>> GetItemsAsync();
}
