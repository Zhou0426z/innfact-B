using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace innfact.ViewModels.In
{
    public class InAccountVM
    {
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime? BirthDay { get; set; }
        public string LoginBy { get; set; }
    }
}
