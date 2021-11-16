using System.Collections.Generic;
using System.Threading.Tasks;
using OrderSummary.Models;


namespace OrderSummary.Data
{
    public interface IInfoService
    {
        Task<IList<Summary>> GetSummaryAsync(bool? isCompleted);
        Task AddInfoOrderAsync(InfoOrder infoOrder);
    }
}