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
using System.Security.Cryptography;

namespace cloudapp_core.Service
{
    public class UserService : IUserService
    {
        private readonly CloudDBContext _context;
        public UserService(CloudDBContext context)
        {
            _context = context;
        }

        //public async Task<User> CreateNewUser(CreateNewUserRequest request, CancellationToken cancellationToken)
        //{
        //    var user = new CreateNewUserRequest()
        //    {
        //        Id = Guid.NewGuid(),
        //        FirstName = request.FirstName,
        //        LastName = request.LastName,
        //        UserName = request.UserName,
        //        Email = request.Email,
        //        DateOfBirth = request.DateOfBirth,
        //        Password = HashSHA256(request.Password),
        //        UnsubcribedEmail = request.UnsubcribedEmail
        //    };

        //     _context.Add(user);
        //    await _context.SaveChangesAsync(cancellationToken);
        //    return new User
        //    {
        //        Id = request.Id,
        //        FirstName = request.FirstName,
        //        LastName = request.LastName,
        //        UserName = request.UserName,
        //        Email = request.Email,
        //        DateOfBirth = request.DateOfBirth,
        //        Created = DateTime.UtcNow,
        //        Password = HashSHA256(request.Password),
        //        UnsubcribedEmail = request.UnsubcribedEmail,
        //        CountLoginFail =0
        //    };
        //}

        private string HashSHA256(string str)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute the hash of the given string
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(str));

                StringBuilder stringbuilder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    stringbuilder.Append(bytes[i].ToString("x2"));
                }
                return stringbuilder.ToString();
            }
        }
    }
}
