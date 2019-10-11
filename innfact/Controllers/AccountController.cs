using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using innfact.Models;
using innfact.Service;
using innfact.ViewModels.In;
using innfact.ViewModels.Out;
namespace innfact.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private AccountService accountService;
        public AccountController(innfactContext db)
        {
            accountService = new AccountService(db);
        }
        [HttpPost]
        public OutAccountVM SignUp(InAccountVM inAccountVM)
        {
           return accountService.SignUp(inAccountVM);
        }
        [HttpPost]
        public OutAccountVM Login(InAccountVM inAccountVM)
        {
           return accountService.Login(inAccountVM);
        }

    }
}