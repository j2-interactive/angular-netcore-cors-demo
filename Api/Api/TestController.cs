using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Api
{
    [Authorize]
    [ApiController]
    [Route("test")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public String Get()
        {
            return $"hello, {User.Identity.Name}";
        }
    }
}
