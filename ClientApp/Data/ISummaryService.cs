using System.Collections.Generic;
using System.Threading.Tasks;
using ClientApp.Models;

namespace ClientApp.Data
{
    public interface ISummaryService
    {
        Task<IList<Summary>> GetSummaryAsync();
    }
}