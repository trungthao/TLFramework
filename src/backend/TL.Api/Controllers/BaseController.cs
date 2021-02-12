using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TL.Domain.Entities;
using TL.Domain.Services;

namespace TL.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController : ControllerBase
    {
        protected readonly IMapper _mapper;
        protected readonly IBaseService _service;

        public BaseController(IMapper mapper, IBaseService service)
        {
            _mapper = mapper;
            _service = service;
        }

        /// <summary>
        /// Lấy địa chỉ IP của client
        /// </summary>
        /// <returns></returns>
        protected string IpAddress()
        {
            if (Request.Headers.ContainsKey("X-Forwarded-For"))
            {
                return Request.Headers["X-Forwared-For"];
            }

            return HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
        }
    }
}