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
            var res = _context.Tasks.FirstOrDefault(t => t.Id == Id);
            var task= AutoMapper.Mapper.Map<TaskApiModel>(res);
            return task;

        }
        public TaskApiModel Add(TaskApiModel NewTask)
        {
            var task = AutoMapper.Mapper.Map<Task>(NewTask);
            _context.Tasks.Add(task);
            _context.SaveChanges();
            return NewTask;

        }
        public TaskApiModel Update(TaskApiModel NewTask)
        {
            var task = AutoMapper.Mapper.Map<Task>(NewTask);
            var taskFind =_context.Tasks.FirstOrDefault(x=>x.Id==NewTask.Id);
            taskFind = task;
            _context.SaveChanges();
            return NewTask;

        }
        public void Delete(Guid TaskId)
        {
   
                var task = _context.Users.FirstOrDefault(x => x.Id == TaskId);
                _context.Users.Remove(task);
                _context.SaveChanges();
                return true;
            


        }
    }
}
