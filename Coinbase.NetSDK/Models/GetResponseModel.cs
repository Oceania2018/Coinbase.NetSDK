using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coinbase.Models
{
    /// <summary>
    /// All GET endpoints which return an object list support cursor based pagination 
    /// with pagination information inside a pagination object.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GetResponseModel<T>
    {
        public PaginationModel Pagination { get; set; }

        public IEnumerable<T> Data { get; set; }
    }
}
