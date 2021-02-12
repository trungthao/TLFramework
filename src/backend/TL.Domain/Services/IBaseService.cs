using System.Threading.Tasks;
using TL.Domain.Entities;
using TL.Domain.Models;

namespace TL.Domain.Services
{
    public interface IBaseService
    {
        Task<SaveBaseEntityResponse> SaveEntity(BaseEntity entity);

        Task<T> GetEntityById<T>(int id);
    }
}