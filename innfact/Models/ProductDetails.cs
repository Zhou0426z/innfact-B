using System;
using System.Collections.Generic;

namespace innfact.Models
{
    public partial class ProductDetails
    {
        public Guid ProductDetailId { get; set; }
        public Guid ProductId { get; set; }
        public string ProductDetailName { get; set; }
        public int Stock { get; set; }
        public string Specification { get; set; }

        public virtual Products Product { get; set; }
    }
}
