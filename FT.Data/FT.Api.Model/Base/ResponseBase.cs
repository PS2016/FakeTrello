using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
