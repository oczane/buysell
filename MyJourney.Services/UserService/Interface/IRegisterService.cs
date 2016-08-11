using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyJourney.Models;

namespace MyJourney.Services.UserService.Interface
{
    public interface IRegisterService
    {
        void Register(User userModel);
        User SaveUser(User userModel);
    }
}
