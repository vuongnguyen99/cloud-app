using System;

namespace cloudapp_data.Models
{
    public class UserImage
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string ImagePath { get; set; }
        public DateTime CreatedDate { get; set; }
        public long FileSize { get; set; }
        public virtual User Users { get; set; }
    }
}
