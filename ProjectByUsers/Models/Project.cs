using System;

namespace ProjectByUsers.Models
{
    public class Project
    {
        public int Id { get; set; }
        public DateTime  StartDate { get; set; }
        public DateTime  EndDate { get; set; }
        public int Credits { get; set; }

    }
}