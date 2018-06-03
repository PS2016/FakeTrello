using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace FT.Data
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(33)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(33)]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [MaxLength(256)]
        [MinLength(8)]
        public string HashPassword { get; set; }
        public DateTime? LastLogin { get; set; }
        #region
        public virtual ICollection<Task> Tasks { get; set; } = new HashSet<Task>();
        #endregion
    }

}
