using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.Models
{
    /// <summary>
    /// https://developers.coinbase.com/api/v2?python#pagination
    /// </summary>
    public class PaginationModel
    {
        /// <summary>
        /// A cursor for use in pagination. starting_after is an resource ID that 
        /// </summary>
        [DeserializeAs(Name = "starting_after")]
        public String StartingAfter { get; set; }

        /// <summary>
        /// A cursor for use in pagination. ending_before is an resource ID that 
        /// </summary>
        [DeserializeAs(Name = "ending_before")]
        public String EndingBefore { get; set; }

        /// <summary>
        /// Number of results per call. 
        /// Accepted values: 0 - 100. Default 25
        /// </summary>
        public int Limit { get; set; } = 25;

        /// <summary>
        /// Result order. 
        /// Accepted values: desc (default), asc
        /// </summary>
        public String Order { get; set; }

        [DeserializeAs(Name = "previous_uri")]
        public String PreviousUri { get; set; }

        [DeserializeAs(Name = "next_uri")]
        public String NextUri { get; set; }
    }
}
