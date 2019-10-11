using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using innfact.Models;
namespace innfact.ViewModels.Out
{
    public class OutProductsVM
    {
        public Guid ProductID { get; set; }
        public IOrderedEnumerable<string> ImageSilders { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public ICollection<ProductDetails> ProductDetails { get; set; }
    }
}
