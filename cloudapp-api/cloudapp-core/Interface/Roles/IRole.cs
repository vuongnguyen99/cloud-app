using cloudapp_core.Models.Role;
using cloudapp_data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cloudapp_core.Interface.Roles
{
    public interface IRole
    {
        Task<Role> CreateRole(CreateRole request,CancellationToken cancellationToken);
    }
}
