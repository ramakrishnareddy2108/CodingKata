using Codingkata.Models;
using CodingKata.Manager.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CodingKata.Services.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[User]")]
    public class UserController : Controller
    {
        private readonly IUserManager _userManager;

        public IActionResult Registervaccination(VaccineRegister vaccineRegister)
        {
            return Ok(_userManager.RegisterVaccination(vaccineRegister));
        }
    }
}
