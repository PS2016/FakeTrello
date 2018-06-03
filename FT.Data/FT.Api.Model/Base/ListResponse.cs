using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT.Api.Model 
{
    public class ListResponse<TModel>:ResponseBase
    {
        public List<TModel> Items { get; set; }
    }
}
