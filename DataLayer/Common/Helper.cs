using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Common
{
    public class Helper
    {
        static HttpClient client;
        private static string BaseURL;
        static Helper()
        {
            client = new HttpClient
            {
                MaxResponseContentBufferSize = 999999999
            };
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic");
        }

        public static async Task<string> Post(string Url, string Json)
        {
            string data = string.Empty;
            var uri = new Uri(string.Format(Url, string.Empty));

            try
            {
                var content = new StringContent(Json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;
                response = await client.PostAsync(uri, content);

                if (response.IsSuccessStatusCode)
                    data = await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
            return data;
        }

        #region ExecutePostCall

        public static async Task<T> ExecutePostCall<T, R>(R request, string url)
        {
            T response = default(T);
            try
            {
                string content = string.Empty;

                if (request != null)
                    content = JsonConvert.SerializeObject(request);

                content = await Post(url, content);

                if (!string.IsNullOrEmpty(content))
                    response = JsonConvert.DeserializeObject<T>(content);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }

            return response;
        }

        #endregion

    }
}
