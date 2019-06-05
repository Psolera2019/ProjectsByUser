using System;

namespace ProjectByUsers.Models
{
    public class UserByProject
    {
        public int ProjectId { get; set; }
        public DateTime  AssignedDate { get; set; }
        public DateTime  StartDate { get; set; }
        public String TimeToStart { get; set; }
        public DateTime  EndDate { get; set; }
        public int Credits { get; set; }
        public String IsActive { get; set; }
    }
}