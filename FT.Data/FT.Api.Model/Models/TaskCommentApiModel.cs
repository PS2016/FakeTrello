using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT.Api.Model
{
    public class TaskCommentApiModel
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string Text { get; set; }
        public Guid UserId { get; set; }
    }
}
