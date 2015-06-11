using HookedMedia.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HookedMedia.Controllers
{
    public class CreativeController : ApiController
    {
        public CreativeRepository repository = new CreativeRepository();
        public HttpResponseMessage CreateCreative()
        {
            Dictionary<string, string> formData = Request.GetQueryNameValuePairs()
                       .ToDictionary(kv => kv.Key, kv => kv.Value,
                            StringComparer.OrdinalIgnoreCase);
            HttpStatusCode resopnseStatus = repository.addCreative(formData);
            return Request.CreateResponse(resopnseStatus, "");
        }
    }
}
