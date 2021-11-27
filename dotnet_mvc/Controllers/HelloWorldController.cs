using Microsoft.AspNetCore.Mvc;

namespace dotnet_mvc.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloWorldController : ControllerBase
{
  private readonly ILogger<HelloWorldController> _logger;

  public HelloWorldController(ILogger<HelloWorldController> logger)
  {
    _logger = logger;
  }

  [HttpGet(Name = "GetHelloWorld")]
  public async Task<ActionResult<String>> Get()
  {
    return await Task.FromResult("Hello World!");
  }

}
