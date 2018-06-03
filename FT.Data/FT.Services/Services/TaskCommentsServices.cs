using FT.Api.Model;
using FT.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT.Services.Services
{
    public class TaskCommentsServices : ServiceBase
    {
        public TaskCommentsServices(FTContext context) : base(context)
        {
        }
        public TaskCommentApiModel Add(TaskCommentApiModel NewModel)
        {
            var model = AutoMapper.Mapper.Map<TaskComment>(NewModel);
            _context.TaskComments.Add(model);
            _context.SaveChanges();
            return NewModel;
        }
        public TaskCommentApiModel Update(TaskCommentApiModel NewModel)
        {
            var model= _context.TaskComments.FirstOrDefault(x => x.Id == NewModel.Id);
            model= AutoMapper.Mapper.Map<TaskComment>(NewModel);
            _context.SaveChanges();
            return NewModel;
        }
        public TaskCommentApiModel Get(Guid Id)
        {
            var model = _context.TaskComments.FirstOrDefault(x => x.Id == Id);
            return AutoMapper.Mapper.Map<TaskCommentApiModel>(model);
        }
        public List<TaskCommentApiModel> GetByTaskId(Guid TaskId)
        {
            var list = AutoMapper.Mapper.Map<List<TaskCommentApiModel>>(_context.TaskComments.Where(x => x.TaskId == TaskId).ToList());
            
            return list.OrderBy(x => x.DateCreated).ToList(); 
        }
        public void Delete(Guid Id)
        {
            var model = _context.TaskComments.FirstOrDefault(x => x.Id == Id);
            _context.TaskComments.Remove(model);

        }
    }
}
