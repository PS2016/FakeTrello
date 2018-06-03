using FT.Api.Base;
using FT.Api.Model;
using FT.Services.Services;
using System;
using System.Web.Http;

namespace FT.Api.Controllers
{
    [VersionRoute("users")]
    public class UserController : ControllerBase
    {
        private readonly UserService _service;

        public UserController(UserService service)
        {
            _service = service;
        }


        [HttpGet]
        [Route("getId")]
        public ModelResponse<UserApiModel> Get([FromUri]Guid id)
        {
            return PrepareResponse<ModelResponse<UserApiModel>>(x => x.Item =_service.Get(id));
        }

        [HttpPut]
        [Route("update")]
        public ModelResponse<UserApiModel> Put(UserApiModel model)
        {
            return PrepareResponse<ModelResponse<UserApiModel>>(x => x.Item = _service.Update(model));
        }

        [HttpPost]
        [Route("create")]
        public ModelResponse<UserApiModel> Create(UserApiModel model,string email)
        {
            return PrepareResponse<ModelResponse<UserApiModel>>(u=>u.Item= _service.Add(model,email));
        }
        [HttpDelete]
        [Route("delete")]
        public  void Delete(Guid id)
        {
             _service.Delete(id);
        }
        [HttpGet]
        [Route("signin")]
        public ModelResponse<UserApiModel> SignIn([FromUri]string email, [FromUri]string password)
        {
            //if (!_service.VerifyPassword(email, password))
            //   return PrepareResponse<ModelResponse<UserApiModel>>(x => x.AddError("Invalid login or password."));

            return PrepareResponse<ModelResponse<UserApiModel>>(x => x.Item = _service.GetByEmail(email));
        }
    }
}
