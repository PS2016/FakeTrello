using System;

namespace FT.Api.Model
{
    public class UserApiModel
    { 
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string HashPassword { get; set; }
        public DateTime? LastLogin { get; set; }

    }
}
