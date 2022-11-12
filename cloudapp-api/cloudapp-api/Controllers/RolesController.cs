using cloudapp_core.Interface.Roles;
using cloudapp_core.Interface.Users;
using cloudapp_core.Models.Role;
using cloudapp_core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace cloudapp_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRole _roleService;
        public RolesController(IRole roleService)
        {
            _roleService = roleService;
        }

        [HttpPost] 
        public async Task<IActionResult> Post([FromBody] CreateRole request, CancellationToken cancelationToken)
        {
            try
            {
                var newUser = await _roleService.CreateRole(request, cancelationToken);
                return Ok(newUser);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
