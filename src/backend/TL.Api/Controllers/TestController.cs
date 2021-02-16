using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TL.API.Controllers;
using TL.Domain.Entities;
using TL.Domain.Models;
using TL.Domain.Services;

namespace TL.Api.Controllers
{
    public class TestController : BaseController
    {
        private readonly ITestService _testService;
        public TestController(IMapper mapper, ITestService service) : base(mapper, service)
        {
            _testService = service;
        }

        [HttpPost("")]
        public async Task<IActionResult> SaveEntity(SaveTestRequest saveTestRequest)
        {
            var testEntity = _mapper.Map<Test>(saveTestRequest);
            await _testService.SaveEntity(testEntity);

            return Ok();
        }
    }
}