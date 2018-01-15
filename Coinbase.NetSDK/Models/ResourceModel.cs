using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.Models
{
    public abstract class IdResourceModel
    {
        /// <summary>
        /// Resource ID
        /// </summary>
        public String Id { get; set; }

        public String Resource { get; set; }

        [DeserializeAs(Name = "resource_path")]
        public String ResourcePath { get; set; }
    }

    public abstract class ResourceModel : IdResourceModel
    {
        [DeserializeAs(Name = "created_at")]
        public DateTime CreatedAt { get; set; }

        [DeserializeAs(Name = "updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
