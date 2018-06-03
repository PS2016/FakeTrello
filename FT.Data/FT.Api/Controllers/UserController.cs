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
    public class UserController : ControllerBase
    {
        private readonly UserService _service;

        public UserController(UserService service)
        {
            _service = service;
        }


        //[HttpGet]
        //[Route("")]
        //public ModelResponse<UserApiModel> Get(Guid id)
        //{
        //    var item = _service.Get(id);
        //    return PrepareResponse<ModelResponse<UserApiModel>>(x => x.Item = item);
        //}

        //[HttpPost]
        //[Route("")]
        //public ModelResponse<UserApiModel> Post(UserApiModel model)
        //{
        //    var item = _service.Create(model);
        //    return PrepareResponse<ModelResponse<UserApiModel>>(x => x.Item = item);
        //}

        //[HttpPut]
        //[Route("")]
        //public ModelResponse<UserApiModel> Put(UserApiModel model)
        //{
        //    var item = _service.Update(model);
        //    return PrepareResponse<ModelResponse<UserApiModel>>(x => x.Item = item);
        //}

        //[HttpPost]
        //[Route("")]
        //public ResponseBase Create(Guid id)
        //{
        //    _service.Delete(id);
        //    return PrepareResponse<ResponseBase>();
        //}
    }
}
