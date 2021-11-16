using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using ClientApp.Models;

namespace ClientApp.Data
{
    public class SummaryService : ISummaryService
    {
        private string summaryFile = "orderInfo.json";
        private static IList<Summary> orderInfo;

        public SummaryService()
        {
            if (!File.Exists(summaryFile))
            {
                WriteSummaryToFile();
            }
            else
            {
                string content = WebRequestMethods.File.ReadAllText(summaryFile);
                orderInfo = JsonSerializer.Deserialize<List<Summary>>(content);
            }
        }

        public static async Task<IList<Summary>> GetSummaryAsync()
        {
            List<Summary> tmp = new List<Summary>(orderInfo);
            return tmp;
        }

        private void WriteSummaryToFile()
        {
            string productAsJson = JsonSerializer.Serialize(orderInfo);
            WebRequestMethods.File.WriteAllText(summaryFile, productAsJson);
        }

        Task<IList<Summary>> ISummaryService.GetSummaryAsync()
        {
            return GetSummaryAsync();
        }
        
        
    }
}