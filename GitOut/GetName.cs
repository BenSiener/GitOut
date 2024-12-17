using Microsoft.AspNetCore.Mvc;

namespace GitOut
{
    [ApiController]
    [Route("[controller]")]
    public class GetName : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Name = "Ben Siener" });
        }
    }
}
