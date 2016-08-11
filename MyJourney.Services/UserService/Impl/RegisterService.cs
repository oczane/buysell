using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyJourney.Services.UserService.Interface;
using MyJourney.Models;
using MyJourney.AppRepository;

namespace MyJourney.Services.UserService.Impl
{
    public class RegisterService : IRegisterService
    {
        IRepository<User> user;

        public RegisterService(IRepository<User> _user)
        {
            user = _user;
        }

        public void Register(User userModel)
        {
            user.Insert(userModel);
        }

        public User SaveUser(User userModel)
        {
            return user.InsertReturnEntity(userModel);
        }
    }
}
