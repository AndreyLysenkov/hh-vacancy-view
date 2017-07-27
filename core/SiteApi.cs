using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Vacancy.Core.Parse;

namespace Vacancy.Core
{
    public class SiteApi
    {
        
        private HttpClient client;

        private Dictionary<string, string> experienceValue;

        public SiteApi()
        {
            this.Activate();
        }

        private void Activate_HttpClient()
        {
            this.client = new HttpClient();
            this.client.BaseAddress = new Uri("https://api.hh.ru/");
            this.client.DefaultRequestHeaders.UserAgent.ParseAdd("HH-Vacancy-View/1.0 (allan_walpy)");
        }

        private void Activate_ExperienceValue()
        {
            string api = this.Request("/dictionaries");
            JObject apiJson = JObject.Parse(api);
            List<JToken> list = apiJson["experience"].Children().ToList();
            this.experienceValue = new Dictionary<string, string>();
            foreach (var element in list)
            {
                this.experienceValue.Add(element["id"].ToString(), element["name"].ToString());
            }
        }

        public void Activate()
        {
            Activate_HttpClient();
            Activate_ExperienceValue();

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
