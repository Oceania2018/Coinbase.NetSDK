using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.Models
{
    /// <summary>
    /// Generic user information. 
    /// By default, only public information is shared without any scopes. 
    /// More detailed information or email can be requested with additional scopes.
    /// https://developers.coinbase.com/api/v2?python#user-resource
    /// </summary>
    public class UserModel
    {
        public String Id { get; set; }

        /// <summary>
        /// User’s public name
        /// </summary>
        public String Name { get; set; }

        public String UserName { get; set; }

        /// <summary>
        /// Location for user’s public profile
        /// </summary>
        [DeserializeAs(Name = "profile_location")]
        public String ProfileLocation { get; set; }

        /// <summary>
        /// Bio for user’s public profile
        /// </summary>
        [DeserializeAs(Name = "profile_bio")]
        public String ProfileBio { get; set; }

        /// <summary>
        /// Public profile location if user has one
        /// </summary>
        [DeserializeAs(Name = "profile_url")]
        public String ProfileUrl { get; set; }

        /// <summary>
        /// User’s avatar url
        /// </summary>
        [DeserializeAs(Name = "avatar_url")]
        public String AvatarUrl { get; set; }

        public String Resource { get; set; }

        public String ResourcePath { get; set; }
    }
}
