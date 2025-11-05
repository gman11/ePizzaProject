using System;
using ePizza.Application.Contracts;
using ePizza.Application.DTOs;

namespace ePizza.Application.Implementation;

public class ItemService : IItemService
{
    public Task<IEnumerable<ItemResponseDto>> GetItemsAsync()
    {
        throw new NotImplementedException();
    }
}
