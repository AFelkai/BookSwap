using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;

namespace BookSwap
{
    public static class ISBNRequest
    {
        public static Book GetRequest(string ISBN)
        {
            string content = "";
            const string WEBSERVICE_URL = "https://api.isbndb.com/book/";

            try
            {
                var webRequest = WebRequest.Create(WEBSERVICE_URL + ISBN);

                if (webRequest != null)
                {
                    webRequest.Method = "GET";
                    webRequest.ContentType = "application/json";
                    webRequest.Headers["X-API-Key"] = "5nhEtpxUXnDpLdNk1sp374pvgBsVMXwYhkpRsB10";

                    WebResponse wr = webRequest.GetResponseAsync().Result;
                    Stream receiveStream = wr.GetResponseStream();
                    StreamReader reader = new StreamReader(receiveStream);

                    content = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);

            }
            return JsonConvert.DeserializeObject<BookWrapper>(content).book;
        }
    }
}
