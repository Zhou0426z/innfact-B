using System;
using System.Collections.Generic;

namespace innfact.Models
{
    public partial class Image
    {
        public Guid ImageId { get; set; }
        public string ImageUrl { get; set; }
        public string GoToUrl { get; set; }
        public Guid? ForProductNo { get; set; }
        public string ImageCategory { get; set; }

        public virtual Products ForProductNoNavigation { get; set; }
    }
}
