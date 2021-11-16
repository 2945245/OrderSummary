using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using OrderSummary.Models;


namespace OrderSummary.Data
{
    public class InfoService :IInfoService
    {
        
        private string infoFile = "item.json";
        private IList<InfoOrder> item;

        public InfoService()
        {
            if (!File.Exists(infoFile))
            {
                WriteInfoOrderToFile();
            }
            else
            {
                string content = File.ReadAllText(infoFile);
                item = JsonSerializer.Deserialize<List<InfoOrder>>(content);
            }
        }

        private void WriteInfoOrderToFile()
        {
            string productsAsJson = JsonSerializer.Serialize(item);

            File.WriteAllText(infoFile, productsAsJson);
        }

        public Task<IList<Summary>> GetSummaryAsync(bool? isCompleted)
        {
            throw new System.NotImplementedException();
        }

        public Task AddInfoOrderAsync(InfoOrder infoOrder)
        {
            item.Add(infoOrder);
            WriteInfoOrderToFile();
            return AddInfoOrderAsync(infoOrder);
        }
        
        public async Task<InfoOrder> UpdateAsync(InfoOrder infoOrder)
        {
            InfoOrder toUpdate = item.FirstOrDefault(infoOrder => infoOrder.Name == infoOrder.Name);
            if (toUpdate == null) throw new Exception($"Did not find customer with id: {infoOrder.Name}");
            toUpdate.IsCompleted = infoOrder.IsCompleted;
            WriteInfoOrderToFile();
            return toUpdate;
        }
    }
}