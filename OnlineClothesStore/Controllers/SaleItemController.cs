using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineClothesStore.Models.SaleItems;
using OnlineClothesStore.Store.Core.Abstractions.Repositories;
using OnlineClothesStore.Store.Core.Domain.Models;
using OnlineClothesStore.Store.WebHost.Models;
using Store.Exceptions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineClothesStore.Store.WebHost.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //[Route("/saleItems")]
    public class SaleItemController : Controller
    {
        private readonly ILogger<SaleItemController> _logger;
        private readonly IRepository<SaleItem> _saleItemRepository;

        public SaleItemController(
            ILogger<SaleItemController> logger,
            IRepository<SaleItem> saleItemRepository)
        {
            _logger = logger;            
            _saleItemRepository = saleItemRepository;
        }

        /// <summary>
        /// Get all items
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<List<SaleItem>>> GetSaleItemsAsync()
        {
            var saleItems = await _saleItemRepository.GetAllAsync();

            var response = saleItems.Select(si => new SaleItemsShortResponse()
            {
                Id = si.Id,
                ShortName = si.ShortName,
                Description = si.Description,
                Count = si.Count
            });

            return Ok(response);
        }

        [HttpGet]
        [Route("saleitem/{id}")]
        public async Task<ActionResult<SaleItemResponse>> GetSaleItemByIdAsync(int id)
        {
            var saleItem = await _saleItemRepository.GetByIdAsync(id);
            if (saleItem == null)
                throw new EntityNotFoundException(id, nameof(SaleItem));

            var response = new SaleItemResponse(saleItem);

            return Ok(response);
        }

        [HttpPut]
        [Route("saleitem/edit")]
        public async Task<ActionResult<SaleItemResponse>> UpdateSaleItemAsync(int id, CreateOrEditSaleItemRequest request)
        {
            var saleItem = await _saleItemRepository.GetByIdAsync(id);
            if (saleItem is null)
                throw new EntityNotFoundException(id, nameof(SaleItem));

            saleItem.ShortName = request.ShortName;
            saleItem.FullName = request.FullName;
            saleItem.Description = request.Description;
            saleItem.Count = request.Count;
            saleItem.Gender = request.Gender;
            saleItem.Type = request.Type;
            //TODO! Add ManyToMany relationship

            return Ok(saleItem);
        }

        [HttpPost]
        [Route("saleitem/create")]
        public async Task<ActionResult<SaleItemResponse>> CreateSaleItemAsync(CreateOrEditSaleItemRequest request)
        {
            var saleItem = new SaleItem()
            {
                ShortName = request.ShortName,
                FullName = request.FullName,
                Description = request.Description,
                Count = request.Count,
                Color = request.Color,
                Gender = request.Gender,
                Type = request.Type
            };

            await _saleItemRepository.CreateAsync(saleItem);

            return Ok(saleItem);
        }

        [HttpDelete]
        [Route("saleitem/delete/{id}")]
        public async Task<ActionResult> DeleteSaleItemAsync (int id)
        {
            var saleItem = await _saleItemRepository.GetByIdAsync(id);
            if (saleItem is null)
                throw new EntityNotFoundException(id, nameof(SaleItem));

            await _saleItemRepository.DeleteAsync(saleItem);

            return NoContent();
        }
    }
}
