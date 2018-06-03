using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableModel.DataModel
{
    public class Users
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required][ MaxLength(1024)]
        public string Description { get; set; }
        public DateTime DateCreate { get; set; }
        public Priority Priority{ get; set; }

    }
    public enum Priority
    {
        Low=0x01,
        Normal=0x02,
        High=0x03
    }
    public enum Type
    {
        Bug=0x01,
        ChangeRequest=0x02,
        UserStory=0x03
    }
    public enum State
    {
         
    }
}
