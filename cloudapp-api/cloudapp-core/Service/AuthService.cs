using cloudapp_core.Common;
using cloudapp_core.Interface;
using cloudapp_core.Interface.Users;
using cloudapp_core.Models.Auth;
using cloudapp_data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cloudapp_core.Service
{
    public class AuthService : Auth
    {
        private readonly CloudDBContext _cloudDBContext;
        private readonly IUserService _userService;
        public AuthService(CloudDBContext cloudDBContext, IUserService userService)
        {
            _cloudDBContext = cloudDBContext;
            _userService = userService;
        }

        //public async Task<AuthenticateResponse> Login(string username, string password, bool rememberMe)
        //{
        //   var user = await _cloudDBContext.Users.SingleOrDefaultAsync(x=> x.UserName == username);
        //    if(user == null)
        //    {
        //        throw new Exception($"Cann't find user with username {username}");
        //    }
        //    var verifiedPassword = Crypto.VerifyHashedPassword(user.Password, password);
        //    if(!verifiedPassword)
        //    {
        //        user.CountLoginFail += 1;
        //        _cloudDBContext.Update(user);
        //        await _cloudDBContext.SaveChangesAsync();
        //        throw new Exception("UserName or Password is incorrect");
        //    }
        //    List<string> userPermission = await _userService.GetRoleById(user.Guid);
        //    var jwtToken = Crypto.GenerateToken(user, userPermission);
        //    return new AuthenticateResponse
        //    {
        //        UserId = user.Guid,
        //        UserName = username,
        //        AccessToken = jwtToken
        //    };
        //}
    }
}
