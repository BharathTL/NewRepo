using HookedMedia.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HookedMedia.Controllers
{
    public class MasterApiController : ApiController
    {
        public CampaignRepository repository = new CampaignRepository();

        // GET api/masterapi/
        public HttpResponseMessage GetMetadata()
        {

            Newtonsoft.Json.Linq.JObject masterData = repository.getMetadata();
            return Request.CreateResponse(HttpStatusCode.OK, masterData);
        }
    }
}
