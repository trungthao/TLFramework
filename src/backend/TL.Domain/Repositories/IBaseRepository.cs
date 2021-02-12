using System.Threading.Tasks;
using TL.Domain.Entities;
using System.Data;

namespace TL.Domain.Repositories
{
    public interface IBaseRepository
    {
        public Task<bool> SaveEntity(BaseEntity entity, IDbConnection conn = null, IDbTransaction trans = null);

        public Task<T> GetEntityById<T>(int id);
    }
}