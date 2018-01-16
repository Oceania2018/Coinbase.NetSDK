using Newtonsoft.Json.Linq;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.Models
{
    public class OrderingModel : BalanceModel
    {
        public String Name { get; set; }

        /// <summary>
        /// More detailed description of the order
        /// </summary>
        public String Description { get; set; }

        [DeserializeAs(Name = "notifications_url")]
        public String NotificationsUrl { get; set; }

        /// <summary>
        /// Developer defined key value pairs. 
        /// </summary>
        public JObject Metadata { get; set; }
    }
}
