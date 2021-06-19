using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

namespace BeActive_API.Models
{
    public class Property
    {
        public string ID
        {
            get; set;
        }
        public string TotalBedrooms
        {
            get; set;
        }
        public string Postcode
        {
            get; set;
        }
        public string PriceString
        {
            get; set;
        }
        public string SalePrice
        {
            get; set;
        }
        public string SaleMaxPrice
        {
            get; set;
        }
        public string SalePriceString
        {
            get; set;
        }
        public string ExchangePrice
        {
            get; set;
        }
        public string WeeklyRent
        {
            get; set;
        }
        public string PropertyArchived
        {
            get; set;
        }
        public string PriceQualifier
        {
            get; set;
        }
        public string Currency
        {
            get; set;
        }
        public string PriceReduced
        {
            get; set;
        }
        public string Size
        {
            get; set;
        }
        public string MaxSize
        {
            get; set;
        }
        public string SizeString
        {
            get; set;
        }
        public string NumPlots
        {
            get; set;
        }
        public string HouseNumber
        {
            get; set;
        }
        public string Address1
        {
            get; set;
        }
        public string Address2
        {
            get; set;
        }
        public string Address3
        {
            get; set;
        }
        public string Address4
        {
            get; set;
        }
        public string Area
        {
            get; set;
        }
        public MatchArea MatchArea
        {
            get; set;
        }
        public string Country
        {
            get; set;
        }
        public string Latitude
        {
            get; set;
        }
        public string Longitude
        {
            get; set;
        }
        public string Available
        {
            get; set;
        }
        public string AvailableFrom
        {
            get; set;
        }
        public string TimeAmended
        {
            get; set;
        }
        public string IsErased
        {
            get; set;
        }
        public string Tenure
        {
            get; set;
        }
        public List<string> AccommodationSummary
        {
            get; set;
        }
        public Object LongDesc
        {
            get; set;
        }
        public string Disposal
        {
            get; set;
        }
        public string HasGas
        {
            get; set;
        }
        public string AgencyType
        {
            get; set;
        }
        public object Description
        {
            get; set;
        }
        [JsonConverter(typeof(SingleOrArrayConverter<Image>))]
        public object Image
        {
            get; set;
        }
        public object Floorplan
        {
            get; set;
        }
        public object EPC
        {
            get; set;
        }
        public string DetailsApproved
        {
            get; set;
        }
        public string PDF
        {
            get; set;
        }
        public string Status
        {
            get; set;
        }
        public string InternalSaleStatus
        {
            get; set;
        }
        public Office Office
        {
            get; set;
        }
        public Negotiator Negotiator
        {
            get; set;
        }
        public object Type
        {
            get; set;
        }
    }
    public class Negotiator
    {
        public string ID
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public string Email
        {
            get; set;
        }
        public string Telephone
        {
            get; set;
        }
        public string Mobile
        {
            get; set;
        }
    }
    public class Office
    {
        public string ID
        {
            get; set;
        }
    }
    public class Image
    {
        public string Filepath
        {
            get; set;
        }
        public string Caption
        {
            get; set;
        }
        public string TimeAmended
        {
            get; set;
        }
    }
    public class Floorplan
    {
        public string Filepath
        {
            get; set;
        }
        public string Caption
        {
            get; set;
        }
        public string TimeAmended
        {
            get; set;
        }
        public string Width
        {
            get; set;
        }
        public string Height
        {
            get; set;
        }
    }
    public class MatchArea
    {
        public string ID
        {
            get; set;
        }
    }
    public class Address
    {
        public string buildingName
        {
            get; set;
        }
        public string buildingNumber
        {
            get; set;
        }
        public string line1
        {
            get; set;
        }
        public string line2
        {
            get; set;
        }
        public string line3
        {
            get; set;
        }
        public string line4
        {
            get; set;
        }
        public string postcode
        {
            get; set;
        }
        public string countryId
        {
            get; set;
        }
        public geolocation geolocation
        {
            get; set;
        }
    }
    public class geolocation
    {
        public double latitude
        {
            get; set;
        }
        public double longitude
        {
            get; set;
        }
    }
    public class Tenure
    {
        public string type
        {
            get; set;
        }
        public DateTime? expiry
        {
            get; set;
        }
    }
    public class Selling
    {
        public string instructed
        {
            get; set;
        }
        public double price
        {
            get; set;
        }
        public string qualifier
        {
            get; set;
        }
        public string status
        {
            get; set;
        }
        public string disposal
        {
            get; set;
        }
        public string completed
        {
            get; set;
        }
        public string exchanged
        {
            get; set;
        }
        public string accountPaid
        {
            get; set;
        }
        public Tenure tenure
        {
            get; set;
        }
        public string vendorId
        {
            get; set;
        }
        public string agency
        {
            get; set;
        }
        public string fee
        {
            get; set;
        }
        public string recommendedPrice
        {
            get; set;
        }
        public string brochureId
        {
            get; set;
        }
        public int exchangedPrice
        {
            get; set;
        }
        public string exchangedOfficeId
        {
            get; set;
        }
    }
    public class self
    {
        public string href
        {
            get; set;
        }
    }
    public class links
    {
        public self self
        {
            get; set;
        }
    }
    public class ExternalArea
    {
        public string type
        {
            get; set;
        }
        public double min
        {
            get; set;
        }
        public double max
        {
            get; set;
        }
    }
    public class ResponseSingle
    {
        public string status
        {
            get; set;
        }
        public Property Property
        {
            get; set;
        }

    }
    public class Response
    {
        public string status
        {
            get; set;
        }
        public List<Property> Property
        {
            get; set;
        }
       
    }

    public class PropertyResponses
    {
        public string status
        {
            get; set;
        }
        public Property Property
        {
            get; set;
        }
    }
    public class Responses
    {
        //public string status
        //{
        //    get; set;
        //}
        public List<PropertyData> _embedded
        {
            get; set;
        }
        public links _links
        {
            get; set;
        }
        public int pageNumber
        {
            get; set;
        }
        public int pageSize
        {
            get; set;
        }
        public int pageCount
        {
            get; set;
        }
        public int totalPageCount
        {
            get; set;
        }
        public int totalCount
        {
            get; set;
        }
    }
    public class JSON
    {
        public Response Response { get; set; }
    }
    public class JSONSigle
    {
        public ResponseSingle Response { get; set; }
    }
    public class PropertyJSON
    {
        public PropertyResponses Response { get; set; }
    }
    public class PropertyDetailJSON
    {
        public PropertyResponses Response { get; set; }
    }

    public class PropertyData
    {
        public string id
        {
            get; set;
        }
        public DateTime? created
        {
            get; set;
        }
        public DateTime? modified
        {
            get; set;
        }
        public string marketingMode
        {
            get; set;
        }
        public string currency
        {
            get; set;
        }
        public string alternateId
        {
            get; set;
        }
        public Address address
        {
            get; set;
        }
        public string areaId
        {
            get; set;
        }
        public string strapline
        {
            get; set;
        }
        public string notes
        {
            get; set;
        }
        public string archivedOn
        {
            get; set;
        }
        public bool fromArchive
        {
            get; set;
        }
        public ExternalArea externalArea
        {
            get; set;
        }
        public Selling selling
        {
            get; set;
        }
        public string video2Caption
        {
            get; set;
        }
        public string video2Url
        {
            get; set;
        }
        public string videoCaption
        {
            get; set;
        }
        public string videoUrl
        {
            get; set;
        }
        public string viewingArrangements
        {
            get; set;
        }
        public bool internetAdvertising
        {
            get; set;
        }
        public string councilTax
        {
            get; set;
        }
        public int bedrooms
        {
            get; set;
        }
        public int receptions
        {
            get; set;
        }
        public int bathrooms
        {
            get; set;
        }
        public string negotiatorId
        {
            get; set;
        }
        public string departmentId
        {
            get; set;
        }
        public string longDescription
        {
            get; set;
        }
        public string description
        {
            get; set;
        }



    }
}