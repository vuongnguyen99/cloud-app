using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cloudapp_core.Models.Auth
{
    public class AuthenticateResponse
    {
        public Guid UserId { get; set; }
        public string AccessToken { get; set; }
        public string UserName { get; set; }
    }
}
