using cloudapp_core.Interface.Users;
using cloudapp_core.Models.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace cloudapp_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateNewUser(CreateNewUserRequest request, CancellationToken cancelationToken)
        {
            try
            {
                var newUser = await _userService.CreateNewUser(request, cancelationToken);
                return Ok(newUser);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
