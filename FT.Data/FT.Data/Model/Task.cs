using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FT.Data
{
    public class Task
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(1024)]
        public string Description { get; set; }
        public DateTime DateCreate { get; set; }
        public Priority Priority { get; set; }
        public Type Type { get; set; }
        public State State { get; set; }
        #region
        public virtual ICollection<User> Users { get; set; } = new HashSet<User>();
        #endregion
    }
}
