using Coinbase.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coinbase.Currecny
{
    public static class CurrencyExtension
    {
        public static PricePairModel GetBuyPrice(this Client client, String currencyPair)
        {
            var request = new RestRequest("/prices/{currency_pair}/buy");

            request.AddUrlSegment("currency_pair", currencyPair);

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<PricePairModel>>(request);

            return response.Data.Data.First();
        }

        public static BalanceModel GetSellPrice(this Client client, String currencyPair)
        {
            var request = new RestRequest("/prices/{currency_pair}/sell");

            request.AddUrlSegment("currency_pair", currencyPair);

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<BalanceModel>>(request);

            return response.Data.Data.First();
        }

        public static BalanceModel GetSpotPrice(this Client client, String currencyPair)
        {
            var request = new RestRequest("/prices/{currency_pair}/spot");

            request.AddUrlSegment("currency_pair", currencyPair);

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<BalanceModel>>(request);

            return response.Data.Data.First();
        }
    }
}
