using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT.Api.Model
{
    public class BaseError
    {
        public string  Message { get; set; }
        public string  StackTrace { get; set; }
    }
}
