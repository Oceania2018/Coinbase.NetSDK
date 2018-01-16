using Coinbase.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coinbase.Wallet
{
    public static class TradeExtension
    {
        /// <summary>
        /// Lists buys for an account.
        /// https://developers.coinbase.com/api/v2?python#list-buys
        /// </summary>
        /// <param name="client"></param>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public static GetResponseModel<BuyModel> GetBuys(this Client client, String accountId)
        {
            var request = new RestRequest("/accounts/{account_id}/buys");
            request.AddUrlSegment("account_id", accountId);

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<BuyModel>>(request);

            return response.Data;
        }

        /// <summary>
        /// Show an individual buy.
        /// https://developers.coinbase.com/api/v2?python#show-a-buy
        /// </summary>
        /// <param name="client"></param>
        /// <param name="accountId"></param>
        /// <param name="transactionId"></param>
        /// <returns></returns>
        public static BuyModel GetBuy(this Client client, String accountId, String buyId)
        {
            var request = new RestRequest("/accounts/{account_id}/buys/{buy_id}");

            request.AddUrlSegment("account_id", accountId);
            request.AddUrlSegment("buy_id", buyId);

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<BuyModel>>(request);

            return response.Data.Data.First();
        }

        /// <summary>
        /// Buys a user-defined amount of bitcoin, bitcoin cash, litecoin or ethereum.
        /// https://developers.coinbase.com/api/v2?python#place-buy-order
        /// </summary>
        /// <param name="client"></param>
        /// <param name="accountId"></param>
        /// <param name="buying"></param>
        /// <returns></returns>
        public static BuyModel Buy(this Client client, String accountId, BuyingModel buying)
        {
            var request = new RestRequest("/accounts/{account_id}/buys");
            request.AddUrlSegment("account_id", accountId);
            request.Method = Method.POST;
            request.AddJsonBody2(buying);

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<BuyModel>>(request);

            if (!response.IsSuccessful)
            {
                var error = JsonConvert.DeserializeObject<ResponseErrorModel>(response.Content);
                throw new Exception(error.Errors.First().Message);
            }

            return response.Data.Data.First();
        }

        public static BuyModel CommitBuy(this Client client, String accountId, String buyId)
        {
            var request = new RestRequest("/accounts/{account_id}/buys/{buy_id}/commit");
            request.AddUrlSegment("account_id", accountId);
            request.AddUrlSegment("buy_id", buyId);
            request.Method = Method.POST;

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<BuyModel>>(request);

            if (!response.IsSuccessful)
            {
                var error = JsonConvert.DeserializeObject<ResponseErrorModel>(response.Content);
                throw new Exception(error.Errors.First().Message);
            }

            return response.Data.Data.First();
        }

        /// <summary>
        /// Lists sells for an account.
        /// https://developers.coinbase.com/api/v2?python#list-sells
        /// </summary>
        /// <param name="client"></param>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public static GetResponseModel<SellModel> GetSells(this Client client, String accountId)
        {
            var request = new RestRequest("/accounts/{account_id}/sells");
            request.AddUrlSegment("account_id", accountId);

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<SellModel>>(request);

            return response.Data;
        }

        /// <summary>
        /// Show an individual sell.
        /// https://developers.coinbase.com/api/v2?python#show-a-sell
        /// </summary>
        /// <param name="client"></param>
        /// <param name="accountId"></param>
        /// <param name="sellId"></param>
        /// <returns></returns>
        public static SellModel GetSell(this Client client, String accountId, String sellId)
        {
            var request = new RestRequest("/accounts/{account_id}/sells/{sell_id}");
            request.AddUrlSegment("account_id", accountId);
            request.AddUrlSegment("sell_id", sellId);

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<SellModel>>(request);

            return response.Data.Data.First();
        }

        /// <summary>
        /// Sells a user-defined amount of bitcoin, bitcoin cash, litecoin or ethereum.
        /// https://developers.coinbase.com/api/v2?python#sell-resource
        /// </summary>
        /// <param name="client"></param>
        /// <param name="accountId"></param>
        /// <param name="sell"></param>
        /// <returns></returns>
        public static SellModel Sell(this Client client, String accountId, SellingModel sell)
        {
            var request = new RestRequest("/accounts/{account_id}/sells");
            request.AddUrlSegment("account_id", accountId);
            request.Method = Method.POST;
            request.AddJsonBody2(sell);

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<SellModel>>(request);

            if (!response.IsSuccessful)
            {
                var error = JsonConvert.DeserializeObject<ResponseErrorModel>(response.Content);
                throw new Exception(error.Errors.First().Message);
            }

            return response.Data.Data.First();
        }

        public static SellModel CommitSell(this Client client, String accountId, String sellId)
        {
            var request = new RestRequest("/accounts/{account_id}/sells/{sell_id}/commit");
            request.AddUrlSegment("account_id", accountId);
            request.AddUrlSegment("sell_id", sellId);
            request.Method = Method.POST;

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<SellModel>>(request);

            if (!response.IsSuccessful)
            {
                var error = JsonConvert.DeserializeObject<ResponseErrorModel>(response.Content);
                throw new Exception(error.Errors.First().Message);
            }

            return response.Data.Data.First();
        }
    }
}
