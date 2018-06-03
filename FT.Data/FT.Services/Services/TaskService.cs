using FT.Api.Model;
using FT.Data;
using System;
using System.Linq;

namespace FT.Services.Services
{
    public class TaskService : ServiceBase
    {
        public TaskService(FTContext context): base(context)
        {

        }

        public TaskApiModel Get(Guid Id)
        {
            var res = _context.Tasks.FirstOrDefault(t => t.id == Id);
            return null;

        }

    }
}
