using FT.Api.Model;
using FT.Data;
using FT.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT.Services.Services
{
    public class TaskCommentsServices:ServiceBase
    {
         public TaskCommentsServices(FTContext context):base(context)
        {
        }
        public TaskCommentApiModel Get(Guid id)
        {
            var comment = _context.TaskComment.FirstOrDefault(c => c.TaskId == id);
            if (comment == null) return null;
            return AutoMapperConfig.Mapper.Map<TaskComment, TaskCommentApiModel>(comment);
        }
        public TaskCommentApiModel Create(TaskCommentApiModel model)
        {
            var message = AutoMapperConfig.Mapper.Map<TaskCommentApiModel,TaskComment>(model);
            _context.TaskComment.Add(message);
            _context.SaveChanges();

            return AutoMapperConfig.Mapper.Map<TaskCommentApiModel, TaskComment>(message);
        }
    }
}
