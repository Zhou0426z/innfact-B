﻿using System;
using System.Collections.Generic;

namespace innfact.Models
{
    public partial class Categories
    {
        public Categories()
        {
            Products = new HashSet<Products>();
        }

        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string RouteName { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
