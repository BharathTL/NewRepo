using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HookedMedia.Repositories
{

    public class CreativeRepository
    {


        public System.Net.HttpStatusCode addCreative(Dictionary<string, string> creativeData)
        {
            try
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["HookedMediaConnection"].ConnectionString;
                using (SqlCommand cmd = new SqlCommand("campaignCreator", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@campaign_code", creativeData["campaignCode"]);
                    cmd.Parameters.AddWithValue("@title", creativeData["creativeTitle"]);
                    cmd.Parameters.AddWithValue("@type", creativeData["creativeType"]);
                    cmd.Parameters.AddWithValue("@vasturl", creativeData["vastUrl"]);
                    cmd.Parameters.AddWithValue("@xml", creativeData["xmlContent"]);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                return System.Net.HttpStatusCode.OK;
            }
            catch(Exception ex)
            {
                return System.Net.HttpStatusCode.NotFound;
            }
        }
    }
}