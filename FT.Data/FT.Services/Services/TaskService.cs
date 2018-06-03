using FT.Api.Model;
using FT.Data;
using System;
using System.Collections.Generic;
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
            var res = _context.Tasks.FirstOrDefault(t => t.Id == Id);
            return null;

        }
        public List<TaskApiModel> GetAll(Guid Id)
        {

            return new List<TaskApiModel>();

        }
        public TaskApiModel Clear(Guid Id)
        {
            
            return null;

        }
    }
}
