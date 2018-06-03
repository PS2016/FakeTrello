using FT.Api.Base;

using FT.Services.Services;

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
        [Route("put")]
        public ModelResponse<UserApiModel> Put(UserApiModel model)
        {
            return PrepareResponse<ModelResponse<UserApiModel>>(x => x.Item = _service.Update(model));
        }

        [HttpPost]
        [Route("post")]
        public ModelResponse<UserApiModel> Create(UserApiModel model)
        {
            return PrepareResponse<ModelResponse<UserApiModel>>(u=>u.Item= _service.Add(model));
        }
        [HttpDelete]
        [Route("delete")]
        public  void Delete(Guid id)
        {
             _service.Delete(id);
        }
    }
}
