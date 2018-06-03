using FT.Api.Model;
using FT.Data.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT.Services.Services
{
    public class UserService
    {
        public UserService()
        {

        }
        public UserApiModel Add(UserApiModel NewUser)
        {
            User user = new User { };
            return NewUser;
        }
        public UserApiModel Update(UserApiModel NewUser)
        {
            return NewUser;
        }
        public UserApiModel get(Guid UserId)
        {
            return null;
        }
    }
}
