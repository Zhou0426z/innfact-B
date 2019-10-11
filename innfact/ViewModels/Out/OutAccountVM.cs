using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace innfact.ViewModels.Out
{
    public class OutAccountVM
    {
        public int StatusCode { get; set; }
        public Guid AccountID { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
