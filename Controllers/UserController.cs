using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DQMA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;

        public UserController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        //[Authorize]
        [HttpGet("role")]
        public async Task<IActionResult> GetCurrentUserRole()
        {
            var userName = User.FindFirst(ClaimTypes.Name).Value;
            var user = await _userManager.FindByNameAsync(userName);
            //var role = await _userManager.GetRolesAsync(user);

            //if (!role.Any()) return NotFound();

            return Ok();
        }

    }
}
