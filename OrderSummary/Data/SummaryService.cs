using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using OrderSummary.Controllers;
using OrderSummary.Models;

namespace OrderSummary.Data
{
    public class SummaryService : ISummaryService
    {
        private string summaryFile = "orderInfo.json";
        private IList<Summary> orderInfo;



        public SummaryService()
        {
            if (!File.Exists(summaryFile))
            {

                WriteSummaryToFile();
            }
            else
            {
                string content = File.ReadAllText(summaryFile);
                orderInfo = JsonSerializer.Deserialize<List<Summary>>(content);
            }
        }



        public async Task<IList<Summary>> GetSummaryAsync()
        {
            List<Summary> tmp = new List<Summary>(orderInfo);
            return tmp;
        }

        private void WriteSummaryToFile()
        {
            string productsAsJson = JsonSerializer.Serialize(orderInfo);

            File.WriteAllText(summaryFile, productsAsJson);




        }
    
    }
}