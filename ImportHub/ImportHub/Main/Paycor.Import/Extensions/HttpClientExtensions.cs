﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
//TODO: No unit tests
namespace Paycor.Import.Extensions
{
    public static class HttpClientExtensions
    {
        public static Task<HttpResponseMessage> PatchAsync(this HttpClient client, string requestUri, HttpContent content)
        {
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = new HttpMethod("PATCH"),
                RequestUri = new Uri(requestUri),
                Content = content,
            };
            return client.SendAsync(request);
        }
    }
}