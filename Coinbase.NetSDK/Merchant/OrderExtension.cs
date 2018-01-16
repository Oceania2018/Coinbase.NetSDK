using Coinbase.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coinbase.Merchant
{
    public static class OrderExtension
    {
        /// <summary>
        /// Lists the current user’s (merchant) orders.
        /// https://developers.coinbase.com/api/v2?python#list-orders
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public static GetResponseModel<OrderModel> GetOrders(this Client client)
        {
            var request = new RestRequest("/orders");

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<OrderModel>>(request);

            return response.Data;
        }

        /// <summary>
        /// Show current user’s merchant order.
        /// https://developers.coinbase.com/api/v2?python#show-an-order
        /// </summary>
        /// <param name="client"></param>
        /// <param name="accountId"></param>
        /// <returns></returns>
        public static AccountModel GetOrder(this Client client, String orderId)
        {
            var request = new RestRequest("/orders/{order_id}");

            request.AddUrlSegment("order_id", orderId);

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<AccountModel>>(request);

            return response.Data.Data.First();
        }

        /// <summary>
        /// Creates a new merchant order.
        /// https://developers.coinbase.com/api/v2#create-an-order
        /// </summary>
        /// <param name="client"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        public static OrderModel CreateOrder(this Client client, OrderingModel order)
        {
            var request = new RestRequest("/orders");
            request.Method = Method.POST;
            request.AddJsonBody2(order);

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<OrderModel>>(request);

            return response.Data.Data.First();
        }

        public static OrderModel RefundOrder(this Client client, String orderId)
        {
            var request = new RestRequest("/orders/{order_id}/refund");
            request.Method = Method.POST;
            request.AddUrlSegment("order_id", orderId);

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<OrderModel>>(request);

            return response.Data.Data.First();
        }
    }
}
