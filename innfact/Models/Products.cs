using System;
using System.Collections.Generic;

namespace innfact.Models
{
    public partial class Products
    {
        public Products()
        {
            Image = new HashSet<Image>();
            ProductDetails = new HashSet<ProductDetails>();
        }

        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Guid CategoryId { get; set; }

        public virtual Categories Category { get; set; }
        public virtual ICollection<Image> Image { get; set; }
        public virtual ICollection<ProductDetails> ProductDetails { get; set; }
    }
}
