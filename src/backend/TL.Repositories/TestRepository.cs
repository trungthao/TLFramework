using TL.Domain.Repositories;
using TL.Domain.Services;

namespace TL.Repositories
{
    public class TestRepository : BaseRepository, ITestRepository
    {
        public TestRepository(IDatabaseService databaseService) : base(databaseService)
        {

        }
    }
}