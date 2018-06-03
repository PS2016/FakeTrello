using FT.Api.Model;
using FT.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace FT.Api.Base
{
    public class ControllerBase: ApiController
    {
        
        protected TResponse PrepareResponse<TResponse>(Action<TResponse> overrides = null) where TResponse : ResponseBase, new()
        {
            var resp = new TResponse();
            overrides?.Invoke(resp);
            return resp;
        }
    }
}