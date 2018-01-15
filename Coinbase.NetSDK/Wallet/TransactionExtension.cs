using Coinbase.Models;
using Coinbase.Models.Transaction;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coinbase.Wallet
{
    public static class TransactionExtension
    {
        /// <summary>
        /// Lists account’s transactions.
        /// https://developers.coinbase.com/api/v2?python#list-transactions
        /// </summary>
        /// <param name="client"></param>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public static GetResponseModel<TransactionModel> GetTransactions(this Client client, String accountId)
        {
            var request = new RestRequest("/accounts/{account_id}/transactions");
            request.AddUrlSegment("account_id", accountId);

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<TransactionModel>>(request);

            return response.Data;
        }

        /// <summary>
        /// Show an individual transaction for an account.
        /// https://developers.coinbase.com/api/v2?python#show-a-transaction
        /// </summary>
        /// <param name="client"></param>
        /// <param name="accountId"></param>
        /// <param name="transactionId"></param>
        /// <returns></returns>
        public static TransactionModel GetTransaction(this Client client, String accountId, String transactionId)
        {
            var request = new RestRequest("/accounts/{account_id}/transactions/{transaction_id}");

            request.AddUrlSegment("account_id", accountId);
            request.AddUrlSegment("transaction_id", transactionId);

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<TransactionModel>>(request);

            return response.Data.Data.First();
        }

        /// <summary>
        /// Send funds to a bitcoin address, bitcoin cash address, litecoin address, ethereum address, or email address.
        /// https://developers.coinbase.com/api/v2?python#send-money
        /// </summary>
        /// <param name="client"></param>
        /// <param name="to"></param>
        /// <param name="amount"></param>
        /// <param name="currency"></param>
        /// <param name="idem"></param>
        public static TransactionModel SendMoney(this Client client, String accountId, TransactionSendModel send)
        {
            var request = new RestRequest("/accounts/{account_id}/transactions");
            request.AddUrlSegment("account_id", accountId);
            request.Method = Method.POST;
            request.AddJsonBody2(send);

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<TransactionModel>>(request);

            if (!response.IsSuccessful)
            {
                var error = JsonConvert.DeserializeObject<ResponseErrorModel>(response.Content);
                throw new Exception(error.Errors.First().Message);
            }

            return response.Data.Data.First();
        }

        /// <summary>
        /// Requests money from an email address.
        /// https://developers.coinbase.com/api/v2?python#request-money
        /// </summary>
        /// <param name="client"></param>
        /// <param name="accountId"></param>
        /// <param name="req"></param>
        /// <returns></returns>
        public static TransactionModel RequestMoney(this Client client, String accountId, TransactionRequestModel req)
        {
            var request = new RestRequest("/accounts/{account_id}/transactions");
            request.AddUrlSegment("account_id", accountId);
            request.Method = Method.POST;
            request.AddJsonBody2(req);

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<TransactionModel>>(request);

            if (!response.IsSuccessful)
            {
                var error = JsonConvert.DeserializeObject<ResponseErrorModel>(response.Content);
                throw new Exception(error.Errors.First().Message);
            }

            return response.Data.Data.First();
        }

        /// <summary>
        /// Transfer bitcoin, bitcoin cash, litecoin or ethereum between two of a user’s accounts.
        /// https://developers.coinbase.com/api/v2?python#transfer-money-between-accounts
        /// </summary>
        /// <param name="client"></param>
        /// <param name="accountId"></param>
        /// <param name="transfer"></param>
        /// <returns></returns>
        public static TransactionModel TransferMoney(this Client client, String accountId, TransactionTransferModel transfer)
        {
            var request = new RestRequest("/accounts/{account_id}/transactions");
            request.AddUrlSegment("account_id", accountId);
            request.Method = Method.POST;
            request.AddJsonBody2(transfer);

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<TransactionModel>>(request);

            if (!response.IsSuccessful)
            {
                var error = JsonConvert.DeserializeObject<ResponseErrorModel>(response.Content);
                throw new Exception(error.Errors.First().Message);
            }

            return response.Data.Data.First();
        }

        /// <summary>
        /// Lets the recipient of a money request complete the request by sending money to the user who requested the money.
        /// https://developers.coinbase.com/api/v2?python#complete-request-money
        /// </summary>
        /// <param name="client"></param>
        /// <param name="accountId"></param>
        /// <param name="transactionId"></param>
        /// <returns></returns>
        public static TransactionModel CompleteRequest(this Client client, String accountId, String transactionId)
        {
            var request = new RestRequest("/accounts/{account_id}/transactions/{transaction_id}/complete");
            request.AddUrlSegment("account_id", accountId);
            request.AddUrlSegment("transaction_id", transactionId);
            request.Method = Method.POST;

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<TransactionModel>>(request);

            if (!response.IsSuccessful)
            {
                var error = JsonConvert.DeserializeObject<ResponseErrorModel>(response.Content);
                throw new Exception(error.Errors.First().Message);
            }

            return response.Data.Data.First();
        }

        /// <summary>
        /// Lets a user cancel a money request.
        /// https://developers.coinbase.com/api/v2?python#cancel-request-money
        /// </summary>
        /// <param name="client"></param>
        /// <param name="accountId"></param>
        /// <param name="transactionId"></param>
        /// <returns></returns>
        public static TransactionModel CancelRequest(this Client client, String accountId, String transactionId)
        {
            var request = new RestRequest("/accounts/{account_id}/transactions/{transaction_id}");
            request.AddUrlSegment("account_id", accountId);
            request.AddUrlSegment("transaction_id", transactionId);
            request.Method = Method.DELETE;

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<TransactionModel>>(request);

            if (!response.IsSuccessful)
            {
                var error = JsonConvert.DeserializeObject<ResponseErrorModel>(response.Content);
                throw new Exception(error.Errors.First().Message);
            }

            return response.Data.Data.First();
        }

        /// <summary>
        /// Lets the user resend a money request.
        /// https://developers.coinbase.com/api/v2?python#re-send-request-money
        /// </summary>
        /// <param name="client"></param>
        /// <param name="accountId"></param>
        /// <param name="transactionId"></param>
        /// <returns></returns>
        public static TransactionModel ResendRequest(this Client client, String accountId, String transactionId)
        {
            var request = new RestRequest("/accounts/{account_id}/transactions/{transaction_id}/resend");
            request.AddUrlSegment("account_id", accountId);
            request.AddUrlSegment("transaction_id", transactionId);
            request.Method = Method.POST;

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<TransactionModel>>(request);

            if (!response.IsSuccessful)
            {
                var error = JsonConvert.DeserializeObject<ResponseErrorModel>(response.Content);
                throw new Exception(error.Errors.First().Message);
            }

            return response.Data.Data.First();
        }
    }
}
