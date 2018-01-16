using Coinbase.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coinbase.Wallet
{
    public static class PaymentExtension
    {
        public static GetResponseModel<PaymentModel> GetPaymentMethods(this Client client)
        {
            var request = new RestRequest("/payment-methods");

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<PaymentModel>>(request);

            return response.Data;
        }

        public static PaymentModel GetPaymentMethod(this Client client, String paymentMethodId)
        {
            var request = new RestRequest("/payment-methods/{payment_method_id}");

            request.AddUrlSegment("payment_method_id", paymentMethodId);

            var rest = client.GetRestClient(request);

            var response = rest.Execute<GetResponseModel<PaymentModel>>(request);

            return response.Data.Data.First();
        }
    }
}
