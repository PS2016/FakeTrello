using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FT.Data.Enums.PriorityEnum;
using static FT.Data.Enums.StateEnum;

namespace FT.Data.DataModel
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
