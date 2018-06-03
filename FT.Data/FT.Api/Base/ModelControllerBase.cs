using FT.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace FT.Api.Base
{
    public class ModelControllerBase<TModel, TKey> : ControllerBase
    {
        //private readonly ModelServiceBase<TModel, TKey> _service;

        //public ModelControllerBase(ModelServiceBase<TModel, TKey> service)
        //{
        //    _service = service;
        //}

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
        //public ResponseBase Create(TKey id)
        //{
        //    _service.Delete(id);
        //    return PrepareResponse<ResponseBase>();
        }
    }
}
