using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using innfact.Models;
using innfact.ViewModels.In;
using innfact.Helper;
using innfact.ViewModels.Out;
using Microsoft.AspNetCore.Http;

namespace innfact.Service
{
    public class AccountService
    {
        private readonly innfactContext db;
        public AccountService(innfactContext _db)
        {
            db = _db;
        }
        public OutAccountVM SignUp(InAccountVM account)
        {
            var hasBeenSignUp = db.Accounts.SingleOrDefault(x => x.Email == account.Email && x.LoginBy == account.LoginBy);
            var result = new OutAccountVM();
            if(hasBeenSignUp!=null)
            {
                result.StatusCode = StatusCodes.Status500InternalServerError;
                return result;
            }
            var value = new Accounts()
            {
                AccountId = Guid.NewGuid(),
                BirthDay = account.BirthDay,
                Email = account.Email,
                LoginBy = account.LoginBy,
                Password = AccountHelper.EncodePassword(account.Password) ?? "",
                RoleId = db.Roles.FirstOrDefault(x => x.RoleName == "一般使用者").RoleId,
                UserName = account.UserName
            };
            db.Accounts.Add(value);
            db.SaveChanges();
            result.StatusCode = StatusCodes.Status200OK;
            return result;
        }
        public OutAccountVM Login(InAccountVM account)
        {
            var result = new OutAccountVM();
            var value = db.Accounts.Where(x => x.LoginBy == account.LoginBy)
                                   .SingleOrDefault(x => x.Email == account.Email && x.Password == AccountHelper.EncodePassword(account.Password));
            if(value!=null)
            {
                result.StatusCode = StatusCodes.Status200OK;
                result.AccountID = value.AccountId;
                result.Email = value.Email;
                result.Name = value.UserName;
               
            }
            else
            {
                result.StatusCode = StatusCodes.Status500InternalServerError;
            }


            return result;
            
        }
    }
}
