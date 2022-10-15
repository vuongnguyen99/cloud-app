using System;

namespace cloudapp_data.Models
{
    public class Salary
    {
        public Guid Id { set; get; }
        public DateTime DateSalary { set; get; }
        public Guid UserId { set; get; }
        public double PayRate { set; get; }
        public virtual User Users { get; set; }
    }
}
