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

namespace cloudapp_core.Service
{
    public class UserService : IUserService
    {
        private readonly CloudDBContext _context;
        public UserService(CloudDBContext context)
        {
            _context = context;
        }

        public Task<User> CreateNewUser(CreateNewUserRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
