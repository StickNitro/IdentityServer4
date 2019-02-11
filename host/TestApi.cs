using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Host
{
    [Route("test")]
    [Authorize(AuthenticationSchemes = "local")]
    public class TestController
    {
        public string Get()
        {
            return "ok";
        }
    }
}
