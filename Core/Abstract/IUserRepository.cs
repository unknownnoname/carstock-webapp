using System.Threading.Tasks;
using car_heap.Core.Models;

namespace car_heap.Core.Abstract
{
    public interface IUserRepository
    {
         Task<ApplicationUser> GetCurrentUser();
    }
}