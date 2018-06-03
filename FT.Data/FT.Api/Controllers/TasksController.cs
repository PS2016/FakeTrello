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
        private readonly TaskServices _service;
        //public TasksController(TaskServices service) : base(service)
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
