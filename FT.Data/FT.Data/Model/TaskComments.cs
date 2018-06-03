using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FT.Data
{
    public class TaskComments
    {
        [Key,Column(Order = 1)]
        public Guid Id { get; set; }
        [Key, ForeignKey(nameof(Task)), Column(Order = 2)]
        public Guid TaskId { get; set; }
        [Required]
        [MaxLength(1024)]
        public string Text { get; set; }
        public DateTime DateCreated { get; set; }  
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        #region NavigationProps
        public virtual Task Task { get; set; }

        public virtual User User { get; set; }
        #endregion
    }
}
