using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class APIRequestBuilder
    {
        private string resultUrl = "";
        public APIRequestBuilder(string domain, string key, string secret)
        {
            resultUrl += $"https://{domain}?key{key}&secret{secret}";
        }
        public APIRequestBuilder SetAddress(string address)
        {
            resultUrl += $"&address{address}";
            return this;
        }
        public APIRequestBuilder SetCity(string city)
        {
            resultUrl += $"&city{city}";
            return this;
        }
        public string GetUrl()
        {
            return resultUrl;
        }
    }
}
