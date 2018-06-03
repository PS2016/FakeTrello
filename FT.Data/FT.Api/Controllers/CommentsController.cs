using FT.Api.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FT.Api.Controllers
{
    //public class CommentsController : ModelControllerBase<TaskModel, Guid>
    //{
    //    private readonly CommentService _service;
    //    public CommentsController(CommentService service) : base(service)
    //    {
    //        _service = service;
    //    }

    //    [HttpGet]
    //    [Route("all")]
    //    public ListResponse<CommentModel> GetAll([FromUri]Guid userId)
    //    {
    //        return PrepareResponse<ListResponse<TaskModel>>(x => x.Items = _service.GetAll(userId));
    //    }

    //    [HttpGet]
    //    [Route("clear")]
    //    public ResponseBase Clear([FromUri]Guid diaryId)
    //    {
    //        _service.Clear(diaryId);
    //        return PrepareResponse<ResponseBase>();
    //    }
    //}
}
