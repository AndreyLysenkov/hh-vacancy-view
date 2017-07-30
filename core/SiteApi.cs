using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Vacancy.Core.Model;

namespace Vacancy.Core
{
    public class SiteApi
    {

        private HttpClient client;

        public SiteApi()
        {
            this.client = new HttpClient();
            this.client.BaseAddress = new Uri("https://api.hh.ru/");
            this.client.DefaultRequestHeaders.UserAgent.ParseAdd("HH-Vacancy-View/1.0 (allan_walpy)");
        }

        public async Task<string> RequestAsync(string uri)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            response = await this.client.GetAsync(uri);
            return await response.Content.ReadAsStringAsync();
        }

        public string Request(string uri)
        {
            Task<string> response = this.RequestAsync(uri);
            response.Wait();
            return response.Result;
        }

        public string Request(string path, params Tuple<string, string>[] parametr)
        {
            return this.Request($"/{path}?{string.Join("&", parametr.ToList().ConvertAll<string>((param) => $"{param.Item1}={param.Item2}"))}");
        }

        public SearchParse SearchVacancy(params Tuple<string, string>[] param)
        {
            string request = this.Request("vacancies", param);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SearchParse>(request);
        }

    }

}
