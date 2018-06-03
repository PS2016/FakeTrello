using System.Collections.Generic;

namespace FT.Api.Model
{
    public class ResponseBase
    {
        public bool Ok { get; set; } = true;
        public List<BaseError> Errors { get; } = new List<BaseError>();

        public void AddError(BaseError error)
        {
            Errors.Add(error);
            Ok = false;
        }
    }
}
