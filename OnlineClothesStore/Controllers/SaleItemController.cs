using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineClothesStore.Store.Core.Abstractions.Repositories;
using OnlineClothesStore.Store.Core.Domain.Models;
using OnlineClothesStore.Store.WebHost.Models;
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

        [HttpGet]
        //[Route("[controller]")]
        //[Route("saleitems")]
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
        [Route("/saleitem/{id}")]
        public async Task<ActionResult<SaleItem>> GetSaleItemById(int id)
        {
            var saleItem = await _saleItemRepository.GetByIdAsync(id);
            if (saleItem == null)
                return NotFound();

            return Ok(saleItem);
        }
        //[HttpGet]
        //public SaleItem GetById(int id)
        //{
        //    return _storeContext.SaleItems.FirstOrDefault(s => s.Id == id);
        //}

        //[HttpPost]
        //public void CreateItem(SaleItem item)
        //{
        //    _storeContext.SaleItems.Add(item);
        //    _storeContext.SaveChanges();            
        //}
    }
}
