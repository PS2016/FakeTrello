using System;

namespace FT.Api.Model
{
    public class TaskCommentApiModel
    {
        public Guid Id { get; set; }
        public Guid TaskId { get; set; }
        public DateTime DateCreated { get; set; }
        public string Text { get; set; }
        public Guid UserId { get; set; }
    }
}
