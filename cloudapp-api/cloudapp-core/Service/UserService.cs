using cloudapp_core.Interface.Users;
using cloudapp_core.Models.User;
using cloudapp_data.Context;
using cloudapp_data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using cloudapp_core.Common;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace cloudapp_core.Service
{
    public class UserService : IUserService
    {
        private readonly CloudDBContext _context;
        public UserService(CloudDBContext context)
        {
            _context = context;
        }

        public Task<User> GetRoleByUserId(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> CreateNewUser(CreateNewUserRequest request, CancellationToken cancellationToken)
        {
            var userNameReq = request.UserName.ToLower();
            var userObj = await _context.Users.FirstOrDefaultAsync(c => c.UserName == userNameReq, cancellationToken);
            if(userObj != null)
            {
                var objectError = new List<object>();
                if(userObj.UserName == userNameReq)
                {
                    objectError.Add( new { field = "UserName", message = "UserName is already exist"});
                }
                var jsonString = JsonSerializer.Serialize(objectError);
                throw new Exception(jsonString);
            }
            var newUser = new User()
            {
                Guid = Guid.NewGuid(),
                FirstName = request.FirstName,
                LastName = request.LastName,
                UserName = request.UserName,
                Email = request.Email,
                Password = Crypto.HashPassword(request.Password),
                Active = true,
                CreateDate = DateTime.UtcNow,
                ModifiedDate = DateTime.UtcNow,
            };

            await _context.Users.AddAsync(newUser, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            // assign role for user
            //var role =  _context.Roles;
            //var userRole = new List<UserRole>();
            //foreach (var items in role)
            //{
            //    var urItem = new UserRole
            //    {
            //        Id = items.Id,
            //        UserId = newUser.Id,
            //        RoleId = role.Id
                    
            //    };
            //}

            return new User
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                UserName = request.UserName,
                Email = request.Email,
                Password = Crypto.HashPassword(request.Password),
                CountLoginFail = 0
            };

        }
    }
}
