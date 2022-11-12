using cloudapp_core.Common;
using cloudapp_core.Interface.Roles;
using cloudapp_core.Models.Role;
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
    public class RoleService: IRole
    {
        private readonly CloudDBContext _context;
        public RoleService(CloudDBContext context)
        {
            _context = context;
        }

        public async Task<Role> CreateRole(CreateRole request, CancellationToken cancellationToken)
        {
            var newRole = new Role()
            {
                Guid = Guid.NewGuid(),
                Name = request.Name,
                CreateDate = DateTime.UtcNow,
                ModifiedDate = DateTime.UtcNow,
            };

            await _context.Roles.AddAsync(newRole, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return new Role
            {
                Guid = newRole.Guid,
                Name = newRole.Name,
            };
        }
    }
}
