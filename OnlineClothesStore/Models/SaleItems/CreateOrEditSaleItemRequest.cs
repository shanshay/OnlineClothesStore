using OnlineClothesStore.Store.Core.Domain.Models;
using System.Collections;
using System.Collections.Generic;

namespace OnlineClothesStore.Models.SaleItems
{
    public class CreateOrEditSaleItemRequest
    {
        public string ShortName { get; set; }

        public string FullName { get; set; }

        public string Description { get; set; }

        public int Count { get; set; }

        public Color Color { get; set; }

        public Gender Gender { get; set; }

        public Type Type { get; set; }

        //TODO! Add ManyToMany relationship

        //public Price Price { get; set; }

        //public Size Size { get; set; }

        public ICollection<Parameter> Parameters { get; set; }
    }
}
