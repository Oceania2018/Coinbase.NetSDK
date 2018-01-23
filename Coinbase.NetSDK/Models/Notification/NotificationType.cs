using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.Models
{
    public class NotificationType
    {
        /// <summary>
        /// Ping notification can be send at any time to verify that the notification URL is functioning
        /// </summary>
        public const String PING = "ping";
        /// <summary>
        /// New payment has been made
        /// </summary>
        public const String WALLETADDRESSESNEWPAYMENT = "wallet:addresses:new-payment";

        /// <summary>
        /// A buy has been created
        /// </summary>
        public const String WALLETBUYSCREATED = "wallet:buys:created";

        /// <summary>
        /// A buy has been completed
        /// </summary>
        public const String WALLETBUYSCOMPLETED = "wallet:buys:completed";
    }
}
