using FT.Api.Model;
using FT.Data;
using System;

namespace FT.Services.Services
{
    public class UserService : ServiceBase
    {

        public UserService(FTContext context) : base(context)
        {

        }
        public UserApiModel Add(UserApiModel NewUser)
        {
            User user = new User { Id = NewUser.Id, Email = NewUser.Email, FirstName = NewUser.FirstName, LastName = NewUser.LastName, HashPassword = NewUser.HashPassword, LastLogin = NewUser.LastLogin };

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
