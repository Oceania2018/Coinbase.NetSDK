using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.Models
{
    /// <summary>
    /// Error response
    /// https://developers.coinbase.com/api/v2?python#error-response
    /// </summary>
    public class ErrorModel
    {
        public String Id { get; set; }

        public String Message { get; set; }

        public String Url { get; set; }
    }

    public class ResponseErrorModel
    {
        public List<ErrorModel> Errors { get; set; }
    }
}
