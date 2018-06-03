using FT.Api.Model;
using FT.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace FT.Api.Base
{
    public class ModelControllerBase<TModel> : ControllerBase
    {
        private readonly ServiceBase<TModel> _service;

        public ModelControllerBase(ServiceBase<TModel> service)
        {
            _service = service;
        }

        //[HttpGet]
        //[Route("")]
        //public ModelResponse<TModel> Get(TKey id)
        //{
        //    var item = _service.Get(id);
        //    return PrepareResponse<ModelResponse<TModel>>(x => x.Item = item);
        //}

        //[HttpPost]
        //[Route("")]
        //public ModelResponse<TModel> Post(TModel model)
        //{
        //    var item = _service.Create(model);
        //    return PrepareResponse<ModelResponse<TModel>>(x => x.Item = item);
        //}

        //[HttpPut]
        //[Route("")]
        //public ModelResponse<TModel> Put(TModel model)
        //{
        //    var item = _service.Update(model);
        //    return PrepareResponse<ModelResponse<TModel>>(x => x.Item = item);
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

