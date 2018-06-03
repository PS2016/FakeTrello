using FT.Api.Base;
using FT.Api.Model;

using FT.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FT.Api.Controllers
{
    public class TasksController : ControllerBase
    {
        private readonly TaskService _service;
        public TasksController(TaskService service) 
        {
            _service = service;
        }

        [HttpGet]
        [Route("all")]
        public ListResponse<TaskApiModel> GetAll([FromUri]Guid userId)
        {
            return PrepareResponse<ListResponse<TaskApiModel>>(x => x.Items = _service.GetAll(userId));
        }

        [HttpGet]
        [Route("clear")]
        public ResponseBase Clear([FromUri]Guid taskId)
        {
            _service.Clear(taskId);
            return PrepareResponse<ResponseBase>();
        }



        [HttpGet]
        [Route("")]
        public ModelResponse<TaskApiModel> Get(Guid id)
        {
            var item = _service.Get(id);
            return PrepareResponse<ModelResponse<TaskApiModel>>(x => x.Item = item);
        }

        [HttpPost]
        [Route("")]
        public ModelResponse<TaskApiModel> Post(TaskApiModel model)
        {
            var item = _service.Create(model);
            return PrepareResponse<ModelResponse<TaskApiModel>>(x => x.Item = item);
        }

        [HttpPut]
        [Route("")]
        public ModelResponse<TaskApiModel> Put(TaskApiModel model)
        {
            var item = _service.Update(model);
            return PrepareResponse<ModelResponse<TaskApiModel>>(x => x.Item = item);
        }

        [HttpPost]
        [Route("")]
        public ResponseBase Create(Guid id)
        {
            _service.Delete(id);
            return PrepareResponse<ResponseBase>();
        }
    }
}
