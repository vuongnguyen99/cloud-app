using cloudapp_core.Interface.Users;
using cloudapp_core.Models.User;
using cloudapp_data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace cloudapp_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        //[HttpPost]
        //[Route("create-user")]
        //public async Task<IActionResult> CreateNewUser([FromBody]CreateNewUserRequest request, CancellationToken cancellationToken)
        //{
        //    try
        //    {
        //        var newUser = await _userService.CreateNewUser(request, cancellationToken);
        //        return Ok(newUser);
        //    }
        //    catch(Exception ex)
        //    {
        //        return StatusCode(500, ex.Message);
        //    }
        //}
    }
}

//{
//    "firstName": "Nguyen",
//  "lastName": "Vuong",
//  "userName": "Vuong, Nguyen",
//  "email": "nqvuong7799@gmail.com",
//  "password": "Nguyenvuong",
//  "dateOfBirth": "1999-07-07T08:18:02.344Z",
//  "unsubcribedEmail": true
//}
