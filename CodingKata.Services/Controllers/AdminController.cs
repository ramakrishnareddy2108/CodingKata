using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CodingKata.Services.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[Admin]")]
    public class AdminController : Controller
    {
    }
}
