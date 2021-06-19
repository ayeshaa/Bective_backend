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
    public class PropertyController : ApiController
    {

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public List<Property> GetProperties(string SearchType, string PropertyLocality)
        {
            var client = new RestClient("https://webservice.reapit.net/ura/rest/properties/general?SearchType=" + SearchType + "&PropertyLocality=" + PropertyLocality + "&Area=" + PropertyLocality + "&PropertyField=ID,PriceString,Image,SizeString,Type,TotalBedrooms,Address1,SizeString,Postcode,Status,InternalSaleStatus,Latitude,Longitude")
            {
                Timeout = -1
            };
            RestRequest request = new RestRequest(Method.GET);
            request.AddHeader("ApiKey", "5b3a97adab2585698101db27f3852709");
            request.AddHeader("Content-Type", "application/json");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(response.Content);
            string jsonText = JsonConvert.SerializeXmlNode(doc);
            try
            {
                var p = JsonConvert.DeserializeObject<JSON>(jsonText);
                var properties = p.Response.Property;
                return properties.ToList();
            }
            catch(Exception ex)
            {
                var p = JsonConvert.DeserializeObject<JSONSigle>(jsonText);

                var properties = new List<Property>();

                properties.Add(p.Response.Property);

                return properties;
            }
            //foreach (var i in properties)
            //{
            //    try
            //    {
            //        var clients = new RestClient("https://webservice.reapit.net/ura/rest/property?ID=" + i.ID + "&ApiKey=5b3a97adab2585698101db27f3852709")
            //        {
            //            Timeout = -1
            //        };
            //        RestRequest requests = new RestRequest(Method.GET);
            //        requests.AddHeader("ApiKey", "5b3a97adab2585698101db27f3852709");
            //        requests.AddHeader("Content-Type", "application/json");
            //        IRestResponse responses = clients.Execute(requests);
            //        Console.WriteLine(responses.Content);
            //        XmlDocument docs = new XmlDocument();
            //        docs.LoadXml(responses.Content);
            //        string jsonTexts = JsonConvert.SerializeXmlNode(docs);
            //        var Prop = JsonConvert.DeserializeObject<PropertyJSON>(jsonTexts);
            //        i.Type = Prop.Response.Property.Type;
            //        i.PriceQualifier = Prop.Response.Property.PriceQualifier;
            //        i.PriceReduced = Prop.Response.Property.PriceReduced;
            //        i.PriceString = Prop.Response.Property.PriceString;
            //        i.ExchangePrice = Prop.Response.Property.ExchangePrice;
            //        i.SaleMaxPrice = Prop.Response.Property.SaleMaxPrice;
            //        i.SalePrice = Prop.Response.Property.SalePrice;
            //        i.SalePriceString = Prop.Response.Property.SalePriceString;
            //        i.Description = Prop.Response.Property.Description;
            //        i.Address1 = Prop.Response.Property.Address1;
            //        i.Address2 = Prop.Response.Property.Address2;
            //        i.Address3 = Prop.Response.Property.Address3;
            //        i.Address4 = Prop.Response.Property.Address4;
            //        i.Image = Prop.Response.Property.Image;
            //        i.Size = Prop.Response.Property.Size;
            //        i.SizeString = Prop.Response.Property.SizeString;
            //        i.TotalBedrooms = Prop.Response.Property.TotalBedrooms;
            //        i.Postcode = Prop.Response.Property.Postcode;
            //        i.Address2 = Prop.Response.Property.Address2;
            //        i.Address3 = Prop.Response.Property.Address3;
            //        i.Address4 = Prop.Response.Property.Address4;
            //        i.Area = Prop.Response.Property.Area;
            //        i.Negotiator = Prop.Response.Property.Negotiator;
            //        i.Tenure = Prop.Response.Property.Tenure;
            //        i.AccommodationSummary = Prop.Response.Property.AccommodationSummary;
            //        i.LongDesc = Prop.Response.Property.LongDesc;
            //    }
            //    catch (Exception ex)
            //    {

            //    }
            //}
            
        }
        
       
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public Property GetPopertyDetail(string ID)
        {
            var i = new Property();
            try
            {
                var clients = new RestClient("https://webservice.reapit.net/ura/rest/property?ID=" + ID + "&ApiKey=5b3a97adab2585698101db27f3852709")
                {
                    Timeout = -1
                };
                RestRequest requests = new RestRequest(Method.GET);
                requests.AddHeader("ApiKey", "5b3a97adab2585698101db27f3852709");
                requests.AddHeader("Content-Type", "application/json");
                IRestResponse responses = clients.Execute(requests);
                Console.WriteLine(responses.Content);
                XmlDocument docs = new XmlDocument();
                docs.LoadXml(responses.Content);
                string jsonTexts = JsonConvert.SerializeXmlNode(docs);
                var Prop = JsonConvert.DeserializeObject<PropertyDetailJSON>(jsonTexts);
                if(Prop.Response.Property.LongDesc != null)
                Prop.Response.Property.LongDesc = Prop.Response.Property.LongDesc.ToString();
                if (Prop.Response.Property.Description != null)
                    Prop.Response.Property.Description = Prop.Response.Property.Description.ToString();
                return Prop.Response.Property;

                i.Type = Prop.Response.Property.Type;
                i.PriceQualifier = Prop.Response.Property.PriceQualifier;
                i.PriceReduced = Prop.Response.Property.PriceReduced;
                i.PriceString = Prop.Response.Property.PriceString;
                i.ExchangePrice = Prop.Response.Property.ExchangePrice;
                i.SaleMaxPrice = Prop.Response.Property.SaleMaxPrice;
                i.SalePrice = Prop.Response.Property.SalePrice;
                i.SalePriceString = Prop.Response.Property.SalePriceString;
                i.Description = Prop.Response.Property.Description;
                i.Address1 = Prop.Response.Property.Address1;
                i.Image = Prop.Response.Property.Image;
                i.Size = Prop.Response.Property.Size;
                i.SizeString = Prop.Response.Property.SizeString;
                i.TotalBedrooms = Prop.Response.Property.TotalBedrooms;
                i.Postcode = Prop.Response.Property.Postcode;
                i.Address2 = Prop.Response.Property.Address2;
                i.Address3 = Prop.Response.Property.Address3;
                i.Address4 = Prop.Response.Property.Address4;
                i.Area = Prop.Response.Property.Area;
                i.Negotiator = Prop.Response.Property.Negotiator;
                i.Tenure = Prop.Response.Property.Tenure;
                i.AccommodationSummary = Prop.Response.Property.AccommodationSummary;
                i.LongDesc = Prop.Response.Property.LongDesc.ToString();
                return i;
            }
            catch (Exception e)
            {
                return i;
            }
        }
        //[EnableCors(origins: "*", headers: "*", methods: "*")]
        //public Object GetProperties(string SearchType, string PropertyLocality)
        //{
        //    var t = getToken();
        //    var client = new RestClient("https://platform.reapit.cloud/properties?pageSize=25&pageNumber=1");
        //    client.Timeout = -1;
        //    var request = new RestRequest(Method.GET);
        //    request.AddHeader("Content-Type", "application/json");
        //    request.AddHeader("Authorization", "Bearer " + t);
        //    request.AddHeader("api-version", "2020-01-31");
        //    request.AddHeader("reapit-customer", "SBOX");
        //    IRestResponse response = client.Execute(request);
        //     Console.WriteLine(response.Content);
        //      //string jsonText = JsonConvert.SerializeObject(doc);
        //      // var p = JsonConvert.DeserializeObject<Responses>(jsonText);
        //    var p = JsonConvert.DeserializeObject<Responses>(response.Content);
        //    //List<Property> p = new List<Property>();
        //    return p;
        //}
        public string getToken()
        {
            var client = new RestClient("https://connect.reapit.cloud/token");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Authorization", "Basic NXA3b3NmbnEzajltbDQwbzVlczFncmlwNHQ6NjBubXR0dmQzOTJsMDZ1cTFjamc0bzVsaThudmQ0ZjJpMm9xOHFpbWtxdjF2Zmtmb2Q0");
            request.AddParameter("client_id", "5p7osfnq3j9ml40o5es1grip4t");
            request.AddParameter("grant_type", "client_credentials");
            request.AddHeader("reapit-customer", "SBOX");
            IRestResponse response = client.Execute(request);
            //AccessToken accessToken = response.Content;
            Console.WriteLine(response.Content);
            //token = response.Content.access_token;
            Console.WriteLine();
            AccessToken t = JsonConvert.DeserializeObject<AccessToken>(response.Content);
            var token = t.access_token;
            return t.access_token;
        }
    }
}