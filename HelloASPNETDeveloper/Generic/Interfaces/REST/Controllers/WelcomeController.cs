using Microsoft.AspNetCore.Mvc;

namespace HelloASPNETDeveloper.Generic.Interfaces.REST.Controllers;

[ApiController]
[Route("[controller]")]
public class WelcomeController : ControllerBase
{
    [HttpGet]
    public string welcome()
    {
        return "Welcome!";
    }
}