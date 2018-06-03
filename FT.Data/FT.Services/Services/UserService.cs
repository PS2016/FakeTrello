using FT.Api.Model;
using FT.Data;
using FT.Services;
using System;
using System.Linq;

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
            
            _context.Users.Add(user);
            _context.SaveChanges();
            return NewUser;
        }
        public UserApiModel Update(UserApiModel NewUser)
        {
            var user = _context.Users.FirstOrDefault(x=>x.Id==NewUser.Id);
            user = new User { Id=NewUser.Id, Email = NewUser.Email, FirstName = NewUser.FirstName, LastName = NewUser.LastName, HashPassword = NewUser.HashPassword, LastLogin = NewUser.LastLogin };
            _context.SaveChanges();
            return NewUser;
            
        }
        public UserApiModel Get(Guid UserId)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id ==UserId);
            UserApiModel RetUser = new UserApiModel { Id = user.Id, Email = user.Email, FirstName = user.FirstName, LastName = user.LastName, HashPassword = user.HashPassword, LastLogin = user.LastLogin };
            return RetUser;
        }

        public void Delete(Guid UserId)
        {
     
                var user = _context.Users.FirstOrDefault(x => x.Id == UserId);
                _context.Users.Remove(user);
                _context.SaveChanges();
                
        }
    }
}
