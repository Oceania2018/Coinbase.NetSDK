using Coinbase.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coinbase.Wallet
{
    public static class AddressExtension
    {
        /// <summary>
        /// Lists addresses for an account.
        /// https://developers.coinbase.com/api/v2?python#list-addresses
        /// </summary>
        /// <param name="client"></param>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public static GetResponseModel<CurrencyAddressModel> GetAddresses(this Client client, string accountId)
        {
            var request = new RestRequest("/accounts/{account_id}/addresses");
            request.AddUrlSegment("account_id", accountId);

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<CurrencyAddressModel>>(request);

            return response.Data;
        }

        /// <summary>
        /// Show an individual address for an account.
        /// https://developers.coinbase.com/api/v2?python#show-addresss
        /// </summary>
        /// <param name="client"></param>
        /// <param name="accountId"></param>
        /// <param name="addressId"></param>
        /// <returns></returns>
        public static CurrencyAddressModel GetAddress(this Client client, String accountId, String addressId)
        {
            var request = new RestRequest("/accounts/{account_id}/addresses/{address_id}");

            request.AddUrlSegment("account_id", accountId);
            request.AddUrlSegment("address_id", addressId);

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<CurrencyAddressModel>>(request);

            return response.Data.Data.First();
        }

        /// <summary>
        /// Creates a new address for an account.
        /// https://developers.coinbase.com/api/v2?python#create-address
        /// </summary>
        /// <param name="client"></param>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public static CurrencyAddressModel CreateAddress(this Client client, String accountId)
        {
            var request = new RestRequest("/accounts/{account_id}/addresses");
            request.Method = Method.POST;
            request.AddUrlSegment("account_id", accountId);

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<CurrencyAddressModel>>(request);

            return response.Data.Data.First();
        }
    }
}
