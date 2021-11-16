using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ClientApp.Models;
using Microsoft.AspNetCore.Http.Features;

namespace ClientApp.Data
{
    public class InfoService : IInfoService
    {
        private static string infoFile = "item.json";
        private static IList<InfoOrder> item;

        public InfoService()
        {
            if (File.Exists(infoFile))
            {
                WriteInfoOrderToFile();
            }
            else
            {
                string content = WebRequestMethods.File.ReadAllText(infoFile);
                item = JsonSerializer.Deserialize<List<InfoOrder>>(content);
            }
        }

        public static Task AddInfoOrderAsync(InfoOrder infoOrder)
        {
            item.Add(infoOrder);
            WriteInfoOrderToFile();
            return AddInfoOrderAsync(infoOrder);
        }

        Task<InfoOrder> IInfoService.AddInfoOrderAsync(InfoOrder infoOrder)
        {
            throw new NotImplementedException();
        }

        public async Task<InfoOrder> UpdateAsync(InfoOrder infoOrder)
        {
            InfoOrder toUpdate = item.FirstOrDefault(infoOrder => infoOrder.Name == infoOrder.Name);
            if (toUpdate == null) throw new Exception($"Did not find customer with id: {infoOrder.Name}");
            toUpdate.IsCompleted = infoOrder.IsCompleted;
            WriteInfoOrderToFile();
            return toUpdate;
        
        }

        private static void WriteInfoOrderToFile()
        {
            string productAsJson = JsonSerializer.Serialize(item);
            WebRequestMethods.File.WriteAllText(infoFile, productAsJson);
        }

        public async Task AddSummary(Summary summary, string uri)
        {
            HttpClient client = new HttpClient();
            string summaryAsJson = JsonSerializer.Serialize(summary);
            HttpContent content = new StringContent(
                summaryAsJson,
                Encoding.UTF8,
                "application/json");
            await client.PostAsync(uri + "/todos", content);
        }
    }
}