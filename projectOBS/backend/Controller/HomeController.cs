[Route("/")]
[ApiController]
public class HomeController : ControllerBase
{
    // GET api/home
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello, World!");
    }
}