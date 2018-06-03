using FT.Api.Model;
using FT.Data;
using FT.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FT.Api.Controllers
{
    public class TasksController : ApiController
    {
        private TaskService _service;
        public TasksController(TaskService service)
        {
            _service = service;
        }

        [HttpGet]
        public async System.Threading.Tasks.Task<ListResponse<TaskApiModel>> GetAll()
        {
            return new ListResponse<TaskApiModel> { Items = await _service.GetAll() };
        }

        [HttpDelete]
        public async System.Threading.Tasks.Task<bool> Delete(Guid Id)
        {
            return await _service.Delete(Id);
        }

    }
}
