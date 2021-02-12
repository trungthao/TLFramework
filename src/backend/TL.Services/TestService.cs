using Microsoft.Extensions.Options;
using TL.Domain.Constants;
using TL.Domain.Repositories;
using TL.Domain.Services;

namespace TL.Services
{
    public class TestService : BaseService, ITestService
    {
        public TestService(ITestRepository repository, IOptions<AppSettings> appSettings) : base(repository, appSettings)
        {
        }
    }
}