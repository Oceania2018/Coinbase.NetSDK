using Coinbase.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coinbase.Merchant
{
    public static class MerchantExtension
    {
        public static LocationModel GetMerchant(this Client client, String merchantId)
        {
            var request = new RestRequest("/merchants/:merchant_id");

            request.AddUrlSegment("account_id", merchantId);

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<LocationModel>>(request);

            return response.Data.Data.First();
        }
    }
}
