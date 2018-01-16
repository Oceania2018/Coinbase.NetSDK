using Coinbase.Models;
using RestSharp;
using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Coinbase
{
    /// <summary>
    /// Client Implementation of Coinbase API
    /// https://developers.coinbase.com/api/v2
    /// </summary>
    public class Client
    {
        private ClientOptionModel Options { get; set; }

        public Client(String apiKey, String apiSecret, String apiVersion = "2017-08-07")
        {
            Options = new ClientOptionModel
            {
                BaseUrl = "https://api.coinbase.com/v2",
                ApiKey = apiKey,
                ApiSecret = apiSecret,
                ApiVersion = apiVersion
            };
        }

        public IRestClient GetRestClient(IRestRequest request)
        {
            var client = new RestClient(Options.BaseUrl);

            // Set header
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            string timestamp = Convert.ToInt64((DateTime.UtcNow - epoch).TotalSeconds).ToString();

            string method = request.Method.ToString().ToUpper(CultureInfo.InvariantCulture);
            var uri = client.BuildUri(request);
            string path = request.Method == Method.GET ? uri.PathAndQuery : uri.AbsolutePath;

            var body = string.Empty;
            if (request.Method != Method.GET)
            {
                var param = request.Parameters.FirstOrDefault(p => p.Type == ParameterType.RequestBody);
                if (param != null && param?.Value?.ToString() != "null" && !string.IsNullOrWhiteSpace(param?.Value?.ToString()))
                {
                    body = param.Value.ToString();
                }
            }

            var hmacSig = GetHMACInHex(Options.ApiSecret, timestamp + method + path + body);

            request.AddHeader("CB-ACCESS-KEY", Options.ApiKey)
               .AddHeader("CB-ACCESS-SIGN", hmacSig)
               .AddHeader("CB-ACCESS-TIMESTAMP", timestamp)
               .AddHeader("CB-VERSION", Options.ApiVersion)
               .AddHeader("Content-type", "application/json");

            return client;
        }

        private string GetHMACInHex(string key, string data)
        {
            var hmacKey = Encoding.UTF8.GetBytes(key);

            using (var signatureStream = new MemoryStream(Encoding.UTF8.GetBytes(data)))
            {
                var hex = new HMACSHA256(hmacKey).ComputeHash(signatureStream)
                   .Aggregate(new StringBuilder(), (sb, b) => sb.AppendFormat("{0:x2}", b), sb => sb.ToString());

                return hex;
            }
        }
    }
}
