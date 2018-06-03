using System.Collections.Generic;

namespace FT.Api.Model
{
    public class ListResponse<TModel>:ResponseBase
    {
        public List<TModel> Items { get; set; }
    }
}
