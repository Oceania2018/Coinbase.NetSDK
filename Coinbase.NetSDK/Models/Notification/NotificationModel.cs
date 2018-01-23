using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.Models
{
    public class NotificationModel : ResourceModel
    {
        /// <summary>
        /// Refer NotificationType
        /// </summary>
        public String Type { get; set; }

        public NotificationData Data { get; set; }
    }
}
