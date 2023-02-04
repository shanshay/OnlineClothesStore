using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineClothesStore.Store.Core.Abstractions.Repositories;
using OnlineClothesStore.Store.Core.Domain.Models;
using OnlineClothesStore.Store.DataAccess;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineClothesStore.Store.WebHost.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SaleItemController : Controller
    {
        private readonly ILogger<SaleItemController> _logger;
        //private readonly OnlineClothesStoreContext _saleItemRepository;
        private readonly IRepository<SaleItem> _saleItemRepository;

        public SaleItemController(
            ILogger<SaleItemController> logger, 
            //OnlineClothesStoreContext storeContext,
            IRepository<SaleItem> saleItemRepository)
        {
            _logger = logger;
            //_saleItemRepository = storeContext;
            _saleItemRepository = saleItemRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<SaleItem>>> GetSaleItemsAsync()
        {
            var saleItems = await _saleItemRepository.GetAllAsync();
            var response = saleItems.ToList();

            return Ok(response);

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
