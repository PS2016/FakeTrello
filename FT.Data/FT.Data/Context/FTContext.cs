using FT.Data.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT.Data
{
    public class FTContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<DataModel.Task> Tasks { get; set; }
        public DbSet<TaskComments> TaskComments { get; set; }
        public FTContext(string connection):base(connection)
        {
        }
        public FTContext() : base("FTConnection") { }
    }
}
