using System.Threading.Tasks;
using ClientApp.Models;

namespace ClientApp.Data
{
    public interface IInfoService
    {
        Task<InfoOrder> AddInfoOrderAsync(InfoOrder infoOrder);
        Task<InfoOrder> UpdateAsync(InfoOrder infoOrder);
    }
}