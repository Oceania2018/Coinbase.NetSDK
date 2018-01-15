using Coinbase.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coinbase.Wallet
{
    public static class AccountExtension
    {
        /// <summary>
        /// Lists current user’s accounts to which the authentication method has access to.
        /// https://developers.coinbase.com/api/v2?python#account-resource
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public static GetResponseModel<AccountModel> GetAccounts(this Client client)
        {
            var request = new RestRequest("/accounts");

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<AccountModel>>(request);

            return response.Data;
        }

        /// <summary>
        /// Show current user’s account.
        /// https://developers.coinbase.com/api/v2?python#show-an-account
        /// </summary>
        /// <param name="client"></param>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public static AccountModel GetAccount(this Client client, String accountId)
        {
            var request = new RestRequest("/accounts/{account_id}");
            
            request.AddUrlSegment("account_id", accountId);

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<AccountModel>>(request);

            return response.Data.Data.First();
        }

        /// <summary>
        /// Promote an account as primary account.
        /// https://developers.coinbase.com/api/v2?python#set-account-as-primary
        /// </summary>
        /// <param name="client"></param>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public static AccountModel SetPrimaryAccount(this Client client, String accountId)
        {
            var request = new RestRequest("/accounts/{account_id}/primary");
            request.Method = Method.POST;
            request.AddUrlSegment("account_id", accountId);

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<AccountModel>>(request);

            return response.Data.Data.First();
        }

        public static AccountModel GetPrimaryAccount(this Client client)
        {
            return client.GetAccounts().Data.First(x => x.Primary);
        }
    }
}
