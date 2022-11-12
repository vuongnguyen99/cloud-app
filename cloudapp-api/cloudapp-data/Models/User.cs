using System;
using System.Collections.Generic;

namespace cloudapp_data.Models
{
    public class User: BaseModel
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public bool? UnsubcribedEmail { get; set; }
        public int? CountLoginFail { get; set; }
        //public virtual ICollection<UserImage> UserImages { get; set; }
        //public virtual Salary Salaries { get; set; }
        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
