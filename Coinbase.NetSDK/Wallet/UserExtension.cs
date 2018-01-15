using Coinbase.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coinbase.Wallet
{
    public static class UserExtension
    {
        /// <summary>
        /// Get any user’s public information with their ID.
        /// https://developers.coinbase.com/api/v2?python#show-current-user
        /// </summary>
        /// <param name="client"></param>
        public static UserModel GetCurrentUser(this Client client)
        {
            var request = new RestRequest("/user");

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<UserModel>>(request);

            return response.Data.Data.First();
        }

        /// <summary>
        /// Get any user’s public information with their ID.
        /// https://developers.coinbase.com/api/v2?python#show-a-user
        /// </summary>
        /// <param name="client"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static UserModel GetUser(this Client client, String userId)
        {
            var request = new RestRequest("/users/{user_id}");

            request.AddUrlSegment("user_id", userId);

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<UserModel>>(request);

            return response.Data.Data.First();
        }
    }
}
