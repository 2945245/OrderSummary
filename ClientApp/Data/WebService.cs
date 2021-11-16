using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ClientApp.Models;

namespace ClientApp.Data
{
    public class WebService :ISummaryService, IInfoService
    {
        private string uri = "http://localhost:5003";
        private readonly HttpClient client;

        public WebService()
        {
            client = new HttpClient();
        }

        public Task<IList<Summary>> GetSummaryAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task<InfoOrder> AddInfoOrderAsync(InfoOrder infoOrder)
        {
            string infoAsJson = JsonSerializer.Serialize(infoOrder);
            HttpContent content = new StringContent(infoAsJson, Encoding.UTF8, "application.json");
            HttpResponseMessage responseMessage = await client.PostAsync(uri + "Order Information", content);
            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception($"Error, {responseMessage.StatusCode},{responseMessage.ReasonPhrase}");
            return infoOrder;
        }

        public Task<InfoOrder> UpdateAsync(InfoOrder infoOrder)
        {
            throw new System.NotImplementedException();
        }
    }
}