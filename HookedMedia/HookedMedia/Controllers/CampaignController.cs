using HookedMedia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace HookedMedia.Controllers
{
    public class CampaignController : Controller
    {
        // GET: Campaign
        public ActionResult Index()
        {
            return View();
        }
    }
    public class CreateCampaignController: ApiController
    {
        public HttpResponseMessage Post([FromBody]Campaign value)
        {
             return Request.CreateResponse(HttpStatusCode.OK, value);
        }
    }
}