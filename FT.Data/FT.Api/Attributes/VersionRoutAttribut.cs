using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace FT.Api
{
    public class VersionRouteAttribute : RoutePrefixAttribute
    {
        public VersionRouteAttribute(string route, int major = 1) : base($"api/v{major}/{route}")
        {

        }
    }
}