using System;

namespace ProjectByUsers.Models
{
    public class UserProject
    {
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public Boolean IsActive { get; set; }
        public DateTime AssignedDate { get; set; }
    }
}