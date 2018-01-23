using Coinbase.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coinbase.Notification
{
    public static class NotificationExtension
    {
        /// <summary>
        /// Lists notifications where the current user was the subscriber (owner of the API key or OAuth application).
        /// https://developers.coinbase.com/api/v2?python#list-notifications
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public static GetResponseModel<NotificationModel> GetNotifications(this Client client)
        {
            var request = new RestRequest("/notifications");

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<NotificationModel>>(request);

            return response.Data;
        }

        /// <summary>
        /// Show a notification for which the current user was a subsciber.
        /// https://developers.coinbase.com/api/v2?python#show-a-notification
        /// </summary>
        /// <param name="client"></param>
        /// <param name="notificationsId"></param>
        /// <returns></returns>
        public static NotificationModel GetNotification(this Client client, String notificationsId)
        {
            var request = new RestRequest("/notifications/{notifications_id}");

            request.AddUrlSegment("notifications_id", notificationsId);

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<NotificationModel>>(request);

            return response.Data.Data.First();
        }
    }
}
