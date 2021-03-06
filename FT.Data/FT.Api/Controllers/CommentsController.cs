﻿using FT.Api.Base;
using FT.Api.Model;
using FT.Services.Services;
using System;
using System.Web.Http;

namespace FT.Api.Controllers
{
    [VersionRoute("comments")]
    public class CommentsController : ControllerBase
    {
        private readonly TaskCommentsService _service;
        public CommentsController(TaskCommentsService service) 
        {
            _service = service;
        }
    

        [HttpGet]
        [Route("")]
        public ModelResponse<TaskCommentApiModel> Get(Guid id)
        {
            var item = _service.Get(id);
            return PrepareResponse<ModelResponse<TaskCommentApiModel>>(x => x.Item = item);
        }

        [HttpPost]
        [Route("")]
        public ModelResponse<TaskCommentApiModel> Post(TaskCommentApiModel model)
        {
            var item = _service.Create(model);
            return PrepareResponse<ModelResponse<TaskCommentApiModel>>(x => x.Item = item);
        }

        [HttpPut]
        [Route("")]
        public ModelResponse<TaskCommentApiModel> Put(TaskCommentApiModel model)
        {
            var item = _service.Update(model);
            return PrepareResponse<ModelResponse<TaskCommentApiModel>>(x => x.Item = item);
        }

        [HttpPost]
        [Route("")]
        public ResponseBase Delete(Guid id)
        {
            _service.Delete(id);
            return PrepareResponse<ResponseBase>();
        }
    }
}
