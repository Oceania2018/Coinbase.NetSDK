using Coinbase.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coinbase.Wallet
{
    public static class TradeExtension
    {
        public static GetResponseModel<BuyModel> GetBuys(this Client client, String accountId)
        {
            var request = new RestRequest("/accounts/{account_id}/buys");
            request.AddUrlSegment("account_id", accountId);

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<BuyModel>>(request);

            return response.Data;
        }
    }
}
