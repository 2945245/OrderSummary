using System.Collections.Generic;
using System.Threading.Tasks;
using OrderSummary.Controllers;
using OrderSummary.Models;

namespace OrderSummary.Data
{
    public class ISummaryService
    {
        public Task<IList<Summary>> GetSummaryAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}