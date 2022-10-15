using System;
using System.Collections.Generic;

namespace cloudapp_data.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? LastModified { get; set; }
        public string CreateBy { get; set; }
        public bool? UnsubcribedEmail { get; set; }
        public int? CountLoginFail { get; set; }
        public virtual List<UserImage> UserImages { get; set; }
        public virtual Salary Salaries { get; set; }
    }
}
