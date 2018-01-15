using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase
{
    public static class Utility
    {
        public static void AddJsonBody2(this RestRequest request, Object body)
        {
            string json = JsonConvert.SerializeObject(body,
                new JsonSerializerSettings
                {
                    Converters = new List<JsonConverter> { new StringEnumConverter() },
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                });

            request.AddParameter("application/json", json, ParameterType.RequestBody);
        }
    }
}
