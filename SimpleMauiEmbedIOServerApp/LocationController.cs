using EmbedIO.Routing;
using EmbedIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmbedIO.WebApi;

namespace SimpleMauiEmbedIOServerApp
{
    public class LocationController : WebApiController
    {
        [Route(HttpVerbs.Get, "/location")]
        public object GetLocation() => new { Latitude = 40.7128, Longitude = -74.0060 };
    }
}
