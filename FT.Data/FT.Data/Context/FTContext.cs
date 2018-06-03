using System.Data.Entity;

namespace FT.Data
{
    public class FTContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskComment> TaskComments { get; set; }
        public FTContext(string connection):base(connection)
        {
        }
        public FTContext() : base("FTConnection") { }
    }
}
