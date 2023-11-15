using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GuitarShop.Models
{
    public class ProductListViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public string SelectCategory { get; set; }
        public string CheckActiveCategory(string category) =>
                category == SelectCategory ? "active" : "";
    }
}
