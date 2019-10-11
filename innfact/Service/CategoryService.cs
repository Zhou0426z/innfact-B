using innfact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace innfact.Service
{
    public class CategoryService
    {
        private readonly innfactContext db;
        public CategoryService(innfactContext _db)
        {
            db = _db;
        }
        public IEnumerable<Categories> GetHeaderCategories()
        {
            var value = db.Categories.OrderBy(x=>x.CategoryName);
            if(value.Count()>6)
            {
                return value.Take(6);
            }
            else
            {
                return value;
            }
        }
        public IEnumerable<Categories> GetAllCategories()
        {
            return db.Categories.OrderBy(x=>x.CategoryName);
        }
    }
}
