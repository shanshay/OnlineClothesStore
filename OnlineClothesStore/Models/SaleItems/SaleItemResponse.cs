using Microsoft.Identity.Client;
using OnlineClothesStore.Store.Core.Domain.Models;
using System.Collections.Generic;

namespace OnlineClothesStore.Models.SaleItems
{
    public class SaleItemResponse
    {

        public SaleItemResponse()
        {

        }

        public SaleItemResponse(SaleItem saleItem)
        {
            Id = saleItem.Id;
            ShortName = saleItem.ShortName;
            FullName = saleItem.FullName;
            Description = saleItem.Description;
            Color = saleItem.Color;
            Gender = saleItem.Gender;
            Type = saleItem.Type;
        }

        public int Id { get; set; }

        public string ShortName { get; set; }

        public string FullName { get; set; }

        public string Description { get; set; }

        public Color Color { get; set; }

        public Gender Gender { get; set; }
        
        public Type Type { get; set; }
    }
}
