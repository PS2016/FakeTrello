using FT.Api.Model;
using FT.Data;
using System;
using AutoMapper;
using System.Data.Entity;
using System.Collections.Generic;

namespace FT.Services
{
    public class TaskService : ServiceBase
    {
        public TaskService(FTContext context) : base(context)
        {

        }

        public async System.Threading.Tasks.Task<TaskApiModel> Get(Guid Id)
        {
            var res = await _context.Tasks.FirstOrDefaultAsync(t => t.Id == Id);

            return Mapper.Map<Task, TaskApiModel>(res);

        }

        public async System.Threading.Tasks.Task<List<TaskApiModel>> GetAll()
        {
            var res =  _context.Tasks;

            var convertedRes = await res.ToListAsync();

            return Mapper.Map<List<Task>, List<TaskApiModel>>(convertedRes);

        }

        public async System.Threading.Tasks.Task<TaskApiModel> CreateAsync(TaskApiModel model)
        {
            _context.Tasks.Add(Mapper.Map<TaskApiModel, Task>(model));

            _context.SaveChanges();

            return await Get(model.Id);

        }

        public async System.Threading.Tasks.Task<TaskApiModel> Update(TaskApiModel model)
        {
            var res = await _context.Tasks.FirstOrDefaultAsync(t => t.Id == model.Id);

            res.Priority = model.Priority;
            res.State = model.State;
            res.Title = model.Title;
            res.Description = model.Description;

            await _context.SaveChangesAsync();

            return await Get(res.Id);
        }

        public async System.Threading.Tasks.Task<bool> Delete(Guid Id)
        {
            var res = await _context.Tasks.FirstOrDefaultAsync(t => t.Id == Id);

            _context.Tasks.Remove(res);

            _context.SaveChanges();

            var deleteTry = Get(Id);

            return deleteTry == null;
        }

    }
}
