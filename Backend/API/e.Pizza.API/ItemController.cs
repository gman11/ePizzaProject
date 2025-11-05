using ePizza.Application.Contracts;
using ePizza.Application.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ePizza.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;
                  public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemResponseDto>>> Get()
        {
            var results = await _itemService.GetItemsAsync();

            return Ok(results);
        }

    }
}
