using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT.Api.Model 
{
    public class ModelResponse<TModel>:ResponseBase
    {
        public TModel Item { get; set; }
    }
}
