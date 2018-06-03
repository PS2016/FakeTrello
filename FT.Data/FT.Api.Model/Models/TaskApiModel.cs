using System;

namespace FT.Api.Model
{
    public class TaskApiModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public Priority Priority { get; set; }
        public Type Type { get; set; }
        public State State { get; set; }
    }
}
