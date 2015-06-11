using HookedMedia.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HookedMedia.Repositories
{
    public class CampaignRepository
    {
        public JObject getMetadata()
        {
            HookedMediaConnection hooked = new HookedMediaConnection();
            var masterRepository=hooked.CampaignMasters.ToList();
            var campaigncode=createCampaignCode();
            JObject masterData = JObject.FromObject(new
            {
                masterRepository
            });
            masterData.Add("CampaignCode",campaigncode);
            return masterData;
        }
        public string createCampaignCode()
        {
            return Guid.NewGuid().ToString();
        }
    }
}