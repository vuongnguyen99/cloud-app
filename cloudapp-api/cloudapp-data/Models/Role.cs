using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cloudapp_data.Models
{
    public class Role: BaseModel
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public virtual ICollection<UserRole> UserRole { get; set; }

    }
}
