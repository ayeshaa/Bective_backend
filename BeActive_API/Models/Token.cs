using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace BeActive_API.Models
{
    public class Token
    {
        public string access_token
        {
            get; set;
        }
        public int expires_in
        {
            get; set;
        }
        public string token_type
        {
            get; set;
        }
        public string GetToken()
        {
            var client = new RestClient("https://connect.reapit.cloud/token?client_id=5p7osfnq3j9ml40o5es1grip4t&grant_type=client_credentials")
            {
                Timeout = -1
            };
            RestRequest request = new RestRequest(Method.POST);
            //request.AddHeader("ApiKey", "5b3a97adab2585698101db27f3852709");
            //request.AddHeader("Content-Type", "application/json");

            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Authorization", "Basic NXA3b3NmbnEzajltbDQwbzVlczFncmlwNHQ6NjBubXR0dmQzOTJsMDZ1cTFjamc0bzVsaThudmQ0ZjJpMm9xOHFpbWtxdjF2Zmtmb2Q0");
            request.AddHeader("Origin", "https://localhost:44359");
            IRestResponse response = client.Execute(request);
            return response.Content;
            //Session["AuthToken"] = token;
        }
    }
}