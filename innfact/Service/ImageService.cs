using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using innfact.Models;
namespace innfact.Service
{
    public class ImageService
    {
        private readonly innfactContext db;
        public ImageService(innfactContext _db)
        {
            db = _db;
        }
        public IEnumerable<Image> ByCategory(string imageCategory)
        {
            return db.Image.Where(x => x.ImageCategory == imageCategory);
        }
    }
}
