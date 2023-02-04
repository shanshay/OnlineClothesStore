using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineClothesStore.Store.Core.Domain.Models;
using OnlineClothesStore.Store.DataAccess;
using System.Collections.Generic;
using System.Linq;

namespace OnlineClothesStore.Store.WebHost.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SaleItemController : Controller
    {
        private readonly ILogger<SaleItemController> _logger;
        private readonly OnlineClothesStoreContext _storeContext;
        public SaleItemController(ILogger<SaleItemController> logger, OnlineClothesStoreContext storeContext)
        {
            _logger = logger;
            _storeContext = storeContext;
        }

        [HttpGet]
        public IEnumerable<SaleItem> GetAll()
        {
            return _storeContext.SaleItems;
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
