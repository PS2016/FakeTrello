using FT.Api.Model;
using FT.Data;
using FT.Services.Config;
using System;
using System.Linq;

namespace FT.Services.Services
{
    public class TaskCommentsService : ServiceBase
    {
        public TaskCommentsService(FTContext context) : base(context)
        {
        }
        public TaskCommentApiModel Get(Guid id)
        {
            var comment = _context.TaskComments.FirstOrDefault(c => c.TaskId == id);
            if (comment == null) return null;
            return AutoMapperConfig.Mapper.Map<TaskComment, TaskCommentApiModel>(comment);
        }
        public TaskCommentApiModel Create(TaskCommentApiModel model)
        {
            var message = AutoMapperConfig.Mapper.Map<TaskCommentApiModel, TaskComment>(model);
            _context.TaskComments.Add(message);
            _context.SaveChanges();
            return AutoMapperConfig.Mapper.Map<TaskCommentApiModel, TaskComment>(message);
        }
        public TaskCommentApiModel Update(TaskCommentApiModel model)
        {
            var text = _context.TaskComments.FirstOrDefault(t => t.Id == model.Id);
            if (text == null) return null;
            text.Text = model.Text;
            _context.SaveChanges();
            return AutoMapperConfig.Mapper.Map<TaskComment, TaskCommentApiModel>(text);
        }
        public void Delete(Guid id)
        {
            var message = _context.TaskComments.FirstOrDefault(m => m.UserId == id);
            if (message == null)
                return;
            _context.TaskComments.Remove(message);
            _context.SaveChanges();
        }
    }
    public List<TaskCommentApiModel> GetByTaskId(Guid TaskId)
    {
        var list = AutoMapper.Mapper.Map<List<TaskCommentApiModel>>(_context.TaskComments.Where(x => x.TaskId == TaskId).ToList());

        return list.OrderBy(x => x.DateCreated).ToList();
    }
}
