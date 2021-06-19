using BeActive_API.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;
using System.Xml;

namespace BeActive_API.Controllers
{
    public class ListingsController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        //public List<Property> GetListing()
        //{
        //    var t = new Token();
        //    var tok = t.GetToken();
        //    var token = JsonConvert.DeserializeObject<Token>(tok);
        //    //HttpContext.Current.Session session = new HttpContext.Current.Session();
        //    //Session["AuthToken"] = token;

        //    var client = new RestClient("https://platform.reapit.cloud/properties?pageSize=25&pageNumber=1")
        //    {
        //        Timeout = -1
        //    };
        //    RestRequest request = new RestRequest(Method.GET);
        //    request.AddHeader("Authorization", "Bearer " + token.access_token);
        //    request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
        //    request.AddHeader("api-version", "2020-01-31");
        //    request.AddHeader("origin", "https://localhost:44359");
        //    request.AddHeader("reapit-customer", "SBOX");
        //    IRestResponse response = client.Execute(request);
        //    Console.WriteLine(response.Content);
        //    XmlDocument doc = new XmlDocument();
        //    doc.LoadXml(response.Content);
        //    string jsonText = JsonConvert.SerializeXmlNode(doc);
        //    var p = JsonConvert.DeserializeObject<JSON>(jsonText);
        //    var properties = p.Response.Property.Take(25);
        //    foreach (var i in properties)
        //    {
        //        try
        //        {
        //            var clients = new RestClient("https://webservice.reapit.net/ura/rest/property?ID=" + i.ID + "&ApiKey=5b3a97adab2585698101db27f3852709")
        //            {
        //                Timeout = -1
        //            };
        //            RestRequest requests = new RestRequest(Method.GET);
        //            requests.AddHeader("ApiKey", "5b3a97adab2585698101db27f3852709");
        //            requests.AddHeader("Content-Type", "application/json");
        //            IRestResponse responses = clients.Execute(requests);
        //            Console.WriteLine(responses.Content);
        //            XmlDocument docs = new XmlDocument();
        //            doc.LoadXml(responses.Content);
        //            string jsonTexts = JsonConvert.SerializeXmlNode(doc);
        //            var Prop = JsonConvert.DeserializeObject<PropertyJSON>(jsonTexts);
        //            i.Type = Prop.Response.Property.Type;
        //            i.PriceQualifier = Prop.Response.Property.PriceQualifier;
        //            i.PriceReduced = Prop.Response.Property.PriceReduced;
        //            i.PriceString = Prop.Response.Property.PriceString;
        //            i.ExchangePrice = Prop.Response.Property.ExchangePrice;
        //            i.SaleMaxPrice = Prop.Response.Property.SaleMaxPrice;
        //            i.SalePrice = Prop.Response.Property.SalePrice;
        //            i.SalePriceString = Prop.Response.Property.SalePriceString;
        //            i.Description = Prop.Response.Property.Description;
        //            i.Address1 = Prop.Response.Property.Address1;
        //            i.Image = Prop.Response.Property.Image;
        //            i.Size = Prop.Response.Property.Size;
        //            i.SizeString = Prop.Response.Property.SizeString;
        //            i.TotalBedrooms = Prop.Response.Property.TotalBedrooms;
        //            i.Postcode = Prop.Response.Property.Postcode;
        //        }
        //        catch (Exception ex)
        //        {

        //        }
        //    }
        //    return properties.ToList();
        //}


        public void GetPropertyDetails()
        {
            var t = new Token();
            var token = t.GetToken();
            XmlDocument doc = new XmlDocument();
            //doc.LoadXml(response.Content);
            string jsonText = JsonConvert.SerializeXmlNode(doc);
            var p = JsonConvert.DeserializeObject<JSON>(jsonText);

        }
    }
}