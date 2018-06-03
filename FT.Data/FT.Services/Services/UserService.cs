using AutoMapper;
using FT.Api.Model;
using FT.Data;
using FT.Services.Config;
using System;
using System.Linq;
using System.Web.Helpers;

namespace FT.Services.Services
{
    public class UserService : ServiceBase
    {
        public UserService(FTContext context) : base(context)
        {

        }
        public UserApiModel Add(UserApiModel NewUser,string password)
        {            
            var user = Mapper.Map<UserApiModel, User>(NewUser);

            user.HashPassword = Crypto.HashPassword(password);

            _context.Users.Add(user);
            _context.SaveChanges();
            return NewUser;
        }
        public UserApiModel Update(UserApiModel NewUser)
        {
            var user = _context.Users.FirstOrDefault(x=>x.Id==NewUser.Id);
            user = Mapper.Map<UserApiModel, User>(NewUser);
            _context.SaveChanges();
            return NewUser;
            
        }
        public UserApiModel Get(Guid UserId)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id ==UserId);
            UserApiModel RetUser = Mapper.Map<User, UserApiModel>(user);
            return RetUser;
        }

        public void Delete(Guid UserId)
        {
     
                var user = _context.Users.FirstOrDefault(x => x.Id == UserId);
                _context.Users.Remove(user);
                _context.SaveChanges();
                
        }
        public bool Verify(string Email,string password)
        {
            var user = _context.Users.FirstOrDefault(x=>x.Email==Email);
            if (user == null)
                return false;
            else if (Crypto.VerifyHashedPassword(password, user.HashPassword))
            {
                return true;
            }
            else return false;

        }
        public UserApiModel GetByEmail(string email)
        {
            var user = _context.Users.FirstOrDefault(x => x.Email == email);
            return AutoMapperConfig.Mapper.Map<User, UserApiModel>(user);
        }
    }
}
