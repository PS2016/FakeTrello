namespace FT.Api.Model
{
    public class ModelResponse<TModel>:ResponseBase
    {
        public TModel Item { get; set; }
    }
}
