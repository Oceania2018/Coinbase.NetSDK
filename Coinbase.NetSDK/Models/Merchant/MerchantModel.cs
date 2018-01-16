using Coinbase.Models;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.Models
{
    /// <summary>
    /// https://developers.coinbase.com/api/v2?python#merchant-resource
    /// </summary>
    public class MerchantModel : ResourceModel
    {
        /// <summary>
        /// Merchant’s name
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Merchant’s website
        /// </summary>
        [DeserializeAs(Name = "website_url")]
        public String WebsiteUrl { get; set; }

        /// <summary>
        /// Merchant’s physical location
        /// </summary>
        public CurrencyAddressModel Address { get; set; }

        /// <summary>
        /// Merchant’s avatar url
        /// </summary>
        [DeserializeAs(Name = "avatar_url")]
        public String AvatarUrl { get; set; }

        /// <summary>
        /// Merchant’s logo url
        /// </summary>
        [DeserializeAs(Name = "logo_url")]
        public String LogoUrl { get; set; }

        /// <summary>
        /// Merchant’s cover image url
        /// </summary>
        [DeserializeAs(Name = "cover_image_url")]
        public String CoverImageUrl { get; set; }
    }
}
