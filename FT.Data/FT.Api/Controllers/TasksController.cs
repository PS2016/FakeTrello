using FT.Api.Model;
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
        //private readonly TasksService _service;
        //public TasksController(TasksService service) : base(service)
        //{
        //    _service = service;
        //}

        //[HttpGet]
        //[Route("all")]
        //public ListResponse<TaskApiModel> GetAll([FromUri]Guid userId)
        //{
        //    return PrepareResponse<ListResponse<TaskApiModel>>(x => x.Items = _service.GetAll(userId));
        //}

        //[HttpGet]
        //[Route("clear")]
        //public ResponseBase Clear([FromUri]Guid taskId)
        //{
        //    _service.Clear(taskId);
        //    return PrepareResponse<ResponseBase>();
        //}
    }
}
