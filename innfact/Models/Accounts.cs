using System;
using System.Collections.Generic;

namespace innfact.Models
{
    public partial class Accounts
    {
        public Guid AccountId { get; set; }
        public Guid RoleId { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime? BirthDay { get; set; }
        public string LoginBy { get; set; }

        public virtual Roles Role { get; set; }
    }
}
